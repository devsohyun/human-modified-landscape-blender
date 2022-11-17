using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NdiManager : MonoBehaviour
{
    #region Variables

    [Header("Render Textures")]
    public RenderTexture rt_main_camera;
    public RenderTexture rt_main_texture;

    #endregion

    #region Standards

    void Update()
    {
        Graphics.CopyTexture(rt_main_camera, 0, 0, 0, 0, rt_main_camera.width, rt_main_camera.height, rt_main_texture, 0, 0, 0, 0);
    }

    #endregion
}
