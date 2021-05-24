using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsSBlock : MonoBehaviour
{
    public Transform target;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    //변환
    public void Conversion()
    {
        if (GameManager.instance.skill != 3)
        {
            return;
        }

        Vector3 mos = Input.mousePosition;
        mos.z = GetComponent<Camera>().GetComponent<Camera>().farClipPlane; // 카메라가 보는 방향과, 시야를 가져온다.

        Vector3 dir = GetComponent<Camera>().GetComponent<Camera>().ScreenToWorldPoint(mos);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, dir, out hit, mos.z))
        {
            Vector3 Bp = hit.point;
            Bp.x -= hit.point.x % 0.256f - 0.151471f + 0.256f;
            Bp.z -= hit.point.z % 0.256f - 0.233655f + 0.256f;
            Bp.y = hit.point.y + 0.256f;
            if (Vector3.Distance(player.transform.position, Bp) <= 0.2)
                return;

            if (Mathf.Abs(Bp.x - player.transform.position.x) <= 0.15f && Mathf.Abs(Bp.z - player.transform.position.z) <= 0.15f)
                return;


            Collider[] colliders;
            colliders = Physics.OverlapSphere(Bp, 0.1f);
            foreach (Collider hitCollider in colliders)
            {
                if (hitCollider.tag == "BBlock" || hitCollider.tag == "MBlock" || hitCollider.tag == "Object" || hitCollider.tag == "Block")
                {
                    return;
                }
            }

            SoundManager.instance.StackSound();
            target.position = Bp;

        }
    }
}
