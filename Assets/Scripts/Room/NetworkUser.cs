using TMPro;
using UnityEngine;

namespace Room
{
    public class NetworkUser : MonoBehaviour
    {
        public TextMeshProUGUI text;
        public NetworkUserLaser laser;
        private UserState _userState;

        public void SetUserState(UserState state)
        {
            _userState = state;
            transform.position = new Vector3(state.Pos.X, state.Pos.Y, state.Pos.Z);
            transform.eulerAngles = new Vector3(state.Rot.X, state.Rot.Y, state.Rot.Z);

            text.text = state.Name;

            laser.enabled = state.LaserActive;

            if (state.LaserActive) {
                laser.laserPosition = new Vector3(state.LaserPos.X, state.LaserPos.Y, state.LaserPos.Z);
            }
            
            if (!state.Active)
                Destroy(gameObject);
        }
    }
}
