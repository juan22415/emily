using UnityEngine;
using System.Collections;

public class Ferlinshake : MonoBehaviour
{
    float duration=0.5f, speed=1, maginitud=0.1f;
    public bool test = false;


    public void playshake()
    {
        StopAllCoroutines();
        StartCoroutine("shake");

    }


    void update ()
    {
        if (!test)
        {
            playshake();
        }
    }

    IEnumerator Shake()
    {

        float elapsed = 0.0f;

        Vector3 originalCamPos = Camera.main.transform.position;

        while (elapsed < duration)
        {

            elapsed += Time.deltaTime;

            float percentComplete = elapsed / duration;
            float damper = 1.0f - Mathf.Clamp(4.0f * percentComplete - 3.0f, 0.0f, 1.0f);

            // map value to [-1, 1]
            float x = Random.value * 2.0f - 1.0f;
            float y = Random.value * 2.0f - 1.0f;
            x *= maginitud * damper;
            y *= maginitud * damper;

            Camera.main.transform.position += new Vector3(x, y, originalCamPos.z);

            yield return null;
        }

        Camera.main.transform.position = originalCamPos;
    }








}