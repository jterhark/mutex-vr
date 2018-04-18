﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingCredits : MonoBehaviour {
    private float _offset;
    private float _height;
    public float Speed = 10.0f;
    public Rect View;
    public GUIStyle Style;

    private const string text = @"MUTEX GAME

Mario Betancourt
Michael Koutsostamatis
Jake TerHark


TEXTURES/MATERIALS
<size=25>Yughues Free Ground Materials</size>
<size=20>https://assetstore.unity.com/packages/2d/textures-materials/floors/yughues-free-ground-materials-13001</size>


MODELS
Soldier - Megha Patel


FRAMEWORKS
<size=25>VRTK - Virtual Reality Toolkit</size>
<size=20>https://assetstore.unity.com/packages/tools/vrtk-virtual-reality-toolkit-vr-toolkit-64131</size>

<size=25>Unity Standard Assets</size>
<size=20>https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-32351</size>


SOUNDS
<size=25>Light Years Away | Doug Maxwell<size>
<size=20>https://www.youtube.com/audiolibrary/music</size>



SCRIPTS
<size=25>Mesh Terrain Editor Free</size>
<size=20>https://assetstore.unity.com/packages/tools/terrain/mesh-terrain-editor-free-67758</size>


SHADERS
<size=25>Hologram Shader</size>
<size=20>https://github.com/andydbc/HologramShader</size>


";

    // Use this for initialization
    void Start() {
        if (Math.Abs(View.width) < 0.00001) {
            this.View = new Rect(0.0f, 0.0f, Screen.width - 100, Screen.height);
        }

        this._offset = this.View.height;
        _height = Style.CalcSize(new GUIContent(text)).y;
    }

    // Update is called once per frame
    void Update() {
        this._offset -= Time.deltaTime * this.Speed;

        if ((Math.Abs(this._height) - (Math.Abs(this._offset)) < 0)) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
        }
    }

    private void OnGUI() {
        GUI.BeginGroup(this.View);

        var position = new Rect(0, this._offset, this.View.width, this.View.height);


        GUI.Label(position, text, Style);
        GUI.EndGroup();
    }
}