using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{  
    public Image fade;
    bool isFadeOut;
    bool isFadeIn;
    bool isFirst;
    float fades = 1f;
    float time = 0;

    public GameObject[] intro;

    int introNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        isFadeOut = false;
        isFadeIn = true;
        isFirst = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFirst)
        {

        }
        GoFadeIn();
        if (!isFadeOut && !isFadeIn) {
            if (Input.anyKeyDown) {
                isFadeOut = true;
            }
        }
        GoFadeOut();
    }

    void GoFadeOut()
    {
        if (!isFadeOut)
            return;

        time += Time.deltaTime;
        if (fades < 1.0f && time >= 0.1f)
        {
            fades += 0.05f;
            fade.color = new Color(0, 0, 0, fades);
            time = 0;
        }
        else if (fades >= 1.0f)
        {
            switch (introNum)
            {
                case 0:
                    intro[0].SetActive(false);
                    intro[1].SetActive(true);
                    introNum = 1;
                    break;
                case 1:
                    intro[1].SetActive(false);
                    intro[2].SetActive(true);
                    introNum = 2;
                    break;
                case 2:
                    intro[2].SetActive(false);
                    intro[3].SetActive(true);
                    introNum = 3;
                    break;
                case 3:
                    SceneManager.LoadScene("Stage1");
                    break;
                default:
                    break;
            }
            GoFadeIn();
            isFadeIn = true;
            isFadeOut = false;
        }
    }

    void GoFadeIn()
    {
        if (!isFadeIn)
            return;

        time += Time.deltaTime;
        if (fades > 0.0f && time >= 0.1f)
        {
            fades -= 0.05f;
            fade.color = new Color(0, 0, 0, fades);
            time = 0;
        }
        else if (fades <= 0f)
        {
            isFadeIn = false;
        }
    }

    void FirstGoFadeIn()
    {
        if (!isFadeIn)
            return;

        time += Time.deltaTime;
        if (fades > 0.0f && time >= 0.1f)
        {
            fades -= 0.05f;
            fade.color = new Color(0, 0, 0, fades);
            time = 0;
        }

        else if (fades <= 0f)
        {
            isFadeIn = false;
            isFirst = false;
        }
    }
}
