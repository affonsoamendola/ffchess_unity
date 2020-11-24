using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

[RequireComponent(typeof(CanvasScaler))]
public class CanvasPixelPerfect : MonoBehaviour
{
	public PixelPerfectCamera ppCamera;
	CanvasScaler canvasScaler;
	
	void Awake()
    {
        canvasScaler = GetComponent<CanvasScaler>();
    }
	
	void Update()
    {
    	canvasScaler.scaleFactor = ppCamera.pixelRatio;
    }
}
