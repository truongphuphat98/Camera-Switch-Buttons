using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShowcase : MonoBehaviour
{
    [Header("Camera Modes")]
    public Camera[] cameraMode;

    [Header("GUI Properties")]
    public float moveX = 20f;
    public float moveY = 20f;
    public float lineSpaceY = 20f;
    public float expandSpaceY = 1.5f;
    public float width_gui = 138f;
    public float height_gui = 20f;


    void Start()
    {
        Camera.main.tag = "MainCamera";

        SetActiveCamera(0);
    }

    void OnGUI()
    {
        int i = 0;
        foreach (Camera c in cameraMode)
        {
            if (GUI.Button(new Rect(moveX, i * lineSpaceY * expandSpaceY + moveY, width_gui, height_gui), c.name))
            {
                SetActiveCamera(i);
            }
            i++;
        }
    }

    void SetActiveCamera(int i)
    {
        foreach (Camera c in cameraMode)
        {
            c.gameObject.tag = "MainCamera";
            c.gameObject.SetActive(false);
        }

        cameraMode[i].gameObject.tag = "MainCamera";
        cameraMode[i].gameObject.SetActive(true);
    }
}
