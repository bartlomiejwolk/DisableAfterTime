using UnityEditor;
using UnityEngine;

namespace DisableAfterTimeEx {

    [CustomEditor(typeof (DisableAfterTime))]
    public class DisableAfterTimeEditor : Editor {

        private SerializedProperty targetGO;
        private SerializedProperty delay;

        private void OnEnable() {
            targetGO = serializedObject.FindProperty("targetGO");
            delay = serializedObject.FindProperty("delay");
        }

        public override void OnInspectorGUI() {
            serializedObject.Update();

            DrawTargetGOField();
            DrawDelayField();

            serializedObject.ApplyModifiedProperties();
        }

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

    }

}
