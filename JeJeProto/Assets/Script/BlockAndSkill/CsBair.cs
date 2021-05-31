using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsBair : MonoBehaviour
{
    private GameObject player;
    private GameObject target;

    private Rigidbody rigidbody;
    private Animator animator;

    private bool isGo;
    private bool breaking;

    // Start is called before the first frame update
    void Start()
    {
        isGo = false;
        breaking = false;

        player = GameObject.Find("Player");
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Break();

        if (isGo)
            Go();
        else
            Move();
    }

    private void Break()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = GetClickedObject();

            if (target == null)
            {
                return;
            }

            //선택된게 스킬 블록
            else if (target.GetComponent<Collider>().CompareTag("BBlock"))
            {
                SoundManager.instance.UseSkillSound();
                Go();
                isGo = true;
                animator.SetBool("Go", true);
                StartCoroutine(Timer());
            }
        }
    }

    private void Go()
    {
        if (target == null)
            return;
        if (breaking)
            return;
        if (Vector3.Distance(target.transform.position, transform.position) < 0.17f)
        {
            animator.SetBool("Attack", true);
            StartCoroutine(Attack());
            animator.SetBool("Go", false);
            target.SendMessage("Conversion");
            return;
        }
        transform.LookAt(target.transform);
        GetComponent<Rigidbody>().MovePosition(Vector3.MoveTowards(transform.position, target.transform.position, 5 * Time.deltaTime));

    }

    private void EndAttack()
    {
        animator.SetBool("Attack", false);
        isGo = false;
        breaking = false;
    }

    IEnumerator Attack()
    {
        breaking = true;
        yield return new WaitForSeconds(1f);
        SoundManager.instance.BreakSound();
        EndAttack();
    }
    private void Move()
    {
        transform.LookAt(player.transform);
        if (Vector3.Distance(player.transform.position, transform.position) < 0.25f)
        {
            animator.SetBool("Walk", false);
            return;
        }

        if (Vector3.Distance(player.transform.position, transform.position) > 0.8f)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + 0.1f);
        }

        animator.SetBool("Walk", true);
        GetComponent<Rigidbody>().MovePosition(Vector3.MoveTowards(transform.position, player.transform.position, 1f * Time.deltaTime));

    }

    private GameObject GetClickedObject()
    {
        RaycastHit hit;
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //마우스 포인트 근처 좌표를 만든다. 
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))   //마우스 근처에 오브젝트가 있는지 확인
        {

            //있으면 오브젝트를 저장한다.

            target = hit.collider.gameObject;

        }
        return target;
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5f);
        animator.SetBool("Go", false);
        isGo = false;
    }
}
