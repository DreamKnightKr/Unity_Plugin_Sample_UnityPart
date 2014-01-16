using UnityEngine;
using System.Collections;

public class Modules : MonoBehaviour {
	public TextMesh msg;
	public AndroidJavaObject activity;
	private AndroidJavaObject pluginSimple = null;

	void Awake()
	{
		// 현재 실행 중인 유니티 액티비티를 가져와서 변수에 저장
		AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		activity = jc.GetStatic<AndroidJavaObject>("currentActivity");

		Debug.Log("Try Call Plugin");
		pluginSimple = new AndroidJavaObject("com.cws.unitysimpleplugin.SimplePlugin");
		pluginSimple.Call("initActivity", name, "OnMessageFromPlug", "RTT with Pluging");
	}

	void OnMessageFromPlug(string arg)
	{
		msg.text = arg;
	}
}
