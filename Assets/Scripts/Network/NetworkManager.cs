using System;
using System.Text;
using HybridWebSocket;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Network
{
    public class NetworkManager : MonoBehaviour
    {
        public StringVariable usernameVariable;
        public RoomStateVariable roomStateVariable;
        public StringVariable serverUrlVariable;
        public UnityEvent serverConnected;
        
        private WebSocket _ws;
        private bool _connected;
        private bool _connectedInvoked;
        private RoomState _newRoomState;
        
        public void Connect()
        {
            _ws = WebSocketFactory.CreateInstance($"{serverUrlVariable.Value}/join/{usernameVariable.Value}");

            _ws.OnOpen += () =>
            {
                Debug.Log("WS connected!");
                _connected = true;
            };

            _ws.OnMessage += (byte[] msg) =>
            {
                var message = Encoding.UTF8.GetString(msg);
                // Debug.Log("WS received message: " + message);
                var roomState = JsonUtility.FromJson<RoomState>(message);
                _newRoomState = roomState;
            };
            
            _ws.Connect();
        }

        public void Send(string message)
        {
            if (_ws == null || _ws.GetState() != WebSocketState.Open) return;
            _ws.Send(Encoding.UTF8.GetBytes(message));
        }

        private void Update()
        {
            if (_newRoomState != null)
            {
                roomStateVariable.SetValue(_newRoomState);
                _newRoomState = null;
            }
            
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
