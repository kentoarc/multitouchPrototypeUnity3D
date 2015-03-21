using System;
using TouchScript.Gestures;
using UnityEngine;

public class clampObject : MonoBehaviour
{	
	void Update ()
	{
		if(gameObject.name == "RacketLeft"){
		var pos = gameObject.transform.localPosition;
		pos.x =  Mathf.Clamp(transform.localPosition.x, -20f, -20f);
		pos.y =  Mathf.Clamp(transform.localPosition.y, -12.5f, 12.5f);
		gameObject.transform.localPosition = pos;
		}
		else if(gameObject.name == "RacketRight"){
			var pos = gameObject.transform.localPosition;
			pos.x =  Mathf.Clamp(transform.localPosition.x, 20f, 20f);
			pos.y =  Mathf.Clamp(transform.localPosition.y, -12.5f, 12.5f);
			gameObject.transform.localPosition = pos;
		}
	}
}
