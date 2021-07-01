using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsDoor : MonoBehaviour
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

        if (transform.rotation.z == 0)
            transform.rotation = Quaternion.Euler(-90, -90, 0);
        else
            transform.rotation = Quaternion.Euler(-90, 90, -180);
    }
}
