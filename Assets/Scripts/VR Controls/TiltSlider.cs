using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.UnityEventHelper;

public class TiltSlider : MonoBehaviour {
    public Transform Map;
    public TextMesh Textmesh;

    private VRTK_Control_UnityEvents _events;


    private void Start() {
        Textmesh.text = "Tilt (squeeze to slide)";
        _events = GetComponent<VRTK_Control_UnityEvents>();

        if (_events == null) {
            _events = gameObject.AddComponent<VRTK_Control_UnityEvents>();
        }
        _events.OnValueChanged.AddListener(SliderHandler);
    }

    private void SliderHandler(object sender, Control3DEventArgs args) {
        var value = args.value;
        Textmesh.text = "Tilt: " + args.normalizedValue.ToString() + "%";
        Map.rotation = Quaternion.Euler(Map.rotation.x, Map.rotation.y, Map.rotation.z + ((float) value));
    }
}