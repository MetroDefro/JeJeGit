using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsUI : MonoBehaviour
{
    //private Image spriteImage;

    public GameObject book;

    private CsPlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<CsPlayerController>();
        //spriteImage = hintNote.GetComponent<Image>();
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
}
