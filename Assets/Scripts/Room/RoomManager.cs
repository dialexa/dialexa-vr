using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Room
{
    public class RoomManager : MonoBehaviour
    {
        public GameObject networkUserPrefab;
        public StringVariable nameVariable;
        private Dictionary<string, NetworkUser> _users;
        private Transform _userTransform;

        private void Awake()
        {
            _users = new Dictionary<string, NetworkUser>();
            var u = new GameObject("Users");
            u.transform.parent = transform;
            _userTransform = u.transform;
        }

        public void SyncRoomState(RoomState roomState)
        {
            foreach (var roomStateUser in roomState.Users)
            {
                var n = roomStateUser.Name;
                if (n == nameVariable.Value) continue;
                
                if (!_users.ContainsKey(n))
                    _users.Add(n, CreateNetworkUser(n));
                    
                _users[n].SetUserState(roomStateUser);
            }
        }

        private NetworkUser CreateNetworkUser(string userName)
        {
            var user = Instantiate(networkUserPrefab, transform);
            var netUser = user.GetComponent<NetworkUser>();

            return netUser;
        }
    }
}
