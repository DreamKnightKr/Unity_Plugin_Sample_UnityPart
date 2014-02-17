using UnityEngine;
using System.Collections;

public class ModuleNativeIndicator_Android : IModuleNativeIndicator {
	AndroidJavaObject activity = null;
	AndroidJavaObject pluginSimple = null;

	public void Init()
	{
		// 현재 실행 중인 유니티 액티비티를 가져와서 변수에 저장
		AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		activity = jc.GetStatic<AndroidJavaObject>("currentActivity");

		Debug.Log("Try Call Plugin");
		pluginSimple = new AndroidJavaObject("com.cws.IndicatorPlugin.IndicatorPlugin");
		pluginSimple.Call("Init", activity);
	}

	public string GetName()
	{
		return "Android";
	}

	public string GetVersion()
	{
		return "v1.0.0";
	}

	public void SetVisibleNativeIndicator(bool bVisible)
	{
		if(null == pluginSimple) return;

		pluginSimple.Call("ShowProgressIndicator", 1);
	}
}
