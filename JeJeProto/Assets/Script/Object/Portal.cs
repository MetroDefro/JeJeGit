using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject friendPortal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //애리어 안에 들어와있는가?
    private void OnTriggerEnter(Collider collider)
    {
        if (GameManager.instance.isLoading)
            return;
        if(collider.tag == "Player")
        {
            // 즉시 그 collider를 freindPortal의 transform으로 이동시켜
            // 이 포탈 트랜스폼의 Y와 콜라이더의 Y 가져옴
            // float 높이 = collider.transform.Y - transform.Y
            float height = collider.transform.position.y - transform.position.y;
            // collider.transform을 freindPortal.X, freindPortal.Y+높이, freindPortal.Z 로 이동
            StartCoroutine(Loading());
            collider.transform.position = new Vector3(friendPortal.transform.position.x,
                friendPortal.transform.position.y + height, friendPortal.transform.position.z);
            SoundManager.instance.PortalSound();
        }


    }

    IEnumerator Loading()
    {
        GameManager.instance.isLoading = true;
        // 사운드 SoundManager.instance.Tellepote();
        yield return new WaitForSeconds(0.5f);
        GameManager.instance.isLoading = false;
    }
}
