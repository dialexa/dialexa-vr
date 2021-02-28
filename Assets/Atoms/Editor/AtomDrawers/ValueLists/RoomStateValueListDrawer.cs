#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `RoomState`. Inherits from `AtomDrawer&lt;RoomStateValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(RoomStateValueList))]
    public class RoomStateValueListDrawer : AtomDrawer<RoomStateValueList> { }
}
#endif
