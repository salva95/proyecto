﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject player;       
	public Vector2 minCamPos, maxCamPos;

    void Start () {

    }
	
    void FixedUpdate () {
		float posX = player.transform.position.x;
		float posY = player.transform.position.y;
        transform.position = new Vector3(
			Mathf.Clamp(posX+7.5f, minCamPos.x, maxCamPos.x), 
			Mathf.Clamp(posY, minCamPos.y, maxCamPos.y), 
			transform.position.z);
    }
}
