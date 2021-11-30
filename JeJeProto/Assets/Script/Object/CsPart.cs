using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsPart : MonoBehaviour
{
    private bool first;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        first = false;
        player = GameObject.Find("Player");

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

        //Debug.Log("인터렉션");
        if (!first)
            TalkManager.instance.Talk(902);
        first = true;

        //Destroy(gameObject);
    }

    private void Talking()
    {
        if (Vector3.Distance(player.transform.position, transform.position) > 0.5)
            return;
        if (!TalkManager.instance.isTalking)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TalkManager.instance.Talk(902);

            //부품 얻고, 상자 부순다.
            GameManager.instance.GetPart();
            gameObject.SetActive(false);
        }
    }
}
