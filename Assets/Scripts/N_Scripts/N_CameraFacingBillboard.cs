﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N_CameraFacingBillboard : MonoBehaviour {

	void Update ()
    {
        Camera cam = Camera.main;
        transform.LookAt(transform.position + cam.transform.rotation * Vector3.forward, cam.transform.rotation * Vector3.up);
	}
}