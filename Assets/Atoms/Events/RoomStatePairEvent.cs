using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `RoomStatePair`. Inherits from `AtomEvent&lt;RoomStatePair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/RoomStatePair", fileName = "RoomStatePairEvent")]
    public sealed class RoomStatePairEvent : AtomEvent<RoomStatePair>
    {
    }
}
