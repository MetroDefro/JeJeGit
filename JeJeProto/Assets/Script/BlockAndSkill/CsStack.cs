using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsStack: MonoBehaviour
{
    private bool isGo;
    private GameObject player;

    private GameObject camera;
    public Transform target;
    private Vector3 Bp;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraManager.instance.subC.enabled)
            return;
        Stack();

        if (isGo)
            Go(Bp);
        else
            Move();
    }

    private void Stack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mos = Input.mousePosition;
            mos.z = camera.GetComponent<Camera>().farClipPlane; // 카메라가 보는 방향과, 시야를 가져온다.

            Vector3 dir = camera.GetComponent<Camera>().ScreenToWorldPoint(mos);

            RaycastHit hit;
            if (Physics.Raycast(camera.transform.position, dir, out hit, mos.z))
            {
                Bp = hit.point;
                Bp.x -= hit.point.x % 0.256f - 0.151471f + 0.256f;
                Bp.z -= hit.point.z % 0.256f - 0.233655f + 0.256f;
                Bp.y = hit.point.y + 0.256f;
                if (Vector3.Distance(player.transform.position, Bp) <= 0.2)
                    return;

                if (Mathf.Abs(Bp.x - player.transform.position.x) <= 0.15f && Mathf.Abs(Bp.z - player.transform.position.z) <= 0.15f)
                    return;


                Collider[] colliders;
                colliders = Physics.OverlapSphere(Bp, 0.1f);
                foreach (Collider hitCollider in colliders)
                {
                    if (hitCollider.tag == "BBlock" || hitCollider.tag == "MBlock" || hitCollider.tag == "Object" || hitCollider.tag == "Block")
                    {
                        return;
                    }
                }

            }
            // 월드의 좌표를 클릭했을 때 화면에 자신이 보고있는 화면에 맞춰 좌표를 바꿔준다.
            isGo = true;
            SoundManager.instance.UseSkillSound();
            Go(Bp);
        }
    }

    private void Move()
    {
        transform.LookAt(player.transform);
        if (Vector3.Distance(player.transform.position, transform.position) < 0.3f)
        {
            return;
        }

        if (Vector3.Distance(player.transform.position, transform.position) > 0.8f)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.1f, player.transform.position.z + 0.2f);
        }


        GetComponent<Rigidbody>().MovePosition(Vector3.MoveTowards(transform.position, player.transform.position, 1f * Time.deltaTime));

    }

    private void Go(Vector3 Bp)
    {
        if (Bp == null)
            return;
        if (Vector3.Distance(Bp, transform.position) < 0.17f)
        {
            SoundManager.instance.StackSound();
            target.position = Bp;
            isGo = false;
            return;
        }
        GetComponent<Rigidbody>().MovePosition(Vector3.MoveTowards(transform.position, Bp, 5 * Time.deltaTime));

    }
}
