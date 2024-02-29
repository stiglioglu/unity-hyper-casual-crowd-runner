using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{

    [Header(" Elements ")]
    [SerializeField] private SoundsManager soundsManager;
    [SerializeField] private Sprite optionsOnSprite;
    [SerializeField] private Sprite optionsOffSprite;
    [SerializeField] private Image soundsButtonImage;
    [SerializeField] private Image hapticsButtonImage;

    [Header(" Settings ")]
    private bool soundsState = true;
    private bool hapticsState = true;

    private void Awake()
    {
        soundsState = PlayerPrefs.GetInt("sounds", 1) == 1;
        hapticsState = PlayerPrefs.GetInt("haptics", 1) == 1;
    }

    private void Start()
    {
        Setup();
    }

    private void Setup()
    {
        if (soundsState)
        {
            EnableSounds();
        }
        else
        {
            DisableSounds();
        }
    }

    public void ChangeSoundsState()
    {
        if (soundsState)
        {
            DisableSounds();
        }
        else
        {
            EnableSounds();
        }
        soundsState = !soundsState;

        
        PlayerPrefs.SetInt("sounds", soundsState ? 1 : 0);
    }

    private void DisableSounds()
    {

        soundsManager.DisableSounds();

        soundsButtonImage.sprite = optionsOffSprite;
    }

    private void EnableSounds()
    {
        soundsManager.EnableSounds();
        soundsButtonImage.sprite = optionsOnSprite;
    }

}
