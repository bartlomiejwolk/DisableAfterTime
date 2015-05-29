using UnityEngine;
using System.Collections;
using UnityEditor;
using OneDayGame;

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

            EditorGUILayout.PropertyField(targetGO);
            EditorGUILayout.PropertyField(delay);

            serializedObject.ApplyModifiedProperties();
        }

    }

}
