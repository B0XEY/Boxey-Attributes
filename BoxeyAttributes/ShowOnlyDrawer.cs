using UnityEditor;
using UnityEngine;

namespace BoxeyAttributes {
    public class ShowOnlyAttribute : PropertyAttribute{ }
#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(ShowOnlyAttribute))]
    public class ShowOnlyDrawer : PropertyDrawer{
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label){
            EditorGUI.BeginDisabledGroup(true);
            EditorGUI.PropertyField(position, property, label);
            EditorGUI.EndDisabledGroup();
        }
    }
#endif
}