using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `RoomState`. Inherits from `AtomEventReference&lt;RoomState, RoomStateVariable, RoomStateEvent, RoomStateVariableInstancer, RoomStateEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class RoomStateEventReference : AtomEventReference<
        RoomState,
        RoomStateVariable,
        RoomStateEvent,
        RoomStateVariableInstancer,
        RoomStateEventInstancer>, IGetEvent 
    { }
}
