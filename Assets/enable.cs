using UnityEngine;
using System.Collections;

public class enable : MonoBehaviour
{

    
    public GameObject spotlight;
    // Use this for initialization
    void Start()
    {
        spotlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {



    }

    void OnTriggerEnter2D(Collider2D dmg)
    {
        if (dmg.gameObject.tag == "Player")
        {

            spotlight.SetActive(true);
            

        }
    }

}