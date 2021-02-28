using UnityEngine;

namespace Room
{
    public class NetworkUser : MonoBehaviour
    {
        private UserState _userState;

        public void SetUserState(UserState state)
        {
            _userState = state;
            transform.position = new Vector3(state.Pos.X, state.Pos.Y, state.Pos.Z);
            transform.eulerAngles = new Vector3(state.Rot.X, state.Rot.Y, state.Rot.Z);
        }
    }
}
