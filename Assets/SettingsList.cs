using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum OptionButton
{
    enumTestOne,
    enumTestTwo
}

public class SettingsList : MonoBehaviour
{
    //SettingsMethods settingsMethods = new SettingsMethods();

    public bool testSetting = true;
    public string testSettingKey = nameof(testSetting);

    public Dictionary<string, bool> settings = new Dictionary<string, bool>
    {

    };

    public void AddSettingToDictionary(string parameterSettingsBoolKey, bool parameterSettingsBoolValue)
    {
        settings.Add(parameterSettingsBoolKey, parameterSettingsBoolValue);
    }

    public void OptionMethod(string parameterSettingKey)//, bool parameterSettingValue)
    {

        // placeholderOption = !placeholderOption
        // placeholderTextMeshProUGUI.text = placeholderOption ? "ON" : "OFF";
        // Debug.Log(placeholderOption);

        if (settings.ContainsKey(parameterSettingKey))
        {

            print("if loop Running");
        }
        else
        {
            print("if loop not Running");
            
        }
    }

    public void testMethod(OptionButton optionButton)
    {
        switch (optionButton)
        {
            case OptionButton.enumTestOne:

                OptionMethod(testSettingKey);

                //settingsMethods.OptionMethod(settingsList.testSettingKey, settingsList.testSetting);



                print("OptionButton.enumTestOne Running");
                //print(settingsList.testSettingKey);
                break;
        }
    }

    private void Start()
    {
        AddSettingToDictionary(testSettingKey, testSetting);

        testMethod(OptionButton.enumTestOne);

        /*foreach (KeyValuePair<string, bool> kvp in settings)
        {
            print($"Key: {kvp.Key}, Value: {kvp.Value}");
        }*/
    }
}