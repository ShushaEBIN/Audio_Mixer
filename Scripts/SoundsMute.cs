using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundsMute : MonoBehaviour
{
    private const int _multiplier = 20;
    private const float _minVolume = -80f;
    private const float _maxVolume = 0f;

    [SerializeField] private AudioMixerGroup _audioGroup;
    [SerializeField] private Button _button;

    private bool _isMuted = false;

    private void OnEnable()
    {
        _button.onClick.AddListener(ToggleMute);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ToggleMute);
    }

    private void ToggleMute()
    {
        if (_isMuted)
        {
            _isMuted = false;
            
            _audioGroup.audioMixer.SetFloat(_audioGroup.name, _maxVolume * _multiplier);
            
        }
        else
        {
            _isMuted = true;
            
            _audioGroup.audioMixer.SetFloat(_audioGroup.name, _minVolume * _multiplier);
        }
    }
}