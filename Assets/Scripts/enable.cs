using UnityEngine;
using System.Collections;

public class enable : MonoBehaviour
{

    
    
    public GameObject spotlight;
    
    private bool checkradius = false;

    public float timer;
    // Use this for initialization
    void Start()
    {
        
        spotlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (checkradius)
        {
            timer += Time.deltaTime;
        }
       
        if (timer>2.5f)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D dmg)
    {
        if (dmg.gameObject.tag == "Player")
        {

            spotlight.SetActive(true);
            checkradius = true;



            



        }
    }

   

}