using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsMiniTalkArea : MonoBehaviour
{
    private GameObject player;

    public int id;

    void Awake()
    {
        player = GameObject.Find("Player");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    //애리어 안에 들어와있는가?
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {

            TalkManager.instance.SmallTalk(id);

        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            TalkManager.instance.Exitarea();

        }
    }
}
