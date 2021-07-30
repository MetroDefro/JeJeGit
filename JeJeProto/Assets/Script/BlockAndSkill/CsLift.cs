using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsLift : MonoBehaviour
{
    public GameObject lift;

    // 만약 버튼도 같이 올라가야 하는 구조면
    public bool same;
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

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player" || collider.gameObject.tag == "MBlock" || collider.gameObject.tag == "SBlock")
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 0.4f);
            SoundManager.instance.ButtonSound();
            term = level / 0.1;
            StartCoroutine(ConversionDelay());
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player" || collider.gameObject.tag == "MBlock" || collider.gameObject.tag == "SBlock")
        {
            term = level / 0.1;
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 1f);
            StartCoroutine(ConversionReturnDelay());
        }
    }

    IEnumerator ConversionDelay()
    {
        yield return new WaitForSeconds(0.1f);
        if (term > 0)
        {
            for (int i = 0; i < term*2; i++)
            {
                lift.transform.transform.Translate(Vector3.forward * 0.256f * 0.05f);
                if (same)
                    transform.transform.Translate(Vector3.forward * 0.256f * 0.05f);
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            for (int i = 0; i > term*2; i--)
            {
                lift.transform.transform.Translate(Vector3.forward * 0.256f * -0.05f);
                if (same)
                    transform.transform.Translate(Vector3.forward * 0.256f * -0.05f);
                yield return new WaitForSeconds(0.01f);
            }
        }
    }

    IEnumerator ConversionReturnDelay()
    {
        yield return new WaitForSeconds(0.1f);
        if (term > 0)
        {
            for (int i = 0; i > -term*2; i--)
            {
                lift.transform.transform.Translate(Vector3.forward * 0.256f * -0.05f);
                if(same)
                    transform.transform.Translate(Vector3.forward * 0.256f * -0.05f);
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            for (int i = 0; i < -term*2; i++)
            {
                lift.transform.transform.Translate(Vector3.forward * 0.256f * 0.05f);
                if (same)
                    transform.transform.Translate(Vector3.forward * 0.256f * 0.05f);
                yield return new WaitForSeconds(0.01f);
            }
        }
    }
}
