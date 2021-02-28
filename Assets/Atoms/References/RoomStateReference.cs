using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `RoomState`. Inherits from `AtomReference&lt;RoomState, RoomStatePair, RoomStateConstant, RoomStateVariable, RoomStateEvent, RoomStatePairEvent, RoomStateRoomStateFunction, RoomStateVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class RoomStateReference : AtomReference<
        RoomState,
        RoomStatePair,
        RoomStateConstant,
        RoomStateVariable,
        RoomStateEvent,
        RoomStatePairEvent,
        RoomStateRoomStateFunction,
        RoomStateVariableInstancer>, IEquatable<RoomStateReference>
    {
        public RoomStateReference() : base() { }
        public RoomStateReference(RoomState value) : base(value) { }
        public bool Equals(RoomStateReference other) { return base.Equals(other); }
        protected override bool ValueEquals(RoomState other)
        {
            throw new NotImplementedException();
        }
    }
}
