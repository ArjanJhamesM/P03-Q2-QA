using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SettingsLogic : SettingsList // Inheritance
{
    public Dictionary<string, bool> DisplaySettings = new Dictionary<string, bool>
    {

    };

    public Dictionary<string, string> KeybindSettings = new Dictionary<string, string>
    {

    };

    public Dictionary<string, int> VolumeSettings = new Dictionary<string, int>
    {

    };

    

    protected void AddSettingToDictionary(
        string parameterSettingKey,
        bool parameterSettingValueBool = false,
        string parameterSettingValueString = "",
        int parameterSettingValueInt = -99999) // This is a crappy way to check for the int parameter
    {
        //DisplaySettings.Add(parameterSettingKey, parameterSettingValue);

        if ((parameterSettingValueBool) || (!parameterSettingValueBool) && (string.IsNullOrEmpty(parameterSettingValueString)) && (parameterSettingValueInt == -99999))
        {
            DisplaySettings.Add(parameterSettingKey, parameterSettingValueBool);
        }
        else if ((!string.IsNullOrEmpty(parameterSettingValueString)) && (parameterSettingValueInt == -99999))
        {
            KeybindSettings.Add(parameterSettingKey, parameterSettingValueString);
        }
        else if ((parameterSettingValueInt > -99999) && (string.IsNullOrEmpty(parameterSettingValueString)))
        {
            VolumeSettings.Add(parameterSettingKey, parameterSettingValueInt);
        }
    }

    public void ListenForInputFieldChanges(string parameterSettingKey, TMP_InputField parameterInputField, string parameterSettingValueString = "", bool parameterSettingValueBool = false)
    {
        parameterSettingValueString = parameterInputField.text;

        if (!string.IsNullOrEmpty(parameterSettingValueString))
        {
            Debug.Log(parameterSettingKey + ": " + parameterSettingValueString);
        }
        else { Debug.Log(parameterSettingKey + ": " + parameterSettingValueBool) ; }
        
    }

    public void AddListenerToInputField(string parameterSettingKey, TMP_InputField parameterInputField, string parameterSettingValueString = "", bool parameterSettingValueBool = false)
    {

        parameterInputField.onValueChanged.AddListener(delegate { ListenForInputFieldChanges(parameterSettingKey, parameterInputField, parameterSettingValueString, parameterSettingValueBool); });
    }

    protected void UpdateSettingsWithDictionary(
        string parameterSettingKey,
        string parameterSettingName,
        TextMeshProUGUI parameterSettingDisplayText,
        TMP_InputField parameterInputField = null,
        bool parameterSettingValueBool = false,
        string parameterSettingValueString = "",
        int parameterSettingValueInt = -99999)
    {

        if ((parameterSettingValueBool) ||
            (!parameterSettingValueBool) && 
            (string.IsNullOrEmpty(parameterSettingValueString)) && 
            (parameterSettingValueInt == -99999))
        {
            if ((DisplaySettings.ContainsKey(parameterSettingKey)) ||
                (KeybindSettings.ContainsKey(parameterSettingKey)) ||
                (VolumeSettings.ContainsKey(parameterSettingKey)))
            {
                parameterSettingValueBool = !parameterSettingValueBool;
                parameterSettingDisplayText.text = parameterSettingName;
                parameterInputField.text = parameterSettingValueBool ? "ON" : "OFF";                
            }
        }
        else if ((!string.IsNullOrEmpty(parameterSettingValueString)) && (parameterSettingValueInt == -99999))
        {
            if ((DisplaySettings.ContainsKey(parameterSettingKey)) ||
                (KeybindSettings.ContainsKey(parameterSettingKey)) ||
                (VolumeSettings.ContainsKey(parameterSettingKey)))
            {
                parameterSettingDisplayText.text = parameterSettingName;
                parameterInputField.text = parameterSettingValueString;
                AddListenerToInputField(parameterSettingKey, parameterInputField, parameterSettingValueString);
                //AddListenerToInputField(parameterSettingValueString, parameterInputField);
            }
        }
        else if ((parameterSettingValueInt > -99999) && (string.IsNullOrEmpty(parameterSettingValueString)))
        {
            if ((DisplaySettings.ContainsKey(parameterSettingKey)) || (KeybindSettings.ContainsKey(parameterSettingKey)) || (VolumeSettings.ContainsKey(parameterSettingKey)))
            {
                parameterSettingDisplayText.text = parameterSettingName;
                parameterInputField.text = Convert.ToString(parameterSettingValueInt);
                AddListenerToInputField(parameterSettingKey, parameterInputField, parameterSettingValueString);
            }
        }
    }
}

