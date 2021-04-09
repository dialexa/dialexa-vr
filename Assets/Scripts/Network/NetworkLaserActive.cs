using System;
using UnityEngine;

namespace Network
{
    [RequireComponent(typeof(NetworkManager))]
    public class NetworkLaserActive : MonoBehaviour
    {
        private NetworkManager _networkManager;
        private string laserActive;

        private void Awake()
        {
            _networkManager = GetComponent<NetworkManager>();
        }

        public void Sync(string s)
        {
            _networkManager.Send($"laserActive|{s}");
        }
    }
}