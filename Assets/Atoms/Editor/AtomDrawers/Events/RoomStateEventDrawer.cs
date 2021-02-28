#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `RoomState`. Inherits from `AtomDrawer&lt;RoomStateEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(RoomStateEvent))]
    public class RoomStateEventDrawer : AtomDrawer<RoomStateEvent> { }
}
#endif
