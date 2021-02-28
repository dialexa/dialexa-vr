#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `RoomState`. Inherits from `AtomDrawer&lt;RoomStateVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(RoomStateVariable))]
    public class RoomStateVariableDrawer : VariableDrawer<RoomStateVariable> { }
}
#endif
