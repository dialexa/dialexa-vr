#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `RoomStatePair`. Inherits from `AtomEventEditor&lt;RoomStatePair, RoomStatePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(RoomStatePairEvent))]
    public sealed class RoomStatePairEventEditor : AtomEventEditor<RoomStatePair, RoomStatePairEvent> { }
}
#endif
