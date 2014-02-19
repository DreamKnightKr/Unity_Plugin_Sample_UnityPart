using UnityEngine;
using System.Collections;

public class ModuleWebBrowser_Android : ModuleWebBrowser_Dummy {
#if UNITY_ANDROID
	AndroidJavaObject activity = null;
	AndroidJavaObject pluginSimple = null;

	public override void Init()
	{
		// 현재 실행 중인 유니티 액티비티를 가져와서 변수에 저장
		AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		activity = jc.GetStatic<AndroidJavaObject>("currentActivity");

		Debug.Log("Try Call Plugin");
		pluginSimple = new AndroidJavaObject("com.cws.WebBrowserPlugin.WebBrowserPlugin");
		pluginSimple.Call("Init", activity);
	}

	public override string GetName()
	{
		return "Android";
	}

	public override string GetVersion()
	{
		return "v1.0.0";
	}

	public override void OpenWebPage(string url)
	{
		if(null == pluginSimple) return;

		pluginSimple.CallStatic("OpenWebBrowser", url);
	}

	public override void OpenEmbeddedWebPage(string url)
	{
		if(null == pluginSimple) return;
		
		pluginSimple.CallStatic("OpenEmbeddedWebBrowser", url);
	}

	public void OpenEmbeddedWebPageData(string data)
	{
		if(null == pluginSimple) return;
		
		pluginSimple.CallStatic("OpenEmbeddedWebBrowserData", data);
	}
#endif
}
