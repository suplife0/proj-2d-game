using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Popup : UI_Base
{
    public delegate void loadHandler();
    public event loadHandler onImageLoaded;
    
    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        Managers.UI.SetCanvas(gameObject, true);

        /*onImageLoaded += OnImageLoad;
        SetAllImageResources();
        this.transform.GetChild(0).gameObject.SetActive(false);*/

        //SetButtonSound();
        return true;
    }

    void SetButtonSound()
    {
        foreach (Button button in FindObjectsOfType<Button>())
        {
            AudioClip buttonSound = Resources.Load("Button.wav", typeof(AudioClip)) as AudioClip;
            
            Debug.Log($"Button : {button} | Sound : {buttonSound}");
            button.onClick.AddListener(() => {Managers.Sound.PlayAudioClip(Define.Sound.Effect, buttonSound);});
        }
    }

    private void OnImageLoad()
    {
        this.transform.GetChild(0).gameObject.SetActive(true);
    }

    public virtual void ClosePopupUI()
    {
        Managers.UI.ClosePopupUI(this);
    }

    private void OnDestroy()
    {
        onImageLoaded -= OnImageLoad;
    }
}
