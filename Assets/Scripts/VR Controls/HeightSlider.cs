using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.UnityEventHelper;

public class HeightSlider : MonoBehaviour {

	public Transform Map;
	public TextMesh Textmesh;

	private VRTK_Control_UnityEvents _events;
	
	void Start () {
		Textmesh.text = "Height (squeeze to slide)";
		_events = GetComponent<VRTK_Control_UnityEvents>();
		if (_events == null) {
			_events = gameObject.AddComponent<VRTK_Control_UnityEvents>();
		}
		_events.OnValueChanged.AddListener(SliderHandler);
	}

	private void SliderHandler(object sender, Control3DEventArgs args) {
		var value = args.value;
		Textmesh.text = "Height: " + args.normalizedValue.ToString() + "%";
		Map.position = new Vector3(Map.position.x, 1.0f + ((float) value)/50.0f, Map.position.z);
	}
}
