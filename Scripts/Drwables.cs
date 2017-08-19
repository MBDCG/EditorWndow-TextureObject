using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace MyEditorVis
{
    [System.Serializable]
    public class Button
    {
        int type;
        string Name;
        int Id;
        Texture2D Texture;
        Vector2 Pos;
        bool IsClicked;
        Button(int id, Texture2D texure)
        {
            type = 0;
            Id = id;
            Name = "";
            Texture = null;
        }
        Button(int id, string name)
        {
            type = 1;
            Id = id;
            Name = "";
            Texture = null;
        }
        Button(int id, string name, Texture2D texure)
        {
            type = 2;
            Id = id;
            Name = "";
            Texture = null;
        }
    }






}

