#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `RoomState`. Inherits from `AtomDrawer&lt;RoomStateConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(RoomStateConstant))]
    public class RoomStateConstantDrawer : VariableDrawer<RoomStateConstant> { }
}
#endif
