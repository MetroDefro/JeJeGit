using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CsNextStage : MonoBehaviour
{
    private GameObject player;

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
        if (GameManager.instance.inter)
            Inter();
    }

    //상호작용
    private void Inter()
    {
        if (Vector3.Distance(player.transform.position, transform.position) > 0.5)
            return;

        SceneManager.LoadScene("New Stage2");
    }
}
