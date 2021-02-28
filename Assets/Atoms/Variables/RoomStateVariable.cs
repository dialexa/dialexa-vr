using UnityEngine;
using System;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `RoomState`. Inherits from `AtomVariable&lt;RoomState, RoomStatePair, RoomStateEvent, RoomStatePairEvent, RoomStateRoomStateFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/RoomState", fileName = "RoomStateVariable")]
    public sealed class RoomStateVariable : AtomVariable<RoomState, RoomStatePair, RoomStateEvent, RoomStatePairEvent, RoomStateRoomStateFunction>
    {
        protected override bool ValueEquals(RoomState other)
        {
            return false;
        }
    }
}
