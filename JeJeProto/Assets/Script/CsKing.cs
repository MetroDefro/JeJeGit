using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsKing : MonoBehaviour
{
    private GameObject player;

    private Animator animator;

    // Start is called before the first frame update

    void Awake()
    {
        player = GameObject.Find("Player");
        animator = GetComponent<Animator>();
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

    private void Inter()
    {
        if (Vector3.Distance(player.transform.position, transform.position) > 1)
            return;

        if (TalkManager.instance.isTalking)
            return;
        
        if (ManagerManager.instance.CountFixedToy <= 1)
            TalkManager.instance.Talk(514);
        else if (ManagerManager.instance.CountFixedToy <= 4)
            TalkManager.instance.Talk(515);
        else if (ManagerManager.instance.CountFixedToy > 4)
            TalkManager.instance.Talk(516);

    }

    private void Talking()
    {
        if (Vector3.Distance(player.transform.position, transform.position) > 0.5)
            return;
        if (!TalkManager.instance.isTalking)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(ManagerManager.instance.CountFixedToy <= 1)
                TalkManager.instance.Talk(514);
            else if(ManagerManager.instance.CountFixedToy <= 4)
                TalkManager.instance.Talk(515);
            else if (ManagerManager.instance.CountFixedToy > 4)
                TalkManager.instance.Talk(516);
        }
    }
}
