using System;
using UnityEngine;

namespace User
{
    [RequireComponent(typeof(CharacterController))]
    public class UserMovement : MonoBehaviour
    {
        public float speed = 5.0f;
        private CharacterController _controller;

        private void Awake()
        {
            _controller = GetComponent<CharacterController>();
        }

        private void Update()
        {
            var forward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            var sideways = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

            var t = transform;
            _controller.Move(t.forward * forward + t.right * sideways);
        }
    }
}
