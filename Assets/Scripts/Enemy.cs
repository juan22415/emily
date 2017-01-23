using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public Transform  Player;
    float MoveSpeed = 0.3f;
   int MaxDist = 10;
   int MinDist = 0;
   public bool facingright = true;

    IEnumerator Tpfix()
    {

        yield return new WaitForSeconds(4);
        MoveSpeed = 0.3f;


    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        StartCoroutine(Tpfix());
        //  transform.LookAt(Player);

        if (Vector2.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += (Player.transform.position-transform.position) * MoveSpeed * Time.deltaTime;



            //if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            // {
            //Here Call any function U want Like Shoot at here or something
            // }
        }

        if (Player.transform.position.x >transform.position.x && !facingright)

        {
            flip();
        }

        if (Player.transform.position.x < transform.position.x && facingright)

        {
            flip();
        }
    }

    void OnTriggerStay2D(Collider2D dmg)
    {
        if (dmg.gameObject.tag == "Spot")
        {
            StopAllCoroutines();


            MoveSpeed = 0;
        }
    }

    void OnTriggerExit2D(Collider2D dmg)
    {
         MoveSpeed = 0.5f;
    }

    void flip()
    {
        facingright = !facingright;
        Vector3 myscale = transform.localScale;
        myscale.x *= -1;
        transform.localScale = myscale;
    }

}
