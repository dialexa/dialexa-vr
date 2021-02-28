using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;RoomState&gt;`. Inherits from `IPair&lt;RoomState&gt;`.
    /// </summary>
    [Serializable]
    public struct RoomStatePair : IPair<RoomState>
    {
        public RoomState Item1 { get => _item1; set => _item1 = value; }
        public RoomState Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private RoomState _item1;
        [SerializeField]
        private RoomState _item2;

        public void Deconstruct(out RoomState item1, out RoomState item2) { item1 = Item1; item2 = Item2; }
    }
}