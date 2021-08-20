using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsSoldier : MonoBehaviour
{
    private GameObject player;

    private Rigidbody rigidbody;
    private Animator animator;

    Vector3 PPos;
    public bool canMove;
    public bool founding;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        animator.SetBool("Walk", true);

        canMove = false;
        founding = false;
    }

    // Update is called once per frame
    void Update()
    {
        blocked();
        if (canMove)
            Move();
        else
            Direction();
    }

    private void Direction()
    {
        if (founding) // ���� ������ ���� ã�� ���̸�
        {
            rigidbody.MovePosition(transform.position + transform.forward * 0.256f * Time.deltaTime); // �ٶ󺸴� ���� ������ �̵�
            return;
        }
        // ������ ��ü�� ��ġ ���
        if ((player.transform.position.x - transform.position.x) >= (player.transform.position.z - transform.position.z)) //x���� �� �ָ�
        {
            // ���� Z��ġ�� ������ ��ǥ ����
            PPos = new Vector3(transform.position.x, transform.position.y, player.transform.position.z);
        }
        else // �ݴ�
        {
            // ���� X��ġ�� ������ ��ǥ ����
            PPos = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }

        transform.LookAt(PPos); // �ϴ� �̵� ������ �ٶ�
        canMove = true;
    }

    private void Move()
    {
       // animator.SetBool("Walk", true); // �ȱ� ��� �ѱ�

        
        rigidbody.MovePosition(transform.position + transform.forward * 0.256f * Time.deltaTime); // �ٶ󺸴� ���� ������ �̵�

    }

    private void blocked()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 0.256f))
        {
            if (hit.collider.gameObject.tag == "Wall")
                founding = true;
                canMove = false;
                // �ݶ��̴� ���� ��� �ٸ� �������� �̵��ϰ� �ϴ� �� �ʿ�
                // 90���� �� ��������?
                transform.rotation = Quaternion.Euler(0, 90, 0);
                StartCoroutine(Timer());

        }
    }
    IEnumerator Timer()
    {
        // �ڷ�ƾ���� �̷��� �̵��ϴ� ���� �� 5��? 10��? ������ �ϰ� �̰� ������ �ٽ� üũ�ؼ� ����������
        yield return new WaitForSeconds(2f);
        founding = false;
    }
}