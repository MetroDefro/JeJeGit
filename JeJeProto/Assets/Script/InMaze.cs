using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InMaze : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {

            CameraManager.instance.SubCameraOn();

        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            CameraManager.instance.MainCameraOn();

        }
    }
}
