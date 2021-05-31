using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsTalkArea : MonoBehaviour
{
    public bool first;
    public bool end;
    private GameObject player;

    public int id;
    public int nowId;

    public bool goal;

    public bool inPlayer;

    void Awake()
    {
        player = GameObject.Find("Player");
        nowId = id;
        inPlayer = false;
        first = true;
        end = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (end)
            return;
        Talking();
    }
    
    private void Talking()
    {
        if (!inPlayer)
            return;
        if (!TalkManager.instance.isTalking)
            return;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!TalkManager.instance.Talk(nowId))
            {
                inPlayer = false;
                end = true;
            }            
        }
    }

    //애리어 안에 들어와있는가?
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            
            if (goal)
            {
                if (GameManager.instance.isFixed)
                {
                    if (first == true)
                    {
                        inPlayer = true;
                        TalkManager.instance.Talk(nowId);
                        first = false;
                    }
                }
            }
            else
            {
                //처음 들어올 때 스크립트
                if (first == true)
                {
                    inPlayer = true;
                    TalkManager.instance.Talk(nowId);
                    first = false;
                }
            }
        }
    }

    public void SaveTalkArea(int i)
    {
        PlayerPrefsX.SetBool("end" + i, end);
        PlayerPrefsX.SetBool("first" + i, first);
    }

    public void LoadTalkArea(int i)
    {
        end = PlayerPrefsX.GetBool("end" + i);
        first = PlayerPrefsX.GetBool("first" + i);
    }
}
