using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

	public GameObject Player;
	private Vector3 offset;
	public float rotationValue = 0.8f; 

	// Use this for initialization
	void Start () {

		if (Player == null)
		{
			Debug.LogWarning("Please add the CameraArm");
		}
		else
		{
			offset = this.transform.position - Player.transform.position; 
		}
		
	}


	private void LateUpdate()
	{
		this.transform.position = Player.transform.position + offset;
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Player.transform.position), Time.time * rotationValue);
	}
}
