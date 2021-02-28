using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `RoomState`. Inherits from `AtomEventReferenceListener&lt;RoomState, RoomStateEvent, RoomStateEventReference, RoomStateUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/RoomState Event Reference Listener")]
    public sealed class RoomStateEventReferenceListener : AtomEventReferenceListener<
        RoomState,
        RoomStateEvent,
        RoomStateEventReference,
        RoomStateUnityEvent>
    { }
}
