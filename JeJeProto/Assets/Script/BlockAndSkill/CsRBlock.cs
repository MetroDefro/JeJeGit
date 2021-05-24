using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsRBlock : MonoBehaviour
{
    private bool moving;
    public GameObject explostion;
    // Start is called before the first frame update
    void Awake()
    {
        // 해당 회전 축 블록으로부터 3x3x3 범위의 블록들은 불러오기?
        // 하위 오브젝트로 두는게 편할듯
    }
    void Start()
    {
        moving = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        //돌아가는 애니메이션?
    }
    
    // 해당 블록 회전하기
    //변환
    public void Conversion()
    {
        if (moving == true)
            return;

        SoundManager.instance.RotateSound();

        moving = true;

        StartCoroutine(ConversionDelay());

        return;
    }

    IEnumerator ConversionDelay()
    {
        int z = 0;
        GameObject effect1 = Instantiate(explostion, transform.position, transform.rotation);
        Destroy(effect1, 3f);
        while (z < 90)
        {
            GetComponent<Rigidbody>().rotation = GetComponent<Rigidbody>().rotation * Quaternion.Euler(0, 0, 10);
            z += 10;
            yield return new WaitForSeconds(0.02f);
        }
        moving = false;
    }

}
