using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public Image[] font;
    float fade = 0.0f;
    float time = 0;

    int f;

    bool timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = false;
        f = 0;
        for(int i = 0; i < font.Length; i++)
        {
            font[i].color = new Color(1, 1, 1, 0);
        }

        StartCoroutine(Delay());
    }

    // Update is called once per frame
    void Update()
    {
        if (f == font.Length)
            return;
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

    IEnumerator Delay()
    {
        timer = true;
        yield return new WaitForSeconds(3f);
        // 다음 폰트 알파값 바꾸기
        f++;
        timer = false;
    }

}
