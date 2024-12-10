using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ChangerVolume : MonoBehaviour
{
    private const string MasterVolume = nameof(MasterVolume);
    private const string ButtonsVolume = nameof(ButtonsVolume);
    private const string MusicVolume = nameof(MusicVolume);

    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private Slider _masterSlider;
    [SerializeField] private Slider _buttonsSlider;
    [SerializeField] private Slider _musicSlider;

    public void SetMasterVolume()
    {
        float volume = _masterSlider.value;
        ChangeVolume(MasterVolume, volume);
    }

    public void SetButtonsVolume()
    {
        float volume = _buttonsSlider.value;
        ChangeVolume(ButtonsVolume, volume);
    }

    public void SetMusicVolume()
    {
        float volume = _musicSlider.value;
        ChangeVolume(MusicVolume, volume);
    }

    private void ChangeVolume(string nameSlider, float volume)
    {        
        _audioMixer.SetFloat(nameSlider, Mathf.Log10(volume) * 20);
    }
}