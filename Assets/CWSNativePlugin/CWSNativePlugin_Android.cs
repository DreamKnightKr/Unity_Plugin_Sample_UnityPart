using UnityEngine;
using System.Collections;

public class CWSNativePlugin_Android : CWSNativePlugin_Dummy {
#if UNITY_ANDROID
	AndroidJavaObject activity = null;
	AndroidJavaObject native = null;

	public override void Init()
	{
		// 현재 실행 중인 유니티 액티비티를 가져와서 변수에 저장
		AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		activity = jc.GetStatic<AndroidJavaObject>("currentActivity");

		Debug.Log("Try Call Plugin");
		native = new AndroidJavaObject("com.cws.NativePlugin.NativePlugin");
		native.Call("Init", activity);
	}

	public override string GetName()
	{
		return "Android";
	}

	public override string GetVersion()
	{
		return "v1.0.0";
	}

	public override void CallSimpleFunction (string name)
	{
		if(null == native) return;

		native.Call ("SimpleFunction", name, "OnCalledSimpleFunction", "Native Return SomeString...");
	}

	public override void OpenWebPage(string url)
	{
		if(null == native) return;

		native.CallStatic("OpenWebBrowser", url);
	}

	public override void OpenEmbeddedWebPage(string url)
	{
		if(null == native) return;
		
		native.CallStatic("OpenEmbeddedWebBrowser", url);
	}

	public override void OpenEmbeddedWebPageData(string data)
	{
		if(null == native) return;
		
		native.CallStatic("OpenEmbeddedWebBrowserData", data);
	}
#endif
}
