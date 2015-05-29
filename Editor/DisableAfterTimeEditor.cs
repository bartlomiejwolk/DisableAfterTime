using UnityEngine;
using System.Collections;
using UnityEditor;
using OneDayGame;

namespace DisableAfterTimeEx {

    [CustomEditor(typeof (DisableAfterTime))]
    public class DisableAfterTimeEditor : Editor {

        private SerializedProperty _target;
        private SerializedProperty _delay;

        private void OnEnable() {
            _target = serializedObject.FindProperty("_target");
            _delay = serializedObject.FindProperty("_delay");
        }

        public override void OnInspectorGUI() {
            serializedObject.Update();

            EditorGUILayout.PropertyField(_target);
            EditorGUILayout.PropertyField(_delay);

            serializedObject.ApplyModifiedProperties();
        }

    }

}
