using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsLift : MonoBehaviour
{
    public GameObject lift;
    // 올라갈 칸 수
    public int level;
    private double term;

    void Awake()
    {

    }
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
            term = level / 0.1;
            StartCoroutine(ConversionDelay());
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "MBlock" || collision.gameObject.tag == "SBlock")
        {
            term = level / 0.1;
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 1f);
            StartCoroutine(ConversionReturnDelay());
        }
    }

    IEnumerator ConversionDelay()
    {
        if (term > 0)
        {
            for (int i = 0; i < term; i++)
            {
                lift.transform.transform.Translate(Vector3.forward * 0.256f * 0.1f);
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            for (int i = 0; i > term; i--)
            {
                lift.transform.transform.Translate(Vector3.forward * 0.256f * -0.1f);
                yield return new WaitForSeconds(0.01f);
            }
        }
    }

    IEnumerator ConversionReturnDelay()
    {
        if (term > 0)
        {
            for (int i = 0; i > -term; i--)
            {
                lift.transform.transform.Translate(Vector3.forward * 0.256f * -0.1f);
                yield return new WaitForSeconds(0.02f);
            }
        }
        else
        {
            for (int i = 0; i < -term; i++)
            {
                lift.transform.transform.Translate(Vector3.forward * 0.256f * 0.1f);
                yield return new WaitForSeconds(0.02f);
            }
        }
    }
}
