using System;
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
Yughues Free Ground Materials
https://assetstore.unity.com/packages/2d/textures-materials/floors/yughues-free-ground-materials-13001

Particle System - Julien Tonsuso(Unity Asset Store) / Moonflower Carnivore

Tank Texture-(Shader script)
https://www.dreamstime.com/stock-photo-texture-green-military-tank-s-side-details-close-up-image53502107


MODELS
Soldier - Megha Patel

Gun
https://www.turbosquid.com/FullPreview/Index.cfm/ID/704434

Bullets
https://www.turbosquid.com/FullPreview/Index.cfm/ID/746341

Houses
https://www.turbosquid.com/FullPreview/Index.cfm/ID/1163597

https://www.turbosquid.com/FullPreview/Index.cfm/ID/848227
Tank

https://www.turbosquid.com/FullPreview/Index.cfm/ID/624246
Bomb - Mario


FRAMEWORKS
VRTK - Virtual Reality Toolkit
https://assetstore.unity.com/packages/tools/vrtk-virtual-reality-toolkit-vr-toolkit-64131

Unity Standard Assets
https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-32351


SOUNDS
Light Years Away | Doug Maxwell<size>
https://www.youtube.com/audiolibrary/music


SCRIPTS
Mesh Terrain Editor Free
https://assetstore.unity.com/packages/tools/terrain/mesh-terrain-editor-free-67758

Compass
http://aarlangdi.blogspot.com.au/2015/11/creating-compass-in-unity-3d-1-video.html


SHADERS
Hologram Shader
https://github.com/andydbc/HologramShader
";

    // Use this for initialization
    void Start() {
        if (Math.Abs(View.width) < 0.00001) {
            this.View = new Rect(0.0f, 0.0f, Screen.width, Screen.height);
        }

        Style.richText = true;

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