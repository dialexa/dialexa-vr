using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `RoomStatePair`. Inherits from `AtomEventReferenceListener&lt;RoomStatePair, RoomStatePairEvent, RoomStatePairEventReference, RoomStatePairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/RoomStatePair Event Reference Listener")]
    public sealed class RoomStatePairEventReferenceListener : AtomEventReferenceListener<
        RoomStatePair,
        RoomStatePairEvent,
        RoomStatePairEventReference,
        RoomStatePairUnityEvent>
    { }
}
