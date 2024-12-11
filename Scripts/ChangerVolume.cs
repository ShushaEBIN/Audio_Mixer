using UnityEngine;
using UnityEngine.Audio;

public class ChangerVolume : MonoBehaviour
{
    private const string MasterVolume = nameof(MasterVolume);
    private const string ButtonsVolume = nameof(ButtonsVolume);
    private const string MusicVolume = nameof(MusicVolume);

    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private VolumeSlider _masterSlider;
    [SerializeField] private VolumeSlider _buttonsSlider;
    [SerializeField] private VolumeSlider _musicSlider;

    private void Start()
    {
        _masterSlider.SetName(MasterVolume);
        _buttonsSlider.SetName(ButtonsVolume);
        _musicSlider.SetName(MusicVolume);
    }
}