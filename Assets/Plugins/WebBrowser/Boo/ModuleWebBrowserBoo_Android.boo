import UnityEngine

class ModuleWebBrowserBoo_Android (IModuleWebBrowserBoo): 
	activity as AndroidJavaObject = null;
	pluginSimple as AndroidJavaObject = null;
	
	public def Init() as void :
		// 현재 실행 중인 유니티 액티비티를 가져와서 변수에 저장
		jc as AndroidJavaClass = AndroidJavaClass("com.unity3d.player.UnityPlayer")
		activity = jc.GetStatic[of AndroidJavaObject]("currentActivity")	// 유니티 Doc에 예제가 없어서 조금 해매었네요.;;

		Debug.Log("Try Call Plugin")
		pluginSimple = AndroidJavaObject("com.cws.WebBrowserPlugin.WebBrowserPlugin")
		pluginSimple.Call("Init", activity)
		
	public def GetName() as string :
		return "Android"

	public def GetVersion() as string :
		return "v1.0.0"

	public def OpenWebPage(url as string) as void:
		if null == pluginSimple:
			return

		pluginSimple.CallStatic("OpenWebBrowser", url);
