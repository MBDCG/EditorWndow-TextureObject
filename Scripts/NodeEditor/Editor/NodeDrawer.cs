using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEditor;

namespace NodeEditor.Editor
{
    [CustomPropertyDrawer(typeof(NodeItem))]
    class NodeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GUI.Box(position, label);

            new BoolSendDrawer().OnGUI(new Rect(position.xMin + 40, position.yMin + 60, position.width - 80, position.height - 60), property, label);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return 100;
        }
    }
}
