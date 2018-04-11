using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using VRTK;
using VRTK.UnityEventHelper;

public class ServerInputButton : MonoBehaviour {
    private VRTK_Button_UnityEvents _events;


    void Start() {
        _events = GetComponent<VRTK_Button_UnityEvents>();
        if (_events == null) {
            _events = gameObject.AddComponent<VRTK_Button_UnityEvents>();
        }

        _events.OnPushed.AddListener(BtnPushed);
    }

    private void BtnPushed(object sender, Control3DEventArgs args) {
        Debug.Log("Button Pushed");
        SteamVR.instance.overlay.ShowKeyboard(0, 0, "Description", 256, "", true, 0);
    }
}