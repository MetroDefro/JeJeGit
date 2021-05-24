using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioSource BGM;
    public AudioSource playerAudio;

    public AudioClip UseSkill;

    public AudioClip click;
    public AudioClip Break;
    public AudioClip Stack;
    public AudioClip Magnet;
    public AudioClip Rotate;

    public AudioClip Walk;
    public AudioClip Run;
    public AudioClip Jump;

    public AudioClip Talk;
    public AudioClip Coin;
    public AudioClip Save;
    public AudioClip Rullet;

    public AudioClip Portal;
    public AudioClip Button;

    // 미니 게임
    public AudioClip MinigameClear;
    public AudioClip MinigameFail;
    public AudioClip MinigameButton;
    public AudioClip MinigameCloth;
    public AudioClip MinigameCotton;
    public AudioClip MinigameWool;

    // Start is called before the first frame update
    void Start()
    {
        //playerAudio = GetComponent<AudioSource>();
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UseSkillSound()
    {
        playerAudio.PlayOneShot(UseSkill);
    }

    public void ClickSound()
    {
        playerAudio.PlayOneShot(click);
    }

    public void BreakSound()
    {
        playerAudio.PlayOneShot(Break);
    }

    public void StackSound()
    {
        playerAudio.PlayOneShot(Stack);
    }

    public void MagnetSound()
    {
        playerAudio.PlayOneShot(Magnet);
    }

    public void RotateSound()
    {
        playerAudio.PlayOneShot(Rotate);
    }

    public void WalkSound()
    {
        playerAudio.clip = Walk;
        if (!playerAudio.isPlaying)
            playerAudio.Play();
    }

    public void WalkSoundStop()
    {
        playerAudio.clip = null;
    }

    public void RunSound()
    {
        playerAudio.clip = Run;
        if(!playerAudio.isPlaying)
            playerAudio.Play();
    }

    public void JumpSound()
    {
        playerAudio.PlayOneShot(Jump);
    }

    public void CoinSound()
    {
        playerAudio.PlayOneShot(Coin);
    }

    public void TalkSound()
    {
        playerAudio.PlayOneShot(Talk);
    }

    public void SaveSound()
    {
        playerAudio.PlayOneShot(Save);
    }

    public void RulletSound()
    {
        playerAudio.PlayOneShot(Rullet);
    }

    public void PortalSound()
    {
        playerAudio.PlayOneShot(Portal);
    }

    public void ButtonSound()
    {
        playerAudio.PlayOneShot(Button);
    }

    // 미니게임 사운드
    public void MinigameClearSound()
    {
        playerAudio.PlayOneShot(MinigameClear);
    }
    public void MinigameFailSound()
    {
        playerAudio.PlayOneShot(MinigameFail);
    }
    public void MinigameButtonSound()
    {
        playerAudio.PlayOneShot(MinigameButton);
    }
    public void MinigameClothSound()
    {
        playerAudio.PlayOneShot(MinigameCloth);
    }
    public void MinigameCottonSound()
    {
        playerAudio.PlayOneShot(MinigameCotton);
    }
    public void MinigameWoolSound()
    {
        playerAudio.PlayOneShot(MinigameWool);
    }

    // BGM
    public void ChangeBGM(AudioClip audioClip)
    {
        BGM.clip = audioClip;
        BGM.Play();
    }

    public void SoundPlay()
    {
        if (!BGM.isPlaying)
            BGM.Play();
    }

    public void SoundStop()
    {
        BGM.Stop();
    }

    public void PlayerSoundPlay()
    {
        if (!playerAudio.isPlaying)
            playerAudio.Play();
    }

    public void PlayerSoundStop()
    {
        playerAudio.Stop();
    }

}
