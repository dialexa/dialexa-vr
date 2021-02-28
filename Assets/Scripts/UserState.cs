using System;
using UnityEngine;

[Serializable]
public class UserState
{
    [Serializable]
    public struct V3
    {
        public float X;
        public float Y;
        public float Z;
    }

    public string Name;
    public V3 Pos;
    public V3 Rot;
}
