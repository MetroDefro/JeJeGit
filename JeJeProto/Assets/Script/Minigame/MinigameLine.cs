using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameLine : MonoBehaviour
{
    public Transform pixel;
    public GameObject lineX;
    public GameObject lineY;

    public bool clicked;

    public bool endButton;
    public bool strongButton;
    public bool isTrap;

    private GameObject ins;
    private Transform Par;

    private GameObject Chain;

    // Start is called before the first frame update
    void Start()
    {
        Par = GameObject.Find("Parent").transform;
        clicked = false;
        Chain = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 CenterPosX(Vector3 pixel)
    {
        Vector3 pos = new Vector3(pixel.x + 0.35f, pixel.y, pixel.z);
        return pos;
    }
    private Vector3 CenterPosZ(Vector3 pixel)
    {
        Vector3 pos = new Vector3(pixel.x, pixel.y, pixel.z - 0.35f);
        return pos;
    }
    public void ComparePixel()
    {
        if (isTrap)
            return;
        if (clicked)
            return;
        
        if (Vector3.Distance(Chain.GetComponent<MinigameChain>().PreviousPixel.position, pixel.position) > 1f)
            return;
        
        if (Vector3.Distance(Chain.GetComponent<MinigameChain>().PreviousPixel.position, pixel.position) < 0.01f)
            return;

        //전 픽셀의 오른쪽인 경우
        if ((Chain.GetComponent<MinigameChain>().PreviousPixel.position.x < pixel.position.x) &&
            (Chain.GetComponent<MinigameChain>().PreviousPixel.position.z - pixel.position.z < 0.03f) &&
            (Chain.GetComponent<MinigameChain>().PreviousPixel.position.z - pixel.position.z > -0.03f))
        {
            ins = Instantiate(lineX, CenterPosX(Chain.GetComponent<MinigameChain>().PreviousPixel.position), lineX.transform.rotation);
            ins.transform.parent = Par;
        } 
        //전 픽셀의 왼쪽인 경우
        else if ((Chain.GetComponent<MinigameChain>().PreviousPixel.position.x >= pixel.position.x) &&
            (Chain.GetComponent<MinigameChain>().PreviousPixel.position.z - pixel.position.z < 0.03f) &&
            (Chain.GetComponent<MinigameChain>().PreviousPixel.position.z - pixel.position.z > -0.03f))
        {
            ins = Instantiate(lineX, CenterPosX(pixel.position), lineX.transform.rotation);
            ins.transform.parent = Par;
        }
        //전 픽셀의 위쪽인 경우
        else if ((Chain.GetComponent<MinigameChain>().PreviousPixel.position.z < pixel.position.z) &&
            (Chain.GetComponent<MinigameChain>().PreviousPixel.position.x - pixel.position.x < 0.03f) &&
            (Chain.GetComponent<MinigameChain>().PreviousPixel.position.x - pixel.position.x > -0.03f))
        {
            ins = Instantiate(lineY, CenterPosZ(pixel.position), lineY.transform.rotation);
            ins.transform.parent = Par;
        }          
        //전 픽셀의 아래쪽인 경우
        else if ((Chain.GetComponent<MinigameChain>().PreviousPixel.position.z >= pixel.position.z) &&
            (Chain.GetComponent<MinigameChain>().PreviousPixel.position.x - pixel.position.x < 0.03f) &&
            (Chain.GetComponent<MinigameChain>().PreviousPixel.position.x - pixel.position.x > -0.03f))
        {
            ins = Instantiate(lineY, CenterPosZ(Chain.GetComponent<MinigameChain>().PreviousPixel.position), lineY.transform.rotation);
            ins.transform.parent = Par;
        }        
        else
            return;
        SoundManager.instance.MinigameWoolSound();
        Chain.GetComponent<MinigameChain>().PreviousPixel = pixel;

        clicked = true;
        MinigameManager.instance.rimitC --;

        if (endButton)
        {
            MinigameManager.instance.MiniGameClear();
        }

        
    }
    // 미니게임 2
    // 일단 실을 놓는 것은 이전 선택한 칸의 위치와 지금 칸의 위치를 비교해 좌우면 가로실, 위아래면 세로실 배정
    // 이 칸과 다음 칸의 정 가운데에 실 배치
    // 해당 범위 안의 실 tag를 가진 오브젝트를 세어보는 것으로 count
    // 이전 칸과 지금 칸의 위치가 너무 멀면 바로 옆 칸이 아닌걸로 쳐서 return;
}
