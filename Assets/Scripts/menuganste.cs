using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuganste : MonoBehaviour {

    // Use this for initialization
    IEnumerator Tpfix()
    {
        
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(6);
        


    }


    void Start () {
        
        Tpfix();
       


    }

    // Update is called once per frame
    void Update () {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(6);
        }
    }
}
