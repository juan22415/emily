using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pickup : MonoBehaviour
{

    
    public int pickedup=0;
    public AudioClip tp;
    public AudioClip cp;
    public AudioSource source;
    public GameObject puerta;
    

    public RawImage alma;
    public RawImage corazon;
    public RawImage retrato;
    public RawImage oso;
    public RawImage flor;

    // Use this for initialization
    void Start()
    {
       source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pickedup==5)
        {
            Destroy(puerta);
        }
    }



    
    void OnTriggerEnter2D(Collider2D dmg)
    {

        if (dmg.gameObject.tag == "ganar")


        {
            SceneManager.LoadScene(5);
        }

            if (dmg.gameObject.tag == "Spot")
        {


            source.PlayOneShot(cp);

        }


    

    
        if (dmg.gameObject.tag == "alma")
        {
            Destroy(dmg.gameObject);

            pickedup++;

            alma.enabled = false;

            source.PlayOneShot(tp);





        }

        if (dmg.gameObject.tag == "corazon")
        {
            Destroy(dmg.gameObject);

            pickedup++;

            corazon.enabled = false;
            source.PlayOneShot(tp);


        }
        if (dmg.gameObject.tag == "oso")
        {
            Destroy(dmg.gameObject);

            pickedup++;

            oso.enabled = false;

            source.PlayOneShot(tp);

        }
        if (dmg.gameObject.tag == "retrato")
        {
            Destroy(dmg.gameObject);

            pickedup++;

            retrato.enabled = false;
            source.PlayOneShot(tp);


        }
        if (dmg.gameObject.tag == "flor")
        {
            Destroy(dmg.gameObject);

            pickedup++;

            flor.enabled = false;
            source.PlayOneShot(tp);


        }



    }


}
    
