using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveHouse : MonoBehaviour
{
    private GameObject player;


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

        SoundManager.instance.SaveSound();
        Save();
    }

    private void Save()
    {
        GameManager.instance.SaveGame();
        
    }


}
