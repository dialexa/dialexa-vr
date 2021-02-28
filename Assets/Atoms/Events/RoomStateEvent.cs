using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `RoomState`. Inherits from `AtomEvent&lt;RoomState&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/RoomState", fileName = "RoomStateEvent")]
    public sealed class RoomStateEvent : AtomEvent<RoomState>
    {
    }
}
