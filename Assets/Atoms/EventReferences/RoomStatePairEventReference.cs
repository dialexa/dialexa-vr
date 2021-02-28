using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `RoomStatePair`. Inherits from `AtomEventReference&lt;RoomStatePair, RoomStateVariable, RoomStatePairEvent, RoomStateVariableInstancer, RoomStatePairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class RoomStatePairEventReference : AtomEventReference<
        RoomStatePair,
        RoomStateVariable,
        RoomStatePairEvent,
        RoomStateVariableInstancer,
        RoomStatePairEventInstancer>, IGetEvent 
    { }
}
