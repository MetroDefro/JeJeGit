using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Image fade;
    public Image image;
    public Image loading;
    public RectTransform mask;
    private bool fadeEnd;
    float fades = 1.0f;
    float time = 0;
    int i = 100;

    public GameObject canvasUI;
    public GameObject talkUI;

    // Start is called before the first frame update
    void Start()
    {
        fadeEnd = false;
        canvasUI.SetActive(false);
        talkUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeEnd)
            return;
        time += Time.deltaTime;
        if (fades > 0.0f && time >= 0.1f)
        {
            fades -= 0.03f;
            fade.color = new Color(1, 1, 1, fades);
            time = 0;
        }

        else if (fades <= 0f)
        {

            StartCoroutine(Loading());
            Destroy(fade);
            Destroy(image);
            Destroy(loading);
            fadeEnd = true;
        }
    }

    IEnumerator Loading()
    {
        while(i <= 2000)
        {
            mask.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, i);
            mask.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, i);
            i += 100;
            yield return new WaitForSeconds(0.05f);
        }
        //canvasUI.SetActive(true);
        talkUI.SetActive(true);
        SoundManager.instance.SoundPlay();
    }

}
