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
    private bool founding;
    private bool time;

    public int speed;
    private bool chace;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        animator.SetBool("Walk", true);

        founding = false;
        time = true;

        chace = false;

        FindPlayer();

        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        blocked();
        SeePlayer();
        if (chace)
            FindPlayer();
        else if (founding)
            Direction();
        Move();
    }

    private void Direction()
    {
        //임의 회전. 랜덤으로 값을 주도록 해도 괜찮을듯 (90*n)
        transform.Rotate(new Vector3(0, 90 * Random.Range(0, 4), 0));

        founding = false;
    }

    private void Move()
    {
        rigidbody.MovePosition(transform.position + transform.forward * 0.256f * Time.deltaTime * speed); // 바라보는 방향 쪽으로 이동

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

        FindPlayer();

        // 8초마다 제제 위치 확인해서 시선
        yield return new WaitForSeconds(8f);
        time = true;
    }

    private void SeePlayer()
    {
        RaycastHit hit;
        // 병정 시야에 제제가 10블럭 이내로 들어오면
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2.56f))
        {
            if (hit.collider.gameObject.tag == "Player")
            {
                StartCoroutine(Bust());
            }
        }
    }

    IEnumerator Bust()
    {
        speed = 2;
        chace = true;

        FindPlayer();

        // 8초 동안 실행
        yield return new WaitForSeconds(8f);
        chace = false;
        speed = 1;
    }

    private void FindPlayer()
    {
        // 제제와 객체의 위치 계산
        if ((player.transform.position.x - transform.position.x) >= (player.transform.position.z - transform.position.z)) //x축이 더 멀면
        {
            // 제제 z위치만 가져온 좌표 생성
            PPos = new Vector3(transform.position.x, transform.position.y, player.transform.position.z);
        }
        else // 반대
        {
            // 제제 x위치만 가져온 좌표 생성
            PPos = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
        transform.LookAt(PPos); // 일단 이동 방향을 바라봄

    }
}