using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : BaseScene
{
    protected override bool Init()
    {
        if (base.Init() == false)
            return false;

        SceneType = Define.Scene.Main;
        Debug.Log($"{SceneType} Init");

        /*Managers.UI.ShowPopupUI<UI_Main>();
        Managers.Sound.PlayAudioClip(Define.Sound.Bgm, "BGM1");*/
        return true;
    }
}