public class SettingsMethods : SettingsLogic
{
    public void AddToDictionaries()
    {
        AddSettingToDictionary(MotionBlurKey, parameterSettingValueBool: MotionBlur);
        AddSettingToDictionary(BloomKey, parameterSettingValueBool: Bloom);
        AddSettingToDictionary(DepthofFieldKey, parameterSettingValueBool: DepthOfField);
        AddSettingToDictionary(ShadersKey, parameterSettingValueBool: Shaders);
        AddSettingToDictionary(WeatherEffectsKey, parameterSettingValueBool: WeatherEffects);

        AddSettingToDictionary(MoveForwardKey, parameterSettingValueString: MoveForward);
        AddSettingToDictionary(MoveBackwardKey, parameterSettingValueString: MoveBackward);
        AddSettingToDictionary(MoveRightwardKey, parameterSettingValueString: MoveRightward);
        AddSettingToDictionary(MoveLeftwardKey, parameterSettingValueString: MoveLeftward);
        AddSettingToDictionary(MoveUpwardKey, parameterSettingValueString: MoveUpward);

        AddSettingToDictionary(MasterVolumeKey, parameterSettingValueInt: MasterVolume);
        AddSettingToDictionary(MusicVolumeKey, parameterSettingValueInt: MusicVolume);
        AddSettingToDictionary(SoundFxVolumeKey, parameterSettingValueInt: SoundFxVolume);
        AddSettingToDictionary(DialogueVolumeKey, parameterSettingValueInt: DialogueVolume);
        AddSettingToDictionary(UIVolumeKey, parameterSettingValueInt: UIVolume);
    }

    public void UpdateAllSettings()
    {
        UpdateSettingsWithDictionary(MotionBlurKey, MotionBlurName, MotionBlurDisplayText, parameterSettingValueBool: DisplaySettings[MotionBlurKey]);
        UpdateSettingsWithDictionary(BloomKey, BloomName, BloomDisplayText, parameterSettingValueBool: DisplaySettings[BloomKey]);
        UpdateSettingsWithDictionary(DepthofFieldKey, DepthOfFieldName, DepthofFieldDisplayText, parameterSettingValueBool: DisplaySettings[DepthofFieldKey]);
        UpdateSettingsWithDictionary(ShadersKey, ShadersName, ShadersDisplayText, parameterSettingValueBool: DisplaySettings[ShadersKey]);
        UpdateSettingsWithDictionary(WeatherEffectsKey, WeatherEffectsName, WeatherEffectsDisplayText, parameterSettingValueBool: DisplaySettings[WeatherEffectsKey]);

        UpdateSettingsWithDictionary(MoveForwardKey, MoveForwardName, MoveForwardDisplayText, parameterInputField: MoveForwardInputField, parameterSettingValueString: KeybindSettings[MoveForwardKey]);
        UpdateSettingsWithDictionary(MoveBackwardKey, MoveBackwardName, MoveBackwardDisplayText, parameterInputField: MoveBackwardInputField, parameterSettingValueString: KeybindSettings[MoveBackwardKey]);
        UpdateSettingsWithDictionary(MoveRightwardKey, MoveRightwardName, MoveRightwardDisplayText, parameterInputField: MoveRightwardInputField, parameterSettingValueString: KeybindSettings[MoveRightwardKey]);
        UpdateSettingsWithDictionary(MoveLeftwardKey, MoveLeftwardName, MoveLeftwardDisplayText, parameterInputField: MoveLeftwardInputField, parameterSettingValueString: KeybindSettings[MoveLeftwardKey]);
        UpdateSettingsWithDictionary(MoveUpwardKey, MoveUpwardName, MoveUpwardDisplayText, parameterInputField: MoveUpwardInputField, parameterSettingValueString: KeybindSettings[MoveUpwardKey]);

        UpdateSettingsWithDictionary(MasterVolumeKey, MasterVolumeName, MasterVolumeDisplayText, parameterInputField: MasterVolumeInputField, parameterSettingValueInt: VolumeSettings[MasterVolumeKey]);
        UpdateSettingsWithDictionary(MusicVolumeKey, MusicVolumeName, MusicVolumeDisplayText, parameterInputField: MusicVolumeInputField, parameterSettingValueInt: VolumeSettings[MusicVolumeKey]);
        UpdateSettingsWithDictionary(SoundFxVolumeKey, SoundFxVolumeName, SoundFxVolumeDisplayText, parameterInputField: SoundFxVolumeInputField, parameterSettingValueInt: VolumeSettings[SoundFxVolumeKey]);
        UpdateSettingsWithDictionary(DialogueVolumeKey, DialogueVolumeName, DialogueVolumeDisplayText, parameterInputField: DialogueVolumeInputField, parameterSettingValueInt: VolumeSettings[DialogueVolumeKey]);
        UpdateSettingsWithDictionary(UIVolumeKey, UIVolumeName, UIVolumeDisplayText, parameterInputField: UIVolumeInputField, parameterSettingValueInt: VolumeSettings[UIVolumeKey]);
    }
}