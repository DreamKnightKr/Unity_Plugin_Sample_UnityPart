using UnityEngine;
using System.Collections;

public class GUIScriptWebBrowser : MonoBehaviour {
	ModuleManagerWebBrowser mngCSharp = null;
	ModuleManagerWebBrowserBoo mngBoo = null;	

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
		if (GUI.Button (new Rect (fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#->C#]Web page")) {
			mngCSharp = GameObject.Find("NativeModule_CSharp").GetComponent<ModuleManagerWebBrowser>();
			mngCSharp.OpenWebPage("http://www.naver.com");
		}

		// [C# -> C#] Show On Web View
		nYPosCount++;
		if (GUI.Button(new Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#->C#]Web View")) {
			mngCSharp = GameObject.Find("NativeModule_CSharp").GetComponent<ModuleManagerWebBrowser>();
			mngCSharp.OpenEmbeddedWebPage("http://www.naver.com");
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
}
