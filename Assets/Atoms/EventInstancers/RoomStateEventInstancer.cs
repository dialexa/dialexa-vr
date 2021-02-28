using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `RoomState`. Inherits from `AtomEventInstancer&lt;RoomState, RoomStateEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/RoomState Event Instancer")]
    public class RoomStateEventInstancer : AtomEventInstancer<RoomState, RoomStateEvent> { }
}
