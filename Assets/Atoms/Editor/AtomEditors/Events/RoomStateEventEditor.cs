#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `RoomState`. Inherits from `AtomEventEditor&lt;RoomState, RoomStateEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(RoomStateEvent))]
    public sealed class RoomStateEventEditor : AtomEventEditor<RoomState, RoomStateEvent> { }
}
#endif
