using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SettingsLogic : SettingsList // Inheritance
{
    // Polymorphism (by method overloading)
    public void LoadSettings( // DRY Principle is not the gospel as I learned the hard way
        string parameterSettingName,
        TextMeshProUGUI parameterSettingDisplayText,
        TextMeshProUGUI parameterSettingButtonText,
        bool parameterSettingValueBool)
    {
        parameterSettingDisplayText.text = parameterSettingName;
        parameterSettingButtonText.text = parameterSettingValueBool ? "ON" : "OFF";
    }

    public void LoadSettings(
        string parameterSettingName,
        TextMeshProUGUI parameterSettingDisplayText,
        TMP_InputField parameterInputField,
        string parameterSettingValueString)
    {
        parameterSettingDisplayText.text = parameterSettingName;
        parameterInputField.text = parameterSettingValueString;
        AddListenerToInputField(parameterSettingName, parameterInputField, listenerParameterSettingValueString: parameterSettingValueString);
    }

    public void LoadSettings(
        string parameterSettingName,
        TextMeshProUGUI parameterSettingDisplayText,
        TMP_InputField parameterInputField,
        int parameterSettingValueInt)
    {
        parameterSettingDisplayText.text = parameterSettingName;
        parameterInputField.text = Convert.ToString(parameterSettingValueInt);
        AddListenerToInputField(parameterSettingName, parameterInputField, listenerParameterSettingValueInt: parameterSettingValueInt);
    }

    public void ListenForInputFieldChanges(
        string parameterSettingName,
        TMP_InputField parameterInputField,
        string parameterSettingValueString = "",
        int parameterSettingValueInt = -999999999) // This is a crappy way to check if int parameter exists
    {
        if (!string.IsNullOrEmpty(parameterSettingValueString))
        {
            parameterSettingValueString = parameterInputField.text;
            Debug.Log(parameterSettingName + ": " + parameterSettingValueString);
        }
        else if (parameterSettingValueInt != -999999999)
        {
            parameterSettingValueInt = Convert.ToInt32(parameterInputField.text);
            if (parameterSettingValueInt > 100)
            {
                parameterSettingValueInt = 100;
                parameterInputField.text = Convert.ToString(100);
            }
            Debug.Log(parameterSettingName + ": " + parameterSettingValueInt);
        }

    }

    public void AddListenerToInputField(
        string parameterSettingName,
        TMP_InputField parameterInputField,
        string listenerParameterSettingValueString = "",
        int listenerParameterSettingValueInt = -9999999)
    {
        parameterInputField.onValueChanged.AddListener(delegate { ListenForInputFieldChanges(parameterSettingName, parameterInputField, listenerParameterSettingValueString, listenerParameterSettingValueInt); });
    }

    public void ToggleMotionBlurButton() // Too drained rn to create reusable methods ngl
    {
        _MotionBlur = !_MotionBlur;
        MotionBlurButtonText.text = _MotionBlur ? "ON" : "OFF";
        Debug.Log(_MotionBlurName + ": " + _MotionBlur);
    }

    public void ToggleBloomButton()
    {
        _Bloom = !_Bloom;
        BloomButtonText.text = _Bloom ? "ON" : "OFF";
        Debug.Log(_BloomName + ": " + _Bloom);
    }

    public void ToggleDepthOfFieldButton()
    {
        _DepthOfField = !_DepthOfField;
        DepthOfFieldButtonText.text = _DepthOfField ? "ON" : "OFF";
        Debug.Log(_DepthOfFieldName + ": " + _DepthOfField);
    }

    public void ToggleShadersButton()
    {
        _Shaders = !_Shaders;
        ShadersButtonText.text = _Shaders ? "ON" : "OFF";
        Debug.Log(_ShadersName + ": " + _Shaders);
    }

    public void ToggleWeatherEffectsButton()
    {
        _WeatherEffects = !_WeatherEffects;
        WeatherEffectsButtonText.text = _WeatherEffects ? "ON" : "OFF";
        Debug.Log(_WeatherEffectsName + ": " + _WeatherEffects);
    }
}