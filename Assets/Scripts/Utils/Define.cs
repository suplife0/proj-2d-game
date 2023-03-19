using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Define
{
	public enum Book
	{
		Zero,
		One,
		Two,
		Three,
		Four,
		Five,
		Six,
		Seven,
		Eight,
		Nine,
		Ten,
		Eleven,
		Twelve,
		Thirteen,
		Fourteen,
		Fifteen
	}
	
	public enum UIEvent
	{
		Click,
		Pressed,
		PointerDown,
		PointerUp,
	}

	public enum Scene
	{
		Unknown,
		Loading,
		Main,
		AR,
	}

	public enum Sound
	{
		Bgm,
		Effect,
		Speech,
		Max,
	}

	public enum ARContentType
	{
		Story,
		Interaction
	}

	public enum SettingButtonType
	{
		Mute,
		Star
	}

	public enum AnimState
	{
		None,
		Idle,
		Sweat,
		Walking,
		Working,
		Attack,
	}

	public enum Language
	{
		Kor,
		Eng
	}
}
