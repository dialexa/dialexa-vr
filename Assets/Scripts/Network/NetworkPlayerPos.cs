using System;
using UnityEngine;

namespace Network
{
    [RequireComponent(typeof(NetworkManager))]
    public class NetworkPlayerPos : MonoBehaviour
    {
        private NetworkManager _networkManager;

        private void Awake()
        {
            _networkManager = GetComponent<NetworkManager>();
        }

        public void Sync(Vector3 vector)
        {
            Sync(JsonUtility.ToJson(vector));
        }

        public void Sync(string s)
        {
            _networkManager.Send($"pos|{s}");
        }
    }
}