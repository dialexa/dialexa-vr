using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type RoomState to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync RoomState Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncRoomStateVariableInstancerToCollection : SyncVariableInstancerToCollection<RoomState, RoomStateVariable, RoomStateVariableInstancer> { }
}
