using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathExt
{
	public static float SinLim(float x, float max, float min)
	{
		return (Mathf.Sin(x)*(max - min) + (max + min))/2.0f;
	}  

	public static float CosLim(float x, float max, float min)
	{
		return (Mathf.Cos(x)*(max - min) + (max + min))/2.0f;
	}        
}
