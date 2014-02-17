using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {
	ModuleManager mngCSharp = null;
	ModuleManagerBoo mngBoo = null;	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		OnPressKey();
	}

	void OnPressKey()
	{
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			// Close...Indicator
			if (null != mngCSharp)
				mngCSharp.ShowNativeIndicator(false);
			if (null != mngBoo)
				mngCSharp.ShowNativeIndicator(false);
		}
	}

	void OnGUI ()
	{
		float fPosX = 0, fPosY = 50, fYInterval = 100;
		int nYPosCount = 0;	

		// [C# -> C#] Call Class's Function With Dot Operation
		if (GUI.Button (new Rect (fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#]Indicator On")) {
			mngCSharp = GameObject.Find("NativeModule_CSharp").GetComponent<ModuleManager>();
			mngCSharp.ShowNativeIndicator(true);
		}

		// [C# -> C#] Call Class's Function with SendMessage
		nYPosCount++;
		if (GUI.Button(new Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#]Indicator On(2)")) {
			mngCSharp = GameObject.Find("NativeModule_CSharp").GetComponent<ModuleManager>();
			mngCSharp.SendMessage("ShowNativeIndicator", true);
		}

		// [C# -> Boo] Call Class's Function With Dot Operation
		nYPosCount++;
		if (GUI.Button(new Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#]Indicator On(3)")) {
			mngBoo = GameObject.Find("NativeModule_Boo").GetComponent<ModuleManagerBoo>();
			mngBoo.ShowNativeIndicator(true);
		}

		// [C# -> Boo] Call Class's Function with SendMessage
		nYPosCount++;
		if (GUI.Button(new Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#]Indicator On(4)")) {
			mngBoo = GameObject.Find("NativeModule_Boo").GetComponent<ModuleManagerBoo>();
			mngBoo.SendMessage("ShowNativeIndicator", true);
		}
	}
}
