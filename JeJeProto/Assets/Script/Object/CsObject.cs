using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsObject : MonoBehaviour
{
    private GameObject player;

    public int id;
    public int nowId;

    public bool noToken;
    public bool isPet;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player");
        nowId = id;
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.inter)
            Inter();
        Talking();
    }


    //상호작용
    private void Inter()
    {

        if (Vector3.Distance(player.transform.position, transform.position) > 0.5)
            return;


        


        if(!(nowId == 0))
            TalkManager.instance.Talk(nowId);

        if (noToken)
            return;
        DropToken();
    }

    private void DropToken()
    {

        //얻기
        GameManager.instance.token += 1;
        SoundManager.instance.CoinSound();
        noToken = true;
    }

    private void Talking()
    {
        if (nowId == 0)
            return;
        if (Vector3.Distance(player.transform.position, transform.position) > 0.5)
            return;
        if (!TalkManager.instance.isTalking)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!TalkManager.instance.Talk(nowId))
            {
                if (isPet)
                {
                    if (id == 501)
                        GameManager.instance.pet = 1;
                    else if (id == 502)
                        GameManager.instance.pet = 2;
                    else if (id == 503)
                        GameManager.instance.pet = 3;
                    gameObject.SetActive(false);
                }
            }
        }

    }

    public void SaveObject(int i)
    {
        PlayerPrefsX.SetBool("noToken" + i, noToken);
        PlayerPrefsX.SetBool("objtAct" + i, gameObject.activeSelf);
    }

    public void LoadObject(int i)
    {
        noToken = PlayerPrefsX.GetBool("noToken" + i);
        gameObject.SetActive(PlayerPrefsX.GetBool("objtAct" + i));
    }

}
