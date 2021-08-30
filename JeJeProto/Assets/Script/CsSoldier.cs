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
        //���� ȸ��. �������� ���� �ֵ��� �ص� �������� (90*n)
        transform.Rotate(new Vector3(0, 90 * Random.Range(0, 4), 0));

        founding = false;
    }

    private void Move()
    {
        rigidbody.MovePosition(transform.position + transform.forward * 0.256f * Time.deltaTime * speed); // �ٶ󺸴� ���� ������ �̵�

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

        // 8�ʸ��� ���� ��ġ Ȯ���ؼ� �ü�
        yield return new WaitForSeconds(8f);
        time = true;
    }

    private void SeePlayer()
    {
        RaycastHit hit;
        // ���� �þ߿� ������ 10�� �̳��� ������
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

        // 8�� ���� ����
        yield return new WaitForSeconds(8f);
        chace = false;
        speed = 1;
    }

    private void FindPlayer()
    {
        // ������ ��ü�� ��ġ ���
        if ((player.transform.position.x - transform.position.x) >= (player.transform.position.z - transform.position.z)) //x���� �� �ָ�
        {
            // ���� z��ġ�� ������ ��ǥ ����
            PPos = new Vector3(transform.position.x, transform.position.y, player.transform.position.z);
        }
        else // �ݴ�
        {
            // ���� x��ġ�� ������ ��ǥ ����
            PPos = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
        transform.LookAt(PPos); // �ϴ� �̵� ������ �ٶ�

    }
}