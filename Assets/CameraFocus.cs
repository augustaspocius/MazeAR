using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;


public class CameraFocus : MonoBehaviour
{

    public Dropdown menu;

    void Start()
    {
        var vuforia = VuforiaARController.Instance;
        vuforia.RegisterVuforiaStartedCallback(OnVuforiaStarted);
        vuforia.RegisterOnPauseCallback(OnPaused);
        string[] modes = Enum.GetNames(typeof(CameraDevice.FocusMode));
        List<string> focusmodes = new List<string>(modes);
        menu.AddOptions(focusmodes);
    }

    private void OnVuforiaStarted()
    {
        CameraDevice.Instance.SetFocusMode(
            CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);
    }

    public void ChangeFocusMode(int index)
    {
        CameraDevice.FocusMode value = (CameraDevice.FocusMode)index;
        CameraDevice.Instance.SetFocusMode(
            value);

    }

    private void OnPaused(bool paused)
    {
        if (!paused) // resumed
        {
            // Set again autofocus mode when app is resumed
            CameraDevice.Instance.SetFocusMode(
                CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);
        }
    }
}
