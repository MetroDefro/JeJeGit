using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPassBlock : MonoBehaviour
{
    public float rot_speed = 100.0f;

    public GameObject Player;
    public Camera MainCamera;

    private GameObject target;

    private float camera_dist = 0f; //리그로부터 카메라까지의 거리
    public float camera_width = -10f; //가로거리
    public float camera_height = 4f; //세로거리
    public float camera_fix = 3f;//레이케스트 후 리그쪽으로 올 거리

    Vector3 pos;
    Vector3 dir;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        MainCamera = GetComponent<Camera>();

        //카메라리그에서 카메라까지의 길이
        camera_dist = Mathf.Sqrt(camera_width * camera_width + camera_height * camera_height);

        //카메라리그에서 카메라위치까지의 방향벡터
        dir = new Vector3(0, camera_height, camera_width).normalized;

        pos = new Vector3(0, 0.025f, 0.045f);
    }


    void Update()
    {
        RaycastHit hit;
        int lM = 1 << LayerMask.NameToLayer("Wall");
        float Distance = Vector3.Distance(transform.position, Player.transform.position);
        Vector3 Direction = (Player.transform.position - transform.position).normalized;

        if (Physics.Raycast(transform.position, Direction, out hit, Distance, lM))
        {
            transform.position = hit.point;
            target = hit.collider.gameObject;
        }
        else
        {
            if (target == null)
                return;
            if(Vector3.Distance(transform.position, target.transform.position) > 0.29)
            {
                transform.localPosition = pos;
                target = null;
            }
                

        }
            


    }
}
