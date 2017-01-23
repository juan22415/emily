using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour {

    private Rigidbody2D main_rigidbody;
    public Animator anim;

    public float speed;
    

    public bool facingright = true; 
    // Use this for initialization
    void Start () {

        main_rigidbody = GetComponent<Rigidbody2D>();
       


    }


	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        float h = CrossPlatformInputManager.GetAxis("Horizontal");
        float v = CrossPlatformInputManager.GetAxis("Vertical");

        transform.Translate(transform.up * speed * v);
       // transform.Translate(transform.right * speed * h);

        if(main_rigidbody.velocity==new Vector2(0,0))

        {
            anim.SetBool("ismoving", false);
        }

        else
        {
            anim.SetBool("ismoving", true);
            
        }

        if (facingright)
        {
            main_rigidbody.velocity = new Vector2(h * 4, v);
        }

        else
        {

            main_rigidbody.velocity = new Vector2(h * 4, v);
        }

        if (h>0 && !facingright)
        {
            flip();
           
        }
        else if (h<0 && facingright)
        {
            flip();
        }
    }


    void flip ()
    {
        facingright = !facingright;
        Vector3 myscale = transform.localScale;
        myscale.x *= -1;
        transform.localScale = myscale;
    }
}


