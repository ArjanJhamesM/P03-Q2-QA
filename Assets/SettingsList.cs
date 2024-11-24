using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SettingsList : MonoBehaviour
{
    // Encapsulation (using protected set;)
    public string MotionBlurName { get; protected set; } = "Motion Blur "; 
    public bool MotionBlur { get; protected set; } = false; 
    public string MotionBlurKey { get; protected set; } = nameof(MotionBlur); 
    [SerializeField] protected TextMeshProUGUI MotionBlurDisplayText;

    public string BloomName { get; protected set;} = "Bloom";
    public bool Bloom { get; protected set; } = false;
    public string BloomKey {get; protected set;} = nameof(Bloom);
    [SerializeField] protected TextMeshProUGUI BloomDisplayText;
    
    public string DepthOfFieldName {get; protected set;} = "Depth of Field";
    public bool DepthOfField {get; protected set;} = false;
    public string DepthofFieldKey {get; protected set;} = nameof(DepthOfField);
    [SerializeField] protected TextMeshProUGUI DepthofFieldDisplayText;
    
    public string ShadersName { get; protected set;} = "Shaders";
    public bool Shaders { get; protected set; } = false;
    public string ShadersKey {get; protected set;} = nameof(Shaders);
    [SerializeField] protected TextMeshProUGUI ShadersDisplayText;

    public string WeatherEffectsName { get; protected set;} = "Weather Effect";
    public bool WeatherEffects { get; protected set; } = false;
    public string WeatherEffectsKey {get; protected set;} = nameof(WeatherEffects);
    [SerializeField] protected TextMeshProUGUI WeatherEffectsDisplayText;


    public string MoveForward { get; protected set; } = "W";
    public string MoveForwardName { get; protected set; } = "Move Forward";
    public string MoveForwardKey { get; protected set; } = nameof(MoveForward);
    [SerializeField] protected TextMeshProUGUI MoveForwardDisplayText;
    [SerializeField] protected TMP_InputField MoveForwardInputField;

    public string MoveBackward { get; protected set; } = "S";
    public string MoveBackwardName { get; protected set; } = "Move Backward";
    public string MoveBackwardKey { get; protected set; } = nameof(MoveBackward);
    [SerializeField] protected TextMeshProUGUI MoveBackwardDisplayText;
    [SerializeField] protected TMP_InputField MoveBackwardInputField;

    public string MoveRightward { get; protected set; } = "D";
    public string MoveRightwardName { get; protected set; } = "Move Rightward";
    public string MoveRightwardKey { get; protected set; } = nameof(MoveRightward);
    [SerializeField] protected TextMeshProUGUI MoveRightwardDisplayText;
    [SerializeField] protected TMP_InputField MoveRightwardInputField;

    public string MoveLeftward { get; protected set; } = "A";
    public string MoveLeftwardName { get; protected set; } = "Move Leftward";
    public string MoveLeftwardKey { get; protected set; } = nameof(MoveLeftward);
    [SerializeField] protected TextMeshProUGUI MoveLeftwardDisplayText;
    [SerializeField] protected TMP_InputField MoveLeftwardInputField;

    public string MoveUpward { get; protected set; } = "Spacebar";
    public string MoveUpwardName { get; protected set; } = "Move Upward";
    public string MoveUpwardKey { get; protected set; } = nameof(MoveUpward);
    [SerializeField] protected TextMeshProUGUI MoveUpwardDisplayText;
    [SerializeField] protected TMP_InputField MoveUpwardInputField;


    public string MasterVolumeName { get; protected set; } = "Master Volume"; 
    public int MasterVolume { get; protected set; } = 100; 
    public string MasterVolumeKey { get; protected set; } = nameof(MasterVolume); 
    [SerializeField] protected TextMeshProUGUI MasterVolumeDisplayText; 
    [SerializeField] protected TMP_InputField MasterVolumeInputField;
    
    public string MusicVolumeName { get; protected set; } = "Music Volume"; 
    public int MusicVolume { get; protected set; } = 100; 
    public string MusicVolumeKey { get; protected set; } = nameof(MusicVolume); 
    [SerializeField] protected TextMeshProUGUI MusicVolumeDisplayText; 
    [SerializeField] protected TMP_InputField MusicVolumeInputField;

    public string SoundFxVolumeName { get; protected set; } = "Sound Effects Volume"; 
    public int SoundFxVolume { get; protected set; } = 100; 
    public string SoundFxVolumeKey { get; protected set; } = nameof(SoundFxVolume); 
    [SerializeField] protected TextMeshProUGUI SoundFxVolumeDisplayText; 
    [SerializeField] protected TMP_InputField SoundFxVolumeInputField;

    public string DialogueVolumeName { get; protected set; } = "Dialogue Volume";
    public int DialogueVolume { get; protected set; } = 100;
    public string DialogueVolumeKey { get; protected set; } = nameof(DialogueVolume);
    [SerializeField] protected TextMeshProUGUI DialogueVolumeDisplayText;
    [SerializeField] protected TMP_InputField DialogueVolumeInputField;

    public string UIVolumeName { get; protected set; } = "User Interface Volume";
    public int UIVolume { get; protected set; } = 100;
    public string UIVolumeKey { get; protected set; } = nameof(UIVolume);
    [SerializeField] protected TextMeshProUGUI UIVolumeDisplayText;
    [SerializeField] protected TMP_InputField UIVolumeInputField;
}
