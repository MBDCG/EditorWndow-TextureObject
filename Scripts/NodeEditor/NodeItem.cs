using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodeEditor;
public enum NodeTypes
{
    Int,
    Bool
}
namespace NodeEditor
{
    public class NodeItem : Object
    {
        [SerializeField]
        public string name;
        [SerializeField]
        public IntSend[] IntInputs;
        //public BoolSend[] BoolInputs;
        //public IntSend IntInput;

        public virtual void SetOutput(int num, NodeTypes WantedType)
        {
            if (WantedType == NodeTypes.Int)
            {

            }
            else if (WantedType == NodeTypes.Bool)
            {

            }
        }
    }
}