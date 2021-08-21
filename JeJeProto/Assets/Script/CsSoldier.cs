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

        // ������ ��ü�� ��ġ ���
        if ((player.transform.position.x - transform.position.x) >= (player.transform.position.z - transform.position.z)) //x���� �� �ָ�
        {
            // ���� x��ġ�� ������ ��ǥ ����
            PPos = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
        else // �ݴ�
        {
            // ���� z��ġ�� ������ ��ǥ ����
            PPos = new Vector3(transform.position.x, transform.position.y, player.transform.position.z);
        }
        transform.LookAt(PPos); // �ϴ� �̵� ������ �ٶ�
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
        //���� ȸ��. �������� ���� �ֵ��� �ص� �������� (90*n)
        transform.Rotate(new Vector3(0, 90, 0));

        founding = false;
    }

    private void Move()
    {
        rigidbody.MovePosition(transform.position + transform.forward * 0.256f * Time.deltaTime); // �ٶ󺸴� ���� ������ �̵�

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

        // ������ ��ü�� ��ġ ���
        if ((player.transform.position.x - transform.position.x) >= (player.transform.position.z - transform.position.z)) //x���� �� �ָ�
        {
            // ���� x��ġ�� ������ ��ǥ ����
            PPos = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
        else // �ݴ�
        {
            // ���� z��ġ�� ������ ��ǥ ����
            PPos = new Vector3(transform.position.x, transform.position.y, player.transform.position.z);
        }
        transform.LookAt(PPos); // �ϴ� �̵� ������ �ٶ�

        // 8�ʸ��� ���� ��ġ Ȯ���ؼ� �ü�
        yield return new WaitForSeconds(8f);
        time = true;
    }
}