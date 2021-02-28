using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `RoomState`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(RoomStateVariable))]
    public sealed class RoomStateVariableEditor : AtomVariableEditor<RoomState, RoomStatePair> { }
}
