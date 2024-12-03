using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class SettingsList : MonoBehaviour
{
    SettingsLogic settingsLogic;

    // Encapsulation (using protected keyword)
    protected string _MotionBlurName = "Motion Blur";
    protected bool _MotionBlur = true;
    public TextMeshProUGUI MotionBlurDisplayText;
    public TextMeshProUGUI MotionBlurButtonText;
    
    protected string _BloomName = "Bloom";
    protected bool _Bloom = true;
    public TextMeshProUGUI BloomDisplayText;
    public TextMeshProUGUI BloomButtonText;

    protected string _DepthOfFieldName = "Depth of Field";
    protected bool _DepthOfField = true;
    public TextMeshProUGUI DepthOfFieldDisplayText;
    public TextMeshProUGUI DepthOfFieldButtonText;

    protected string _ShadersName = "Shaders";
    protected bool _Shaders = true;
    public TextMeshProUGUI ShadersDisplayText;
    public TextMeshProUGUI ShadersButtonText;

    protected string _WeatherEffectsName = "Weather Effects";
    protected bool _WeatherEffects = true;
    public TextMeshProUGUI WeatherEffectsDisplayText;
    public TextMeshProUGUI WeatherEffectsButtonText;


    protected string _MoveForward = "W";
    protected string _MoveForwardName = "Move Forward";
    public TextMeshProUGUI MoveForwardDisplayText;
    public TMP_InputField MoveForwardInputField;

    protected string _MoveBackward = "S";
    protected string _MoveBackwardName = "Move Backward";
    public TextMeshProUGUI MoveBackwardDisplayText;
    public TMP_InputField MoveBackwardInputField;

    protected string _MoveRightward = "D";
    protected string _MoveRightwardName = "Move Rightward";
    public TextMeshProUGUI MoveRightwardDisplayText;
    public TMP_InputField MoveRightwardInputField;

    protected string _MoveLeftward = "A";
    protected string _MoveLeftwardName = "Move Leftward";
    public TextMeshProUGUI MoveLeftwardDisplayText;
    public TMP_InputField MoveLeftwardInputField;

    protected string _MoveUpward = "Spacebar";
    protected string _MoveUpwardName = "Move Upward";
    public TextMeshProUGUI MoveUpwardDisplayText;
    public TMP_InputField MoveUpwardInputField;


    protected string _MasterVolumeName = "Master Volume";
    protected int _MasterVolume = 100;
    public TextMeshProUGUI MasterVolumeDisplayText;
    public TMP_InputField MasterVolumeInputField;

    protected string _MusicVolumeName = "Music Volume";
    protected int _MusicVolume = 100;
    public TextMeshProUGUI MusicVolumeDisplayText;
    public TMP_InputField MusicVolumeInputField;

    protected string _SoundFXVolumeName = "Sound Effects Volume";
    protected int _SoundFXVolume = 100;
    public TextMeshProUGUI SoundFXVolumeDisplayText;
    public TMP_InputField SoundFXVolumeInputField;

    protected string _DialogueVolumeName = "Dialogue Volume";
    protected int _DialogueVolume = 100;
    public TextMeshProUGUI DialogueVolumeDisplayText;
    public TMP_InputField DialogueVolumeInputField;

    protected string _UIVolumeName = "User Interface Volume";
    protected int _UIVolume = 100;
    public TextMeshProUGUI UIVolumeDisplayText;
    public TMP_InputField UIVolumeInputField;


    private void Start()
    {
        settingsLogic = new SettingsLogic();

        // this is a retarded way to shoehorn inheritance
        settingsLogic.LoadSettings(_MotionBlurName, MotionBlurDisplayText, parameterSettingButtonText: MotionBlurButtonText, parameterSettingValueBool: _MotionBlur);
        settingsLogic.LoadSettings(_BloomName, BloomDisplayText, parameterSettingButtonText: BloomButtonText, parameterSettingValueBool: _Bloom);
        settingsLogic.LoadSettings(_DepthOfFieldName, DepthOfFieldDisplayText, parameterSettingButtonText: DepthOfFieldButtonText, parameterSettingValueBool: _DepthOfField);
        settingsLogic.LoadSettings(_ShadersName, ShadersDisplayText, parameterSettingButtonText: ShadersButtonText, parameterSettingValueBool: _Shaders);
        settingsLogic.LoadSettings(_WeatherEffectsName, WeatherEffectsDisplayText, parameterSettingButtonText: WeatherEffectsButtonText, parameterSettingValueBool: _WeatherEffects);

        settingsLogic.LoadSettings(_MoveForwardName, MoveForwardDisplayText, MoveForwardInputField, parameterSettingValueString: _MoveForward);
        settingsLogic.LoadSettings(_MoveBackwardName, MoveBackwardDisplayText, MoveBackwardInputField, parameterSettingValueString: _MoveBackward);
        settingsLogic.LoadSettings(_MoveRightwardName, MoveRightwardDisplayText, MoveRightwardInputField, parameterSettingValueString: _MoveRightward);
        settingsLogic.LoadSettings(_MoveLeftwardName, MoveLeftwardDisplayText, MoveLeftwardInputField, parameterSettingValueString: _MoveLeftward);
        settingsLogic.LoadSettings(_MoveUpwardName, MoveUpwardDisplayText, MoveUpwardInputField, parameterSettingValueString: _MoveUpward);

        settingsLogic.LoadSettings(_MasterVolumeName, MasterVolumeDisplayText, MasterVolumeInputField, parameterSettingValueInt: _MasterVolume);
        settingsLogic.LoadSettings(_MusicVolumeName, MusicVolumeDisplayText, MusicVolumeInputField, parameterSettingValueInt: _MusicVolume);
        settingsLogic.LoadSettings(_SoundFXVolumeName, SoundFXVolumeDisplayText, SoundFXVolumeInputField, parameterSettingValueInt: _SoundFXVolume);
        settingsLogic.LoadSettings(_DialogueVolumeName, DialogueVolumeDisplayText, DialogueVolumeInputField, parameterSettingValueInt: _DialogueVolume);
        settingsLogic.LoadSettings(_UIVolumeName, UIVolumeDisplayText, UIVolumeInputField, parameterSettingValueInt: _UIVolume);
    }

}