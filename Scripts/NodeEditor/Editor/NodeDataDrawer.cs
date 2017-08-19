using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using NodeEditor;

[CustomPropertyDrawer(typeof(IntSend))]
public class IntSendDrawer : PropertyDrawer {

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        GUI.Button(position, "I");
    }
}
[CustomPropertyDrawer(typeof(BoolSend))]
public class BoolSendDrawer : PropertyDrawer
{

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        GUI.Button(position, "B");
    }
}
