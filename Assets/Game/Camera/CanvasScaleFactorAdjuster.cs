using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;
using UnityEngine.Experimental.Rendering.Universal;

public class CanvasScaleFactorAdjuster : MonoBehaviour
{
    [SerializeField] private PixelPerfectCamera _pixelPerfectCamera;

    private CanvasScaler _canvasScaler;

    void Start()
    {
        _canvasScaler = GetComponent<CanvasScaler>();
        Assert.IsNotNull(_canvasScaler);
        Assert.IsNotNull(_pixelPerfectCamera);
        AdjustScalingFactor();
    }

    void LateUpdate()
    {
        AdjustScalingFactor();
    }

    void AdjustScalingFactor()
    {
        _canvasScaler.scaleFactor = _pixelPerfectCamera.pixelRatio;
    }

}