using System;
using UnityEngine;

namespace Utils
{
    public class ForceApplier : MonoBehaviour
    {
        public Rigidbody body;
        public Vector3 force;
        public Vector3 position;

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.magenta;
            Gizmos.DrawSphere(transform.TransformPoint(position), 0.2f);
            Gizmos.DrawRay(transform.TransformPoint(position), -transform.TransformDirection(force));
        }

        public void ApplyForce()
        {
            body.AddForceAtPosition(-transform.TransformDirection(force), transform.TransformPoint(position), ForceMode.Impulse);
        }
    }
}
