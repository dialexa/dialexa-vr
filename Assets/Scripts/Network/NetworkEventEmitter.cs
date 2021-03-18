using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Network
{
    public class NetworkEventEmitter : MonoBehaviour
    {
        public StringEvent networkStringEvent;
        public string eventName;

        public void Invoke()
        {
            networkStringEvent.Raise(eventName);
        }
    }
}
