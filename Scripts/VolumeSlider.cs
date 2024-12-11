using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private Slider _slider;

    private string _parameterName;

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
        _audioMixer.SetFloat(_parameterName, Mathf.Log10(volume) * 20);
    }

    public void SetName(string name)
    {
        _parameterName = name;
    }
}