using System;
using UnityEngine;
using UnityEngine.Events;

namespace Utils
{
    public class UnityEventLimiter : MonoBehaviour
    {
        public float timeout = 1f;
        public UnityEvent onInvoke;

        private float _currentTime;
        private bool _waiting = false;

        private void Update()
        {
            if (!_waiting) return;
            
            _currentTime += Time.deltaTime;
            if (_currentTime > timeout)
                _waiting = false;
        }

        public void Invoke()
        {
            if (_waiting) return;
            
            onInvoke.Invoke();
            _waiting = true;
            _currentTime = 0;

        }
    }
}
