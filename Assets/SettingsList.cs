using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsList : MonoBehaviour
{
    public string MotionBlurName { get; protected set; } = "Motion Blur "; 
    public bool MotionBlur { get; protected set; } = false; 
    public string MotionBlurKey { get; protected set; } = nameof(MotionBlur); 
    [SerializeField] protected TextMeshProUGUI MotionBlurDisplayText;

    public string BloomName { get; protected set;} = "Bloom";
    public bool Bloom { get; protected set; } = false;
    public string BloomKey {get; protected set;} = nameof(Bloom);
    [SerializeField] protected TextMeshProUGUI BloomDisplayText;
    
    public string DepthOfFieldName {get; protected set;} = "Depth of Field";
    public bool DepthofFied {get; protected set;} = false;
    public string DepthofFieldKey {get; protected set;} = nameof(DepthofField);
    [SerializeField] protected TextMeshProUGUI DepthofFieldDisplayText;
    
    public string ShadersName { get; protected set;} = "Shaders";
    public bool Shaders { get; protected set; } = false;
    public string ShadersKey {get; protected set;} = nameof(Shaders);
    [SerializeField] protected TextMeshProUGUI ShadersDisplayText;

    public string WeatherEffectsName { get; protected set;} = "Weather Effect";
    public bool WeatherEffects { get; protected set; } = false;
    public string WeatherEffectsKey {get; protected set;} = nameof(WeatherEffects);
    [SerializeField] protected TextMeshProUGUI WeatherEffectsDisplayText;

     public string MasterVolumeName { get; protected set; } = "Master Volume"; 
    public int MasterVolume { get; protected set; } = 100; 
    public string MasterVolumeKey { get; protected set; } = nameof(MasterVolume); 
    [SerializeField] protected TextMeshProUGUI MasterVolumeDisplayText; 
    [SerializeField] protected TMP_InputField MasterVolumeInputField;
    
    public string MusicVolumeName { get; protected set; } = "Music Volume"; 
    public int MusicVolume { get; protected set; } = 100; 
    public string MasterVolumeKey { get; protected set; } = nameof(MusicVolume); 
    [SerializeField] protected TextMeshProUGUI MusicVolumeDisplayText; 
    [SerializeField] protected TMP_InputField MusicVolumeInputField;

    public string SoundFxName { get; protected set; } = "Sound Effects Volume"; 
    public int SoundFxVolume { get; protected set; } = 100; 
    public string SoundFxVolumeKey { get; protected set; } = nameof(SoundFxVolume); 
    [SerializeField] protected TextMeshProUGUI SoundFxVolumeDisplayText; 
    [SerializeField] protected TMP_InputField SoundFxVolumeInputField;

    void start()
    {
         // AddSettingToDictionary(MotionBlurKey, parameterSettingValueBool: MotionBlur); 
         // AddSettingToDictionary(BloomKey, parameterSettingValueBool: Bloom); 
         // AddSettingToDictionary(DepthofFieldKey, parameterSettingValueBool: DepthofField); 
         // AddSettingToDictionary(ShadersKey, parameterSettingValueBool: Shaders); 
         // AddSettingToDictionary(WeatherEffectKey, parameterSettingValueBool: WeatherEffect); 

         // AddSettingToDictionary(MasterVolumeKey, parameterSettingValueInt: MasterVolume); 
         // AddSettingToDictionary(MusicVolumeKey, parameterSettingValueInt: MusicVolume); 
         // AddSettingToDictionary(SoundFxVolumeKey, parameterSettingValueInt: SoundFxVolume); 

         // UpdateSettingsWithDictionary(MotionBlurKey, MotionBlurDisplayText, parameterInputField: MotionBlurInputField, parameterSettingValueString: DisplaySettings[MotionBlurKey]);
         // UpdateSettingsWithDictionary(BloomKey, BloomDisplayText, parameterInputField: BloomInputField, parameterSettingValueString: DisplaySettings[BloomKey]);
         // UpdateSettingsWithDictionary(DepthofFieldKey, DepthofFieldDisplayText, parameterInputField: DepthofFieldInputField, parameterSettingValueString: DisplaySettings[DepthofFieldKey]);
         // UpdateSettingsWithDictionary(ShadersKey, ShadersDisplayText, parameterInputField: ShadersInputField, parameterSettingValueString: DisplaySettings[ShadersKey]);
         // UpdateSettingsWithDictionary(WeatherEffectKey, WeatherEffectDisplayText, parameterInputField:WeatherEffectInputField, parameterSettingValueString: DisplaySettings[WeatherEffectKey]);

         // UpdateSettingsWithDictionary(MasterVolumeKey, MasterVolumeDisplayText, parameterInputField: MasterVolumeField, parameterSettingValueInt: VolumeSettings[MasterVolumeKey]);
         // UpdateSettingsWithDictionary(MusicVolumeKey, MusicVolumeDisplayText, parameterInputField: MusicVolumeInputField, parameterSettingValueInt: VolumeSettings[MusicVolumeKey]);
         // UpdateSettingsWithDictionary(SoundFxVolumeKey, SoundFxVolumeDisplayText, parameterInputField: SoundFxVolumeInputField, parameterSettingValueInt: VolumeSettings[SoundFxVolumeKey]);


    }



}
