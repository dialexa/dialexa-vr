using UnityEngine;
using UnityEngine.Events;

namespace Room
{
    [RequireComponent(typeof(Collider))]
    public class Interactable : MonoBehaviour
    {
        public string interactionText;
        public UnityEvent onInteraction;
        
        public void TriggerInteraction()
        {
            onInteraction.Invoke();
        }
    }
}
