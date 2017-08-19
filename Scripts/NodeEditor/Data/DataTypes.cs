using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace NodeEditor
{
    [Serializable]
    public abstract class DataTypes : UnityEngine.Object
    {
        int ID;
        string name;
    }
    public class IntSend : DataTypes
    {
        int Amm;
    }
    public class BoolSend : DataTypes
    {
        bool Amm;
    }

}
