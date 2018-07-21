using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCursor : MonoBehaviour
{

	public CameraRaycaster cr; 

	// Use this for initialization
	void Start () {

		if (cr == null)
		{
			Debug.Log("Please asign the CameraRaycaster-Object to Cursor.cs");
		}
	}
	
	// Update is called once per frame
	void Update () {

			//Debug.Log("LayerHit is: " + cr.layerHit);
	}
}
