using UnityEngine;

public class SoundsMute : MonoBehaviour
{
    private int _mute = 0;
    private int _unmuted = 1;
    private bool _muted = false;

    public void MuteToggle()
    {
        if (_muted)
        {
            _muted = false;

            AudioListener.volume = _unmuted;
            
        }
        else
        {
            _muted = true;

            AudioListener.volume = _mute;
        }
    }
}