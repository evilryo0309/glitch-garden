using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public LevelManager LevelManager;
    public Slider VolumeSlider;
    public Slider DifficultySlider;

    MusicManager musicManager;

    private void Start()
    {
        musicManager = FindObjectOfType<MusicManager>();
        VolumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        DifficultySlider.value = PlayerPrefsManager.GetDifficulty();
    }

    private void Update()
    {
        musicManager.SetVolume(VolumeSlider.value);
    }

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(VolumeSlider.value);
        PlayerPrefsManager.SetDifficulty(DifficultySlider.value);
        LevelManager.LoadLevel("01a Start");
    }

    public void SetDefaults()
    {
        VolumeSlider.value = 0.8f;
        DifficultySlider.value = 2;
    }
}
