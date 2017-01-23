using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menusplash2 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(3);
        }
    }

    // A função OnClick() troca de cena
    // Lembrem que adicionamos as cenas que nosso jogo conterá em File->Build Settings
}
