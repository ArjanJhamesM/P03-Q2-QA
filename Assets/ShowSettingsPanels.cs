using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSettingsPanels : MonoBehaviour
{
    public GameObject VideoPanel;
    public GameObject KeybindsPanel;
    public GameObject VolumePanel;

    public void ShowVideoPanel()
    {
        if (!VideoPanel.activeSelf)
        {
            VideoPanel.SetActive(true);
            KeybindsPanel.SetActive(false);
            VolumePanel.SetActive(false);
        }
    }

    public void ShowKeybindsPanel()
    {
        if (!KeybindsPanel.activeSelf)
        {
            VideoPanel.SetActive(false);
            KeybindsPanel.SetActive(true);
            VolumePanel.SetActive(false);
        }
    }

    public void ShowVolumePanel()
    {
        if (!VideoPanel.activeSelf)
        {
            VideoPanel.SetActive(false);
            KeybindsPanel.SetActive(false);
            VolumePanel.SetActive(true);
        }
    }
}
