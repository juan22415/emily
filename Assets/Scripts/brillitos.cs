using UnityEngine;
using System.Collections;

public class brillitos : MonoBehaviour {

    // Use this for initialization

    public Sprite bright;
    public Sprite dark;
    public SpriteRenderer sr;
    bool isbright = true;
    private int countcoll=1;


    IEnumerator Tpfix()
    {

        yield return new WaitForSeconds(0.1f);
        sr.sprite = dark;

    }


    void Start() {

        sr = GetComponent<SpriteRenderer>();
        sr.sprite = dark;

    }


    // Update is called once per frame
    void Update() {
        StartCoroutine(Tpfix());
        
        

        
    }

   


    void OnTriggerStay2D(Collider2D dmg)
    {
        StopAllCoroutines();
        if (dmg.gameObject.tag == "Spot")
        {
            sr.sprite = bright;

        }
        else 
            sr.sprite = bright;
        
        


    }

    
    


}
