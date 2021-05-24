using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigamePlace : MonoBehaviour
{
    public bool In;
    public int PN;
    public bool End;

    public GameObject nextPlace;
    // Start is called before the first frame update
    void Start()
    {
        In = false;
        End = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (End)
            if(nextPlace != null)
                nextPlace.SetActive(true);
    }
}
