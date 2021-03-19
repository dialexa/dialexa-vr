using UnityEngine;

namespace Utils
{
    public class AudioPlayOneshot : MonoBehaviour
    {
        public AudioSource source;
        
        public void Play()
        {
            source.PlayOneShot(source.clip);
        }
    }
}
