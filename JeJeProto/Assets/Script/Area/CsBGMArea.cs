using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsBGMArea : MonoBehaviour
{
    public AudioClip BGM;
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
            SoundManager.instance.ChangeBGM(BGM);

        }
    }

    
    private void OnTriggerExit(Collider collider)
    {
        SoundManager.instance.SoundStop();
    }
    
}
