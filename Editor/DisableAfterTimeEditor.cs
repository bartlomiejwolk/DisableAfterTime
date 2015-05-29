// Copyright (c) 2015 Bartlomiej Wolk (bartlomiejwolk@gmail.com)
// 
// This file is part of the DisableAfterTime extension for Unity. Licensed
// under the MIT license. See LICENSE file in the project root folder.

using UnityEditor;
using UnityEngine;

namespace DisableAfterTimeEx {

    [CustomEditor(typeof (DisableAfterTime))]
    public class DisableAfterTimeEditor : Editor {

        #region SERIALIZED PROPERTIES

        private SerializedProperty delay;
        private SerializedProperty targetGO;
        private SerializedProperty description;

        #endregion

        #region UNITY MESSAGES
        private void OnEnable() {
            targetGO = serializedObject.FindProperty("targetGO");
            delay = serializedObject.FindProperty("delay");
            description = serializedObject.FindProperty("description");
        }

        public override void OnInspectorGUI() {
            serializedObject.Update();

            DrawVersionLabel();
            DrawDescriptionTextArea();

            EditorGUILayout.Space();

            DrawTargetGOField();
            DrawDelayField();

            serializedObject.ApplyModifiedProperties();
        }

        #endregion

        #region INSPECTOR
        private void DrawDelayField() {
            EditorGUILayout.PropertyField(
                delay,
                new GUIContent(
                    "Delay",
                    "Delay before disabling target game object."));
        }

        private void DrawTargetGOField() {
            EditorGUILayout.PropertyField(
                targetGO,
                new GUIContent(
                    "Target",
                    "Game object to be disabled."));
        }

        private void DrawVersionLabel() {
            EditorGUILayout.LabelField(
                string.Format(
                    "{0} ({1})",
                    DisableAfterTime.Version,
                    DisableAfterTime.Extension));
        }

        private void DrawDescriptionTextArea() {
            description.stringValue = EditorGUILayout.TextArea(
                description.stringValue);
        }
 
        #endregion

        #region METHODS

        [MenuItem("Component/DisableAfterTime")]
        private static void AddEntryToComponentMenu() {
            if (Selection.activeGameObject != null) {
                Selection.activeGameObject.AddComponent(
                    typeof(DisableAfterTime));
            }
        }

        #endregion METHODS
    }

}