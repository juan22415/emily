using UnityEngine;
using System.Collections;


public class shakecontroler : MonoBehaviour {

    private Animator anim;
    

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
        anim.SetBool("shake", false);

    }
	
	// Update is called once per frame
	void Update () {

     
    }
}
