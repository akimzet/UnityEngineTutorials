using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start ()
	{
		//Gets the difference from the camera position and the player position
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Camera's position is now the players position + the difference we calculated
		transform.position = player.transform.position + offset;
	}
}
