using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEditor;
using System.Collections;
[SerializeField]

class NodeWindowDrawer : EditorWindow
{

    [MenuItem("Window/My Window")]

    public static void ShowWindow()
    {
        GetWindow(typeof(NodeWindowDrawer));
    }

    Texture GridTexture;
    
    void OnGUI()
    {

        //new NodeEditor.Editor.NodeDrawer().OnGUI(new Rect(50, 50, 500, 200), property, new GUIContent("a"));


        if (GridTexture == null)
        {
            GridTexture = (Texture2D)EditorGUI.ObjectField(new Rect(0, 0, 400, 60), "Grid", GridTexture, typeof(Texture2D));
        }
        Rect BR;
        if (GridTexture != null)
        {
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    BR = new Rect(i * 100, j * 100, 100, 100);
                    GUI.DrawTexture(BR, GridTexture);
                }
            }
        }


        
    }
}