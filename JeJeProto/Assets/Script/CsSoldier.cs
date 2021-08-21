using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsSoldier : MonoBehaviour
{
    private GameObject player;

    private Rigidbody rigidbody;
    private Animator animator;

    Vector3 PPos;
    //public bool canMove;
    public bool founding;
    public bool time;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        animator.SetBool("Walk", true);

        founding = false;
        time = true;

        // 제제와 객체의 위치 계산
        if ((player.transform.position.x - transform.position.x) >= (player.transform.position.z - transform.position.z)) //x축이 더 멀면
        {
            // 제제 x위치만 가져온 좌표 생성
            PPos = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
        else // 반대
        {
            // 제제 z위치만 가져온 좌표 생성
            PPos = new Vector3(transform.position.x, transform.position.y, player.transform.position.z);
        }
        transform.LookAt(PPos); // 일단 이동 방향을 바라봄
    }

    // Update is called once per frame
    void Update()
    {
        blocked();
        if (founding)
            Direction();
        Move();
    }

    private void Direction()
    {
        //임의 회전. 랜덤으로 값을 주도록 해도 괜찮을듯 (90*n)
        transform.Rotate(new Vector3(0, 90, 0));

        founding = false;
    }

    private void Move()
    {
        rigidbody.MovePosition(transform.position + transform.forward * 0.256f * Time.deltaTime); // 바라보는 방향 쪽으로 이동

    }

    private void blocked()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 0.128f))
        {
            if (hit.collider.gameObject.tag == "Wall")
            {
                if (time)
                    StartCoroutine(Timer());
                else
                    founding = true;
            }
        }
    }
    IEnumerator Timer()
    {
        time = false;

        // 제제와 객체의 위치 계산
        if ((player.transform.position.x - transform.position.x) >= (player.transform.position.z - transform.position.z)) //x축이 더 멀면
        {
            // 제제 x위치만 가져온 좌표 생성
            PPos = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
        else // 반대
        {
            // 제제 z위치만 가져온 좌표 생성
            PPos = new Vector3(transform.position.x, transform.position.y, player.transform.position.z);
        }
        transform.LookAt(PPos); // 일단 이동 방향을 바라봄

        // 8초마다 제제 위치 확인해서 시선
        yield return new WaitForSeconds(8f);
        time = true;
    }
}