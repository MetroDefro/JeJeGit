using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsBBlock : MonoBehaviour
{
    public GameObject explostion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //변환
    public void Conversion()
    {
        //소리
        StartCoroutine(Breaking());
        //Destroy(gameObject, 1f);
    }

    IEnumerator Breaking()
    {
        yield return new WaitForSeconds(1f);
        GameObject effect1 = Instantiate(explostion, transform.position, transform.rotation);
        Destroy(effect1, 3f);
        gameObject.SetActive(false);
    }
}
