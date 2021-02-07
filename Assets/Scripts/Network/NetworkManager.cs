using System;
using System.Text;
using HybridWebSocket;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Network
{
    public class NetworkManager : MonoBehaviour
    {
        public StringVariable usernameVariable;
        public UnityEvent serverConnected;
        
        private WebSocket _ws;
        private bool _connected;
        private bool _connectedInvoked;
        
        public void Connect()
        {
            _ws = WebSocketFactory.CreateInstance($"ws://localhost:8080/join/{usernameVariable.Value}");

            _ws.OnOpen += () =>
            {
                Debug.Log("WS connected!");

                _ws.Send(Encoding.UTF8.GetBytes("ping"));

                _connected = true;
            };

            _ws.OnMessage += (byte[] msg) =>
            {
                Debug.Log("WS received message: " + Encoding.UTF8.GetString(msg));
            };
            
            _ws.Connect();
        }

        private void Update()
        {
            if (!_connected || _connectedInvoked) return;
            serverConnected.Invoke();
            _connectedInvoked = true;
        }

        private void OnDestroy()
        {
            if (_ws == null || _ws.GetState() == WebSocketState.Closed) return;
            _ws.Close();
        }
    }
}
