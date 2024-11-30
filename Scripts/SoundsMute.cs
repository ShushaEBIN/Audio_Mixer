using UnityEngine;

public class SoundsMute : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void ToggleMute()
    {
        _audioSource.mute = !_audioSource.mute;
    }
}