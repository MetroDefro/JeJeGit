﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsPlayerController : MonoBehaviour
{
    //리지드바디
    private Rigidbody playerRigidbody;
    //인풋
    private CsPlayerInput playerInput;
    //애니메이션
    private Animator playerAnimator;

    //속도, 회전, 점프 크기
    public float moveSpeed;
    public float rotateSpeed;
    public float jumpForce;

    private bool isJump = false;


    //파티클
    public GameObject JumpP;
    public GameObject SoilP;

    //감지된 퍼즐
    public Collider puzzle;

    // 발 폭발지점
    public GameObject foot;

    public GameObject followTarget;

    //public Collider Puzzle { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerInput = GetComponent<CsPlayerInput>();
        playerAnimator = GetComponent<Animator>();

        puzzle = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -3)
            GameManager.instance.GameOver();
        //대화 상태에서는 움직이지 않음
        if (TalkManager.instance.isTalking)
        {
            playerAnimator.SetBool("Talking", true);
            return;
        }
        playerAnimator.SetBool("Talking", false);

        Jump();
    }
    void FixedUpdate()
    {
        //대화 상태에서는 움직이지 않음
        if (TalkManager.instance.isTalking)
        {
            playerAnimator.SetBool("Talking", true);
            return;
        }
        playerAnimator.SetBool("Talking", false);

        Rotate();
        Move();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //콜리전 태그 확인, 그라운드
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "BBlock" || collision.gameObject.tag == "MBlock" || collision.gameObject.tag == "SBlock" || collision.gameObject.tag == "Block")
        {
            isJump = false;
            playerAnimator.SetBool("Jump", false);
            SoundManager.instance.PlayerSoundPlay();
        }
    }

    //이동관련
    private void Move()
    {
        playerAnimator.SetFloat("Walk", playerInput.move);

        Vector3 moveDistance = playerInput.move * transform.forward * moveSpeed * Time.deltaTime;
        //대쉬중인가?
        if (playerInput.dash)
        {
            playerRigidbody.MovePosition(playerRigidbody.position + moveDistance * 1.5f);
            playerAnimator.SetBool("Dash", true);
            if (playerInput.move != 0)
                SoundManager.instance.RunSound();
            return;
        }
        playerAnimator.SetBool("Dash", false);
        playerRigidbody.MovePosition(playerRigidbody.position + moveDistance);
        if(playerInput.move != 0)
            SoundManager.instance.WalkSound();
        else
            SoundManager.instance.WalkSoundStop();
    }
    private void Rotate()
    {
        playerAnimator.SetFloat("Walk", playerInput.rotate);

        float turn = playerInput.rotate * rotateSpeed * Time.deltaTime;

        playerRigidbody.rotation = playerRigidbody.rotation * Quaternion.Euler(0, turn, 0f);
        followTarget.transform.rotation = followTarget.transform.rotation * Quaternion.Euler(0, -turn, 0f);
    }
    private void Jump()
    {
        //플레이어 인풋에서 점프 받아옴, 점프중이 아닐 때
        if (playerInput.jump&&!isJump)
        {
            isJump = true;
            playerAnimator.SetBool("Jump", true);
            
            GameObject effect1 = Instantiate(JumpP, foot.transform.position, transform.rotation);
            GameObject effect2 = Instantiate(SoilP, foot.transform.position, transform.rotation);
            Destroy(effect1, 3f);
            Destroy(effect2, 3f);
            SoundManager.instance.PlayerSoundStop();
            SoundManager.instance.JumpSound();
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    IEnumerator JumpDelay()
    {
        yield return new WaitForSeconds(0.2f);
        isJump = false;
        
    }

    //퍼즐 안에 들어와있는가?
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Puzzle")
        {
            //collider.SendMessage("HitAttack", SendMessageOptions.DontRequireReceiver);
            puzzle = collider;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Puzzle")
        {
            //collider.SendMessage("HitAttack", SendMessageOptions.DontRequireReceiver);
            puzzle = null;
        }
    }

}
