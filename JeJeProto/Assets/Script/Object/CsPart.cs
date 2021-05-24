using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsPart : MonoBehaviour
{
    private GameObject player;
    public int part;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");


    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.inter)
            Inter();
    }


    //상호작용
    private void Inter()
    {
        if (Vector3.Distance(player.transform.position, transform.position) > 0.5)
            return;

        //Debug.Log("인터렉션");
        //부품을 얻으면 무엇을 보여주지? 얻었다! 하는 UI Image?

        //부품 얻고, 상자 부순다.
        GameManager.instance.GetPart(part, count);
        gameObject.SetActive(false);
        //Destroy(gameObject);
    }
}
