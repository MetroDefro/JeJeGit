using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsSoldier : MonoBehaviour
{
    private GameObject player;

    private Rigidbody rigidbody;
    private Animator animator;

    Vector3 PPos;
    bool canMove;
    bool founding;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        canMove = false;
        founding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
            Move();
        else
            Direction();
        blocked();
    }

    private void Direction()
    {
        if (founding) // 벽에 막혀서 방향 찾는 중이면
        {
            rigidbody.MovePosition(transform.position + transform.forward * 1f * Time.deltaTime); // 바라보는 방향 쪽으로 이동
            return;
        }
        // 제제와 객체의 위치 계산
        if ((player.transform.position.x - transform.position.x) >= (player.transform.position.z - transform.position.z)) //x축이 더 멀면
        {
            // 제제 X위치만 가져온 좌표 생성
            PPos = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
        else // 반대
        {
            // 제제 Z위치만 가져온 좌표 생성
            PPos = new Vector3(transform.position.x, transform.position.y, player.transform.position.z);
        }

        transform.LookAt(PPos); // 일단 이동 방향을 바라봄
        canMove = true;
    }

    private void Move()
    {
        animator.SetBool("Walk", true); // 걷기 모션 켜기

        
        rigidbody.MovePosition(transform.position + transform.forward * 1f * Time.deltaTime); // 바라보는 방향 쪽으로 이동

    }

    private void blocked()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 0.5f))
        {
            if(hit.collider.gameObject.tag == "Wall")
                founding = true;
                canMove = false;
                // 콜라이더 막힌 경우 다른 방향으로 이동하게 하는 것 필요
                // 90도씩 다 돌려보기?
                transform.rotation = Quaternion.Euler(0, 90, 0);
                StartCoroutine(Timer());

        }
    }
    IEnumerator Timer()
    {
        // 코루틴으로 이렇게 이동하는 것은 한 5초? 10초? 정도로 하고 이거 끝나면 다시 체크해서 움직여보기
        yield return new WaitForSeconds(2f);
        founding = false;
    }
}