using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour {

    public Transform player;
    public Texture compBg;
    public Texture blipTex;

    void OnGUI()
    {
        //x position, y position, 120,120(120 are for image)
        GUI.DrawTexture(new Rect(0, 300, 120, 120), compBg);
        GUI.DrawTexture(CreateBlip(), blipTex);
    }

    Rect CreateBlip()
    {
        float angDeg = player.eulerAngles.y - 90;
        float angRed = angDeg * Mathf.Deg2Rad;

        float blipX = 25 * Mathf.Cos(angRed);
        float blipY = 25 * Mathf.Sin(angRed);

        //positions for path x and y
        blipX += 55;
        blipY += 355;

        return new Rect(blipX, blipY, 10, 10);
    }
}
