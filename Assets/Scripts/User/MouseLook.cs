using System;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

namespace User
{
    public class MouseLook : MonoBehaviour
    {
        public float mouseSensitivity = 100f;
        public Transform userBody;
        private float _xRotation = 0f;
        private float _yRotation = 0f;

        public void LockCursor()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update()
        {
            var x = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            var y = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            _xRotation -= y;
            _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

            _yRotation += x;
            
            transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
            userBody.localRotation = Quaternion.Euler(0f, _yRotation, 0f);
        }
    }
}
