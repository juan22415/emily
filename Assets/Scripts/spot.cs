﻿using UnityEngine;
using System.Collections;

public class spot : MonoBehaviour {

    public bool turnoff = true;
    

    public CircleCollider2D sopted;
    public float radius;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        radius = sopted.radius;
	}

    void OnTriggerStay2D(Collider2D dmg)
    {
        if (dmg.gameObject.tag == "Player")

            
        if (turnoff == true)
            { 
            sopted.radius +=0.08f;
            if (sopted.radius > 6)
                {
                    turnoff = false;
                }
            }

        if (turnoff==false)
        {
            sopted.radius -= 0.005f;
            

            
        }

        if (sopted.radius <1 && turnoff==false)
        {
           // Destroy(gameObject);



        }


    }


}
