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

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        canMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
            Move();
        else
            Direction();
    }

    private void Direction()
    {
        // ������ ��ü�� ��ġ ���
        if ((player.transform.position.x - transform.position.x) >= (player.transform.position.z - transform.position.z)) //x���� �� �ָ�
        {
            // ���� X��ġ�� ������ ��ǥ ����
            PPos = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
        else // �ݴ�
        {
            // ���� Z��ġ�� ������ ��ǥ ����
            PPos = new Vector3(transform.position.x, transform.position.y, player.transform.position.z);
        }

        transform.LookAt(PPos); // �ϴ� �̵� ������ �ٶ�
        canMove = true;
    }

    private void Move()
    {
        animator.SetBool("Walk", true); // �ȱ� ��� �ѱ�

        
        rigidbody.MovePosition(transform.position + transform.forward * 1f * Time.deltaTime); // �ٶ󺸴� ���� ������ �̵�

    }

    private void OnCollisionEnter(Collision collision)
    {
        //�ݸ��� �±� Ȯ��, ��
        if (collision.gameObject.tag == "Wall")
        {
            canMove = false;
        }
        // �ݶ��̴� ���� ��� �ٸ� �������� �̵��ϰ� �ϴ� �� �ʿ�
        // 90���� �� ��������?
        // �׸��� �׳� ������ �̵�?
        // �ڷ�ƾ���� �̷��� �̵��ϴ� ���� �� 5��? 10��? ������ �ϰ� �̰� ������ �ٽ� üũ�ؼ� ����������
        // �ڷ�ƾ ���̵� ���� �� �ݶ��̴� �ɸ��ٸ� �ٸ� �������� Ʋ��ߵ� ����
    }

}
