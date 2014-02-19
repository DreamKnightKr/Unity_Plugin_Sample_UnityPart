using UnityEngine;
using System.Collections;

public class GUIScriptWebBrowser : MonoBehaviour {
	ModuleManagerWebBrowser mngCSharp = null;
	ModuleManagerWebBrowserBoo mngBoo = null;
	WWW www = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI ()
	{
		float fPosX = 0, fPosY = 50, fYInterval = 100;
		int nYPosCount = 0;	

		// [C# -> C#] Change To Web page
		if (GUI.Button (new Rect (fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#->C#]Web View")) {
			mngCSharp = GameObject.Find("NativeModule_CSharp").GetComponent<ModuleManagerWebBrowser>();
			mngCSharp.OpenEmbeddedWebPage("http://www.naver.com");
		}

		// [C# -> C#] Show On Web View
		nYPosCount++;
		if (GUI.Button(new Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#->C#]Web View(StreamAsset)")) {
			mngCSharp = GameObject.Find("NativeModule_CSharp").GetComponent<ModuleManagerWebBrowser>();

			string url = Application.streamingAssetsPath + "/TestPage.html";
			if (Application.platform != RuntimePlatform.Android)
				url = "file://" + url;
			Debug.Log ("Get from : " + url);

			// Loading -> Need Decompressing
			www = new WWW (url);
			StartCoroutine (LoadAsset ());
		}
		/*
		// [C# -> Boo] Call Class's Function With Dot Operation
		nYPosCount++;
		if (GUI.Button(new Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#->Boo]Dot Oper.")) {
			mngBoo = GameObject.Find("NativeModule_Boo").GetComponent<ModuleManagerWebBrowserBoo>();
			mngBoo.OpenWebPage("http://www.naver.com");
		}

		// [C# -> Boo] Call Class's Function with SendMessage
		nYPosCount++;
		if (GUI.Button(new Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#->Boo]SendMessage")) {
			mngBoo = GameObject.Find("NativeModule_Boo").GetComponent<ModuleManagerWebBrowserBoo>();
			mngBoo.SendMessage("OpenWebPage", "http://www.naver.com");
		}
		*/
	}

	IEnumerator LoadAsset ()
	{
		while (!www.isDone) {
			yield return new WaitForSeconds (0.1f);
		}
		
		if (null != www.error)
			Debug.LogError ("Can't Load from StreamAsset!! \n" + www.error);
		else {
			// Byte Stream -> String
			mngCSharp.OpenEmbeddedWebPageData(System.Text.Encoding.UTF8.GetString (www.bytes));
			Debug.Log ("Load Done -> " + System.Text.Encoding.UTF8.GetString (www.bytes));
		}
		
		yield return null;
	}
}
