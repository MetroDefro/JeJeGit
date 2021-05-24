using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{

    public Image fade;
    bool isFade;
    float fades = 0f;
    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        isFade = false;
    }

    // Update is called once per frame
    void Update()
    {


    }

    /*
    IEnumerator MoveText()
    {
        moving = true;
        for(int i = 20; i < 26; i++)
        {
            yield return new WaitForSeconds(0.1f);
            moveT.fontSize = i;
        }
        for (int i = 26; i >= 20; i--)
        {
            yield return new WaitForSeconds(0.1f);
            moveT.fontSize = i;
        }
        moving = false;
    }
    */

    void GoFade()
    {
        if (!isFade)
            return;

        time += Time.deltaTime;
        if (fades < 1.0f && time >= 0.1f)
        {
            fades += 0.1f;
            fade.color = new Color(1, 1, 1, fades);
            time = 0;
        }
        else if (fades >= 1.0f)
        {
            SceneManager.LoadScene("Intro");
        }
    }

}
