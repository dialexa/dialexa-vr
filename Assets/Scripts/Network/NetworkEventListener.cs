using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Network
{
    public class NetworkEventListener : MonoBehaviour
    {
        public StringEvent receivedEvent;
        public string eventName;
        public UnityEvent onEventReceived;

        private void Awake()
        {
            receivedEvent.Register(ReceivedEvent);
        }

        private void ReceivedEvent(string n)
        {
            if (eventName != n) return;
            onEventReceived.Invoke();
        }
    }
}
