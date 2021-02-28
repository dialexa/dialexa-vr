using System;
using UnityEngine;

namespace Network
{
    [RequireComponent(typeof(NetworkManager))]
    public class NetworkCommand : MonoBehaviour
    {
        public string command;
        private NetworkManager _networkManager;

        private void Awake()
        {
            _networkManager = GetComponent<NetworkManager>();
        }

        public void Sync(Vector3 vector)
        {
            Sync($"{command}|{JsonUtility.ToJson(vector)}");
        }

        public void Sync(string s)
        {
            _networkManager.Send(s);
        }
    }
}
