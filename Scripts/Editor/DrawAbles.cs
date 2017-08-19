using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using MyEditorVis;

[CustomPropertyDrawer(typeof(Button))]
public class MyButton : PropertyDrawer {
	public override float GetPropertyHeight (SerializedProperty property, GUIContent label)
	{
		return base.GetPropertyHeight (property, label);
	}
	public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
	{
        
	}
}



[CustomPropertyDrawer(typeof(NodeEditor.NodeItem))]
public class MyNode : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        float S = 0;
        Object inputs = property.FindPropertyRelative("Inputs").objectReferenceValue;
        //(NodeEditor.DataSender)inputs;
        return S;
    }
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        Rect BaseBoxR = new Rect(position.position + new Vector2(0, 10), position.size - new Vector2(0,10));
        GUI.Box(BaseBoxR,"Node Content");

    }
}