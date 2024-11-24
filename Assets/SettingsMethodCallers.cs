using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMethodCallers : MonoBehaviour
{
    SettingsMethods settingsMethods = new SettingsMethods();
    void Start()
    {
        settingsMethods.AddToDictionaries();
        settingsMethods.UpdateAllSettings();
    }
}
