using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UI_AR : UI_Popup
{
    enum Objects
    {
        CoverFrameObject,
        CaptureCompleteObject
    }
    enum Buttons
    {
        BackButton,
        CaptureButton,
        VideoButton,
        ARPlayButton,
        StoryPlayButton,
        CloseButton
    }

    public override bool Init()
    {
        BindObject(typeof(Objects));
        BindButton(typeof(Buttons));
        
        GetObject((int)Objects.CaptureCompleteObject).SetActive(false);
        
        GetButton((int)Buttons.BackButton).gameObject.BindEvent(OnClickBackButton);
        GetButton((int)Buttons.CaptureButton).gameObject.BindEvent(OnClickCaptureButton);
        GetButton((int)Buttons.VideoButton).gameObject.BindEvent(OnClickVideoButton);
        GetButton((int)Buttons.ARPlayButton).gameObject.BindEvent(OnClickARButton);
        GetButton((int)Buttons.StoryPlayButton).gameObject.BindEvent(OnClickARButton);
        GetButton((int)Buttons.CloseButton).gameObject.BindEvent(OnClickCloseButton);
        
        GetButton((int)Buttons.CloseButton).gameObject.SetActive(false);
        GetButton((int)Buttons.StoryPlayButton).gameObject.SetActive(false);
        
        if (base.Init() == false)
            return false;
        return true;
    }

    private void OnClickBackButton()
    {
        Managers.Scene.ChangeScene(Define.Scene.Main);
    }

    private void OnClickCaptureButton()
    {
        Debug.Log("Clicked CaptureButton");
    }

    private void OnClickVideoButton()
    {
        
    }

    private void OnClickARButton()
    {
        Debug.Log($"Clicked AR Button");
    }

    private void OnClickCloseButton()
    {
        Debug.Log($"Clicked Close Button");
    }

    public void OnFinish()
    {
        GetButton((int)Buttons.CloseButton).gameObject.SetActive(false);
        GetButton((int)Buttons.StoryPlayButton).gameObject.SetActive(false);
        GetButton((int)Buttons.ARPlayButton).gameObject.SetActive(true);
    }

    public void OnCoverTracked()
    {
        GetObject((int)Objects.CoverFrameObject).gameObject.SetActive(false);
    }

    public void ChangeButtons(Define.ARContentType contentType)
    {
        GetButton((int)Buttons.CloseButton).gameObject.SetActive(true);
        if (contentType == Define.ARContentType.Story)
        {
            GetButton((int)Buttons.StoryPlayButton).gameObject.SetActive(true);
            GetButton((int)Buttons.ARPlayButton).gameObject.SetActive(false);
        }
        else
        {
            GetButton((int)Buttons.StoryPlayButton).gameObject.SetActive(false);
            GetButton((int)Buttons.ARPlayButton).gameObject.SetActive(true);
        }
    }

    public void OnImageSaved()
    {
        GetObject((int)Objects.CaptureCompleteObject).SetActive(true);
        Invoke("SetActiveOffCaptureCompleteObject", 1.0f);
    }

    private void SetActiveOffCaptureCompleteObject()
    {
        GetObject((int)Objects.CaptureCompleteObject).SetActive(false);
    }
}
