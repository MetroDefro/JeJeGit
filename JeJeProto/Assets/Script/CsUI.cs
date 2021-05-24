using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsUI : MonoBehaviour
{
    private Image spriteImage;

    public GameObject book;

    private CsPlayerController player;

    public GameObject hintNote;
    //힌트 이미지 교체하는 코드인데 프로토에서는 상관 없을 듯

    public Text warning;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<CsPlayerController>();
        spriteImage = hintNote.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OfenBook()
    {
        SoundManager.instance.ClickSound();
        if (book.activeSelf == false)
            book.SetActive(true);
        else
            book.SetActive(false);
    }

    public void UseHint()
    {
        SoundManager.instance.ClickSound();
        if (hintNote.activeSelf == true){
            hintNote.SetActive(false);
            return;
        } 

        //힌트 사용!
        if (player.puzzle == null)
        {
            warning.text = "근처에 퍼즐이 없습니다.";
            StartCoroutine(WaitForIt());
            return;
        }

        if (player.puzzle.gameObject.GetComponent<CsPuzzle>().hint == false)
        {
            if (GameManager.instance.token < 3)
            {
                warning.text = "돈이 부족합니다.";
                StartCoroutine(WaitForIt());
                return;
            }
        }

        //사용하면 무슨 이팩트 보여줘?

        //있다면 일단 보시겠습니까? 안내문 띄우나?
        //이거 힌트 보는게 처음일 때만?

        //힌트 사진을 해당 퍼즐 힌트로 고쳐야지
        spriteImage.sprite = player.puzzle.gameObject.GetComponent<CsPuzzle>().hintSprite;

        //힌트 수첩 누르면 힌트 이미지 뜸(퍼즐 결과)
        hintNote.SetActive(true);

        //처음이라면? 사용했으니
        if (player.puzzle.gameObject.GetComponent<CsPuzzle>().hint == false)
            GameManager.instance.token -= 3;

        //힌트 보여주면 그 힌트는 true가 됨.
        player.puzzle.gameObject.GetComponent<CsPuzzle>().hint = true;
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(0.5f);
        warning.text = null;
    }
}
