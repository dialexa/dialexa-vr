using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `RoomState`. Inherits from `UnityEvent&lt;RoomState&gt;`.
    /// </summary>
    [Serializable]
    public sealed class RoomStateUnityEvent : UnityEvent<RoomState> { }
}
