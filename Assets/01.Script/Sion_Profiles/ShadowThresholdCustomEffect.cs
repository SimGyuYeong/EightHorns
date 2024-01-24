using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Rendering;
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class ShadowThresholdCustomEffect : MonoBehaviour
{
    public Material shadowMaterial;
    [Range(0f, 1f)]
    public float shadowThreshold;
    //public Color shadowColor;
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        shadowMaterial.SetFloat("_MyFloat", shadowThreshold);
        //shadowMaterial.SetColor("_ShadowColor", shadowColor);
        Graphics.Blit(source, destination,shadowMaterial);
    }
}
