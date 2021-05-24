using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsCube : MonoBehaviour
{
    private bool isGo;
    private GameObject player;

    private GameObject target;

    private bool dir;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (isGo)
            Go();
        else
            Move();

        if (Input.GetMouseButtonDown(0))
        {
            target = GetClickedObject();

            if (target == null)
            {
                return;
            }
            //선택된게 스킬 블록
            else if (target.GetComponent<Collider>().CompareTag("RBlock"))
            {
                SoundManager.instance.UseSkillSound();
                isGo = true;
                Go();
            }
            else if (target.transform.parent.gameObject.GetComponent<Collider>().CompareTag("RBlock"))
            {
                SoundManager.instance.UseSkillSound();
                target = target.transform.parent.gameObject;
                isGo = true;
                Go();
            }
        }
    }

    private void Move()
    {
        transform.LookAt(player.transform);
        if (Vector3.Distance(player.transform.position, transform.position) < 0.3f)
        {
            return;
        }

        if (Vector3.Distance(player.transform.position, transform.position) > 2f)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.1f, player.transform.position.z + 0.2f);
        }

        GetComponent<Rigidbody>().MovePosition(Vector3.MoveTowards(transform.position, player.transform.position, 0.8f * Time.deltaTime));

        return;

    }

    private void Go()
    {
        if (target == null)
            return;
        if (Vector3.Distance(target.transform.position, transform.position) < 0.17f)
        {
            target.GetComponent<CsRBlock>().Conversion();
            target = null;
            isGo = false;
            return;
        }
        GetComponent<Rigidbody>().MovePosition(Vector3.MoveTowards(transform.position, target.transform.position, 5 * Time.deltaTime));

    }

    private GameObject GetClickedObject()
    {
        //클릭한 주변에 회전축 블록이 있는지 찾는것으로 수정
        RaycastHit hit;
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //마우스 포인트 근처 좌표를 만든다. 

        // 레이어로 회전블록만 사용하는 레이어 만들어서 쉽게 인식하게 하자. 
        int lM = 1 << LayerMask.NameToLayer("Rotate");
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit, lM))   //마우스 근처에 오브젝트가 있는지 확인
        {
            // 제제 주변이면 인식 못하게!
            Vector3 Bp = hit.point;
            if (Vector3.Distance(player.transform.position, Bp) <= 0.4)
                return target;

            if (Mathf.Abs(Bp.x - player.transform.position.x) <= 0.3f && Mathf.Abs(Bp.z - player.transform.position.z) <= 0.3f)
                return target;
            //있으면 오브젝트를 저장한다.

            target = hit.collider.gameObject;

        }

        return target;
    }

}
