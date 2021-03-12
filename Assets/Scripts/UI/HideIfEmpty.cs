using System;
using UnityEngine;

namespace UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public class HideIfEmpty : MonoBehaviour
    {
        private CanvasGroup _group;

        private void Awake()
        {
            _group = GetComponent<CanvasGroup>();
        }

        public void StringChanged(string s)
        {
            _group.alpha = string.IsNullOrEmpty(s) ? 0 : 1;
        }
    }
}