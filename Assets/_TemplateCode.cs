using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TemplateCode : MonoBehaviour
{
    // Template for VIDEO SETTINGS (Motion Blur, Bloom, Depth of Field, etc.)
    /*  ===================================================================================================
     *  Everything enclosed in the two upper and bottom comment lines is for one setting.
     *  Copy and paste them depending which setting it is categorized (Categories: VIDEO, KEYBINDS, VOLUME)
     *
     *  Replace every "ONOFFSETTING" CAPITAL names with Title Case option name
     *  e.g: public string ONOFFSETTINGName ... -> public string MotionBlurName
     *       public bool ONOFFSETTING ... -> public bool MotionBlur
     *  ===================================================================================================
    */
    public string ONOFFSETTINGName { get; protected set; } = "On/Off Template Setting"; // Replace "On/Off Template Setting" string with setting name (e.g "Motion Blur")
    public bool ONOFFSETTING { get; protected set; } = false; // It's fine to keep false as is. Change to true if you want.
    public string ONOFFSETTINGKey { get; protected set; } = nameof(ONOFFSETTING); // Don't forget to change the capital letters
    [SerializeField] protected TextMeshProUGUI ONOFFSETTINGDisplayText; // Don't forget to change the capital letters
    // End of VIDEO SETTINGS template


    // Template for KEYBIND SETTINGS
    public string KEYBINDSETTINGName { get; protected set; } = "Keybind Template Setting"; // Replace string
    public string KEYBINDSETTING { get; protected set; } = "W"; // Replace keybind setting with one letter (e.g "A"), or "SPACE" for jump keybind
    public string KEYBINDSETTINGKey { get; protected set; } = nameof(KEYBINDSETTING); // Change
    [SerializeField] protected TextMeshProUGUI KEYBINDSETTINGDisplayText; // Change
    [SerializeField] protected TMP_InputField KEYBINDSETTINGInputField; // Change
    // End of KEYBIND SETTINGS template


    // Template for VOLUME SETTINGS
    public string VOLUMESETTINGName { get; protected set; } = "Volume Template Setting"; // Replace string
    public int VOLUMESETTING { get; protected set; } = 100; // It's fine to keep 100 as is. Change to any number from 0-100 if you want.
    public string VOLUMESETTINGKey { get; protected set; } = nameof(VOLUMESETTING); // Change
    [SerializeField] protected TextMeshProUGUI VOLUMESETTINGDisplayText; // Change
    [SerializeField] protected TMP_InputField VOLUMESETTINGInputField; // Change
    // End of VOLUME SETTINGS template

    void Start()
    {
        /*  ================================================================================================================
         *  For each setting you added, copy paste one of the methods below depending on which category it belongs.
         *  (Keep the // as is)
         *  
         *  If the setting you added is under the VIDEO SETTINGS category, copy paste the first method.
         *  If under the KEYBINDS category, second method.
         *  If under the VOLUME category, third method.
         *  
         *  The order of the variables in the method parameters is:
         *  1) Variable with the word "Key", 2) Variable without any words after "ONOFFSETTING/KEYBINDSETTING/VOLUMESETTING"
         *  
         *  Replace the variables in the method with the corresponding variables above.
         *  ================================================================================================================
         */

        // AddSettingToDictionary(ONOFFSETTINGKey, parameterSettingValueBool: ONOFFSETTING); // First method: VIDEO
        // AddSettingToDictionary(KEYBINDSETTINGKey, parameterSettingValueString: KEYBINDSETTING); // Second method: KEYBINDS
        // AddSettingToDictionary(VOLUMESETTINGKey, parameterSettingValueInt: VOLUMESETTING); // Third method: VOLUME

        /* =======================================================================================================================
         * Also copy paste one of the methods below depending on which category it belongs.
         * (Keep the // as is)
         * 
         * If under the VIDEO category, first method.
         * If under the KEYBINDS category, second method.
         * If under the VOLUME category, third method.
         * 
         * Order of variables:
         * 1) Variable with "Key" word, 2) Variable with "DisplayText", 3) Variable with "InputField", 4) Variable with "Key" word
         * 
         * Replace the variables in the method with the corresponding variables above.
         * =======================================================================================================================
         */

        // UpdateSettingsWithDictionary(ONOFFSETTINGKey, ONOFFSETTINGDisplayText, parameterInputField: ONOFFSETTINGInputField, parameterSettingValueString: KeybindSettings[ONOFFSETTINGKey]);
        // UpdateSettingsWithDictionary(KEYBINDSETTINGKey, KEYBINDSETTINGDisplayText, parameterInputField: KEYBINDSETTINGInputField, parameterSettingValueString: KeybindSettings[KEYBINDSETTINGKey]);
        // UpdateSettingsWithDictionary(VOLUMESETTINGKey, VOLUMESETTINGDisplayText, parameterInputField: VOLUMESETTINGInputField, parameterSettingValueInt: KeybindSettings[VOLUMESETTINGKey]);

    }
}
