using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {


    public GameObject bengal;
    public Transform thistransform;



    // Use this for initialization
    void Start () {

        thistransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) { 
            GameObject bullet = Instantiate(bengal);
        bullet.transform.position = thistransform.position;
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);

            

        }
    }
}
