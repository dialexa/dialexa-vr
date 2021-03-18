using System;
using Room;
using UnityEngine;
using UnityEngine.Events;

namespace User
{
    public class Interactor : MonoBehaviour
    {
        public UnityEvent<string> interactionTextChanged;
        private Interactable _currentInteractable;

        private void Update()
        {
            if (_currentInteractable && Input.GetMouseButtonDown(0))
                _currentInteractable.TriggerInteraction();
        }

        private void OnTriggerEnter(Collider other)
        {
            var interactable = other.GetComponent<Interactable>();
            if (!interactable) return;

            _currentInteractable = interactable;
            interactionTextChanged.Invoke(_currentInteractable.interactionText);
        }

        private void OnTriggerExit(Collider other)
        {
            var interactable = other.GetComponent<Interactable>();
            if (!interactable) return;

            if (interactable != _currentInteractable) return;
            _currentInteractable = null;
            interactionTextChanged.Invoke(null as string);
        }
    }
}
