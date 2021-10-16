using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public Image[] font;
    public Image[] credit;
    float fade = 1.0f;
    float time = 0;

    public Image fadeIMG;

    int f;
    int c;

    bool timer;

    bool isFadeOut;
    bool isFadeIn;

    bool first;
    // Start is called before the first frame update
    void Start()
    {
        first = true;
        timer = false;
        f = 0;
        c = 0;
        for(int i = 0; i < font.Length; i++)
        {
            font[i].color = new Color(1, 1, 1, 0);
        }

        for (int i = 0; i < credit.Length; i++)
        {
            credit[i].color = new Color(1, 1, 1, 0);
        }

        isFadeIn = false;
        isFadeOut = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (first){
            FadeIn();
            return;
        }
        


        if (f != font.Length)
        {
            if (timer)
            {
                time += Time.deltaTime;
                if (fade < 1.0f && time >= 0.1f)
                {
                    fade += 0.05f;
                    font[f].color = new Color(1, 1, 1, fade);
                    time = 0;
                }

            }
            else
            {
                if (fade > 1.0f && time >= 0.1f)
                {
                    fade = 0;
                    StartCoroutine(Delay());
                    time = 0;
                }
            }
        }
        else
        {

            if (c == credit.Length)
                return;
            GoFadeIn();
            if (!isFadeOut && !isFadeIn)
            {
                isFadeOut = true;
            }
            GoFadeOut();
        }


    }

    void GoFadeOut()
    {
        if (!isFadeOut)
            return;

        time += Time.deltaTime;
        if (fade < 1.0f && time >= 0.1f)
        {
            fade += 0.05f;
            credit[c].color = new Color(1, 1, 1, fade);
            time = 0;
        }
        else if (fade >= 1.0f)
        {
            
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
        if (fade > 0.0f && time >= 0.1f)
        {
            fade -= 0.05f;
            credit[c].color = new Color(1, 1, 1, fade);
            time = 0;
        }
        else if (fade <= 0f)
        {
            c++;
            isFadeIn = false;
        }
    }

    void FadeIn()
    {
        time += Time.deltaTime;
        if (fade > 0.0f && time >= 0.1f)
        {
            fade -= 0.02f;
            fadeIMG.color = new Color(0, 0, 0, fade);
            time = 0;
        }
        else if (fade <= 0f)
        {
            first = false;
            fade = 0.0f;
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        timer = true;
        yield return new WaitForSeconds(3f);
        // 다음 폰트 알파값 바꾸기
        f++;
        timer = false;
    }

}
