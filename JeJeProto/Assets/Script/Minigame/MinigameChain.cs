using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameChain : MonoBehaviour
{
    public GameObject PreviousPixelObject;
    public Transform PreviousPixel;
    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        PreviousPixel = PreviousPixelObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
