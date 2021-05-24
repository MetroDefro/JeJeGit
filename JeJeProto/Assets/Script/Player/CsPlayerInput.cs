using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsPlayerInput : MonoBehaviour
{
    //사용자 입력 감지
    public string moveAxisName = "Vertical";
    public string rotateAxisName = "Horizontal";
    public string jumpButtonName = "Jump";

    //프로퍼티
    public float move { get; private set; }
    public float rotate { get; private set; }
    public bool jump { get; private set; }
    public bool dash { get; private set; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //게임오버 상태에서는 입력을 감지하지 않음
        /*
        if(GameManager.instance != null && GameManager.instance.isGameover)
        {
            move = 0;
            rotate = 0;
            
        }
        */

        //입력 감지
        move = -Input.GetAxis(moveAxisName);
        rotate = Input.GetAxis(rotateAxisName);
        jump = Input.GetButtonDown(jumpButtonName);
        //대쉬 버튼
        dash = Input.GetKey(KeyCode.LeftShift);
    }
}
