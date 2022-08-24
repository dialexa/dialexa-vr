using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace User
{
    [RequireComponent(typeof(CharacterController))]
    public class UserMovement : MonoBehaviour
    {
        public float speed = 5.0f;
        public InputAction movement;
        private CharacterController _controller;

        private void Awake()
        {
            _controller = GetComponent<CharacterController>();
        }

        void OnEnable()
        {
            movement.Enable();
        }

        void OnDisable()
        {
            movement.Disable();
        }

        private void Update()
        {
            
            var forward = movement.ReadValue<Vector2>().y * speed * Time.deltaTime;
            var sideways = movement.ReadValue<Vector2>().x * speed * Time.deltaTime;

            var g = Vector3.down * (9.8f * Time.deltaTime);

            var t = transform;
            _controller.Move(t.forward * forward + t.right * sideways + g);
        }
    }
}
