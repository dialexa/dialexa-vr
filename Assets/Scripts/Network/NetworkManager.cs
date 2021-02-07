using System;
using System.Text;
using HybridWebSocket;
using UnityEngine;

namespace Network
{
    public class NetworkManager : MonoBehaviour
    {
        private WebSocket _ws;
        
        public void Connect(string username)
        {
            _ws = WebSocketFactory.CreateInstance($"ws://localhost:8080/join/{username}");

            _ws.OnOpen += () =>
            {
                Debug.Log("WS connected!");

                _ws.Send(Encoding.UTF8.GetBytes("ping"));
            };

            _ws.OnMessage += (byte[] msg) =>
            {
                Debug.Log("WS received message: " + Encoding.UTF8.GetString(msg));
            };
            
            _ws.Connect();
        }

        private void OnDestroy()
        {
            if (_ws.GetState() == WebSocketState.Closed) return;
            _ws.Close();
        }
    }
}
