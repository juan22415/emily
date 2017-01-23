using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class BarraOscuridad : MonoBehaviour {

    public Slider oscBar;
    private Animator anim;
    // Use this for initialization
    void Start () {
        oscBar.value = 100;
        anim = GetComponent<Animator>();
        anim.SetBool("shake", false);



    }
	
	// Update is called once per frame
	void Update () {
        oscBar.value -= Time.deltaTime*3;

        if (oscBar.value < 50)
        {
            anim.SetBool("shake", true);
        }

        if (oscBar.value < 25)
        {
            anim.SetBool("shakehard", true);
        }

        if (oscBar.value==0)
            {
            SceneManager.LoadScene(4);

        }

	}

    void Makeitshake()
    {
        anim.SetBool("shake", false);
        anim.SetBool("shakehard", false);
    }
    void OnTriggerEnter2D(Collider2D dmg)
    {

        if (dmg.gameObject.tag == "enemy")
        {
            oscBar.value -= 10;
        }
    }

    void OnTriggerStay2D(Collider2D dmg)

    {


        
        if (dmg.gameObject.tag == "Spot")
        {

            
            Makeitshake();
            oscBar.value = 100;
            
        }
    }
}
