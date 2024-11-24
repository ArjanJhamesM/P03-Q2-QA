using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SettingsMethods : SettingsList
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

    

    public void AddSettingToDictionary(
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

    public void ListenForInputFieldChanges(string parameterSettingKey, string parameterSettingValueString, TMP_InputField parameterInputField)
    //public void ListenForInputFieldChanges(string parameterSettingValueString)
    {
        parameterSettingValueString = parameterInputField.text;

        Debug.Log(parameterSettingKey + ": " + parameterSettingValueString);
    }

    public void AddListenerToInputField(string parameterSettingKey, string parameterSettingValueString, TMP_InputField parameterInputField)
    //public void AddListenerToInputField(string parameterSettingValueString, TMP_InputField parameterInputField)
    {

        parameterInputField.onValueChanged.AddListener(delegate { ListenForInputFieldChanges(parameterSettingKey, parameterSettingValueString, parameterInputField); });
        //parameterInputField.onValueChanged.AddListener((parameterSettingValueString) => { ListenForInputFieldChanges(parameterSettingValueString); } );
    }

    public void UpdateSettingsWithDictionary(
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
                parameterSettingDisplayText.text = parameterSettingValueBool ? "ON" : "OFF";                
            }
        }
        else if ((!string.IsNullOrEmpty(parameterSettingValueString)) && (parameterSettingValueInt == -99999))
        {
            if ((DisplaySettings.ContainsKey(parameterSettingKey)) ||
                (KeybindSettings.ContainsKey(parameterSettingKey)) ||
                (VolumeSettings.ContainsKey(parameterSettingKey)))
            {
                parameterInputField.text = parameterSettingValueString;
                AddListenerToInputField(parameterSettingKey, parameterSettingValueString, parameterInputField);
                //AddListenerToInputField(parameterSettingValueString, parameterInputField);
            }
        }
        else if ((parameterSettingValueInt > -99999) && (string.IsNullOrEmpty(parameterSettingValueString)))
        {
            if ((DisplaySettings.ContainsKey(parameterSettingKey)) || (KeybindSettings.ContainsKey(parameterSettingKey)) || (VolumeSettings.ContainsKey(parameterSettingKey)))
            {
                parameterInputField.text = Convert.ToString(parameterSettingValueInt);
                AddListenerToInputField(parameterSettingKey, parameterSettingValueString, parameterInputField);
                //AddListenerToInputField(parameterSettingValueString, parameterInputField);
            }
        }
    }
}