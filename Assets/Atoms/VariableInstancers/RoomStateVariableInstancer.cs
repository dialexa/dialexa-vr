using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `RoomState`. Inherits from `AtomVariableInstancer&lt;RoomStateVariable, RoomStatePair, RoomState, RoomStateEvent, RoomStatePairEvent, RoomStateRoomStateFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/RoomState Variable Instancer")]
    public class RoomStateVariableInstancer : AtomVariableInstancer<
        RoomStateVariable,
        RoomStatePair,
        RoomState,
        RoomStateEvent,
        RoomStatePairEvent,
        RoomStateRoomStateFunction>
    { }
}
