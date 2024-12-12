using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    private const int _multiplier = 20;

    [SerializeField] private AudioMixerGroup _audioGroup;
    [SerializeField] private Slider _slider;

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(SetVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(SetVolume);
    }
    
    private void SetVolume(float volume)
    {
        _audioGroup.audioMixer.SetFloat(_audioGroup.name, Mathf.Log10(volume) * _multiplier);
    }
}