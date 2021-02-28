using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `RoomState`. Inherits from `SetVariableValue&lt;RoomState, RoomStatePair, RoomStateVariable, RoomStateConstant, RoomStateReference, RoomStateEvent, RoomStatePairEvent, RoomStateVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/RoomState", fileName = "SetRoomStateVariableValue")]
    public sealed class SetRoomStateVariableValue : SetVariableValue<
        RoomState,
        RoomStatePair,
        RoomStateVariable,
        RoomStateConstant,
        RoomStateReference,
        RoomStateEvent,
        RoomStatePairEvent,
        RoomStateRoomStateFunction,
        RoomStateVariableInstancer>
    { }
}
