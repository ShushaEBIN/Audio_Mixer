using UnityEngine;
using UnityEngine.UI;

public class SoundsMute : MonoBehaviour
{
    private const int _mute = 0;
    private const int _unmuted = 1;

    [SerializeField] private Button _button;

    private bool _isMuted = false;

    private void OnEnable()
    {
        _button.onClick.AddListener(Mute);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Mute);
    }

    private void Mute()
    {
        if (_isMuted)
        {
            _isMuted = false;

            AudioListener.volume = _unmuted;
            
        }
        else
        {
            _isMuted = true;

            AudioListener.volume = _mute;
        }
    }
}