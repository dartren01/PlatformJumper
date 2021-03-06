﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {

    public float speed = 5f;
    public GameObject gamemanager;

    private BoxCollider box;

    public Material material;
    private Renderer rend;

    private void Awake()
    {
        this.enabled = false;
        box = GetComponent<BoxCollider>();
        rend = GetComponent<MeshRenderer>();
    }

    private void OnEnable()
    {
        rend.sharedMaterial = material;
        box.isTrigger = true;
    }

    // Update is called once per frame
    void Update ()
    {
        transform.position = new Vector3(0, transform.position.y + (Time.deltaTime * speed), 0);
	}

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "player")
        {
            //animation maybe?
            gamemanager.GetComponent<SceneManagerScript>().GameOver();
        }
        if(collider.gameObject.tag == "Platform" || collider.gameObject.tag == "SetPlatforms" || collider.gameObject.tag == "PowerUp" || collider.gameObject.tag == "Enemy")
        {
            collider.gameObject.SetActive(false);
        }
    }

    public void addSpeed(float s)
    {
        speed += s;
    }

    public float getSpeed()
    {
        return speed;
    }

    public void subtractSpeed(float s)
    {
        speed -= s;
    }
}
