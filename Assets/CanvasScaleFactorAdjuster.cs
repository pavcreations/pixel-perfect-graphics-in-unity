using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class CanvasScaleFactorAdjuster : MonoBehaviour
{
    public Camera MainCamera;

    void Start()
    {
        AdjustScalingFactor();
    }

    void LateUpdate()
    {
        AdjustScalingFactor();
    }

    void AdjustScalingFactor()
    {
        GetComponent<CanvasScaler>().scaleFactor = MainCamera.GetComponent<PixelPerfectCamera>().pixelRatio;
    }

}
