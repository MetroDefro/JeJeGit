using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsMBlock : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rigidbody;
    //private bool bad = false;
    public bool moving;

    private Vector3 target;
    private Vector3 firstPos;

    // Start is called before the first frame update
    void Start()
    {
        moving = false;
        player = GameObject.Find("Player");
        rigidbody = GetComponent<Rigidbody>();
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (moving == false)
        {
            transform.position = new Vector3(target.x, transform.position.y, target.z);
            return;
        }

        rigidbody.MovePosition(Vector3.MoveTowards(transform.position, target, 2 * Time.deltaTime));
        if (Vector3.Distance(target, transform.position) < 0.01f)
        {
            transform.position = new Vector3(target.x, transform.position.y, target.z);
            target = transform.position;
            moving = false;
        }
            //= Vector3.MoveTowards(transform.position, target, 5 * Time.deltaTime);
    }
    //변환
    public void Conversion()
    {
        if (moving == true)
            return;

        SoundManager.instance.MagnetSound();

        moving = true;
        Vector3 destPos = player.transform.position;
        Vector3 direction = (destPos - rigidbody.position).normalized;

        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.z))
        {
            if (direction.x < 0)
            {
                direction.x = -1;
                direction.z = 0;
            }
            else
            {
                direction.x = 1;
                direction.z = 0;
            }
        }
        else
        {
            if (direction.z < 0)
            {
                direction.z = -1;
                direction.x = 0;
            }
            else
            {
                direction.z = 1;
                direction.x = 0;
            }
        }

        direction.y = 0;

        Vector3 newPos = direction * 0.256f + rigidbody.position;

        //rigidbody.MovePosition(newPos);
        firstPos = target;
        target = newPos;

        StartCoroutine(Timer());

        /*
        Vector3 Bp = transform.position;
        Bp.x -= transform.position.x % 2;
        Bp.z -= transform.position.z % 2;
        transform.position = Bp;
        */
    }

    public void Conversion2()
    {
        if (moving == true)
            return;
        moving = true;

        Vector3 destPos = player.transform.position;
        Vector3 direction = (destPos - rigidbody.position).normalized;

        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.z))
        {
            if (direction.x < 0)
            {
                direction.x = -1;
                direction.z = 0;
            }
            else
            {
                direction.x = 1;
                direction.z = 0;
            }
        }
        else
        {
            if (direction.z < 0)
            {
                direction.z = -1;
                direction.x = 0;
            }
            else
            {
                direction.z = 1;
                direction.x = 0;
            }
        }

        direction.y = 0;

        Vector3 newPos = direction * -0.256f + rigidbody.position;

        //rigidbody.MovePosition(newPos);
        firstPos = target;
        target = newPos;

        StartCoroutine(Timer());

        /*
        Vector3 Bp = transform.position;
        Bp.x -= transform.position.x % 2;
        Bp.z -= transform.position.z % 2;
        transform.position = Bp;
        */


    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.5f);
        if((transform.position.x != target.x) && (transform.position.z != target.z))
        {
            transform.position = new Vector3(firstPos.x, transform.position.y, firstPos.z);
            target = transform.position;
            moving = false;
        }
    }


}
