using UnityEngine;
using System.Collections;

public class CWSNativePlugin_iOS : CWSNativePlugin_Dummy {
#if UNITY_IPHONE
	GameObject obj = null;

	public override void Init() {}
	public override string GetName()
	{
		return "iOS";
	}
	
	public override string GetVersion()
	{
		return "v1.0.0";
	}

	public override void CallSimpleFunction (string name)
	{
		if (null != obj)
			return;

		obj = new GameObject ("WebViewiOS");
		WebViewBehavior webview = obj.AddComponent<WebViewBehavior>();

		if (webview != null)
			webview.SimpleFunction (name, "OnCalledSimpleFunction", "Native Return SomeString...");
	}

	public override void OpenEmbeddedWebPage(string url)
	{
		if (null != obj)
			return;
		
		obj = new GameObject ("WebViewiOS");
		WebViewBehavior webview = obj.AddComponent<WebViewBehavior>();

		if( webview != null )
		{
			webview.SetMargins(10, 400, 10, 10);
			webview.LoadURL( "https://www.google.co.jp" );
			webview.SetVisibility( true );
		}
	}
#endif
}
