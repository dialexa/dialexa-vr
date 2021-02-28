using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `RoomState`. Inherits from `AtomValueList&lt;RoomState, RoomStateEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/RoomState", fileName = "RoomStateValueList")]
    public sealed class RoomStateValueList : AtomValueList<RoomState, RoomStateEvent> { }
}
