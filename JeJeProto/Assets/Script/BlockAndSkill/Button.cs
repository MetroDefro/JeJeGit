using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject blocks;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "MBlock" || collision.gameObject.tag == "SBlock")
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 0.4f);
            SoundManager.instance.ButtonSound();
            blocks.SetActive(false);
        }
    }
}