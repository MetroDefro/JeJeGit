using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsMagnet: MonoBehaviour
{
    private bool isGo;
    private GameObject player;

    private GameObject target;

    private bool Dir;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (isGo)
            Go(Dir);
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
            else if (target.GetComponent<Collider>().CompareTag("MBlock"))
            {
                SoundManager.instance.UseSkillSound();
                Dir = true;
                isGo = true;
                Go(Dir);
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            target = GetClickedObject();

            if (target == null)
            {
                return;
            }

            //선택된게 스킬 블록
            else if (target.GetComponent<Collider>().CompareTag("MBlock"))
            {
                SoundManager.instance.UseSkillSound();
                Dir = false;
                isGo = true;
                Go(Dir);
            }
        }
    }

    private GameObject GetClickedObject()
    {
        RaycastHit hit;
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //마우스 포인트 근처 좌표를 만든다. 
        if (true == (Physics.Raycast(ray.origin, ray.direction * 10, out hit)))   //마우스 근처에 오브젝트가 있는지 확인
        {

            //있으면 오브젝트를 저장한다.
            if (hit.collider.gameObject.tag == "MBlock")
                target = hit.collider.gameObject;
        }
        return target;
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


    }

    private void Go(bool Dir)
    {
        if (target == null)
            return;
        if (Vector3.Distance(target.transform.position, transform.position) < 0.17f)
        {
            if(Dir)
                target.GetComponent<CsMBlock>().Conversion();
            else
                target.GetComponent<CsMBlock>().Conversion2();
            isGo = false;
            return;
        }
        GetComponent<Rigidbody>().MovePosition(Vector3.MoveTowards(transform.position, target.transform.position, 5 * Time.deltaTime));

    }


}
