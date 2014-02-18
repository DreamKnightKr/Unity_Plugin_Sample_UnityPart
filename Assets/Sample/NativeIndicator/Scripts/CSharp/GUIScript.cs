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

	}

	IEnumerator OnEndOfShow()
	{
		yield return new WaitForSeconds(1.0f);

		{
			// Close...Indicator
			if (null != mngCSharp)
				mngCSharp.ShowNativeIndicator(false);
			if (null != mngBoo)
				mngBoo.ShowNativeIndicator(false);
		}
	}

	void OnGUI ()
	{
		float fPosX = 0, fPosY = 50, fYInterval = 100;
		int nYPosCount = 0;	

		// [C# -> C#] Call Class's Function With Dot Operation
		if (GUI.Button (new Rect (fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#->C#]Dot Oper.")) {
			mngCSharp = GameObject.Find("NativeModule_CSharp").GetComponent<ModuleManager>();
			mngCSharp.ShowNativeIndicator(true);

			StartCoroutine( OnEndOfShow() );
		}

		// [C# -> C#] Call Class's Function with SendMessage
		nYPosCount++;
		if (GUI.Button(new Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#->C#]SendMessage")) {
			mngCSharp = GameObject.Find("NativeModule_CSharp").GetComponent<ModuleManager>();
			mngCSharp.SendMessage("ShowNativeIndicator", true);

			StartCoroutine( OnEndOfShow() );
		}

		// [C# -> Boo] Call Class's Function With Dot Operation
		nYPosCount++;
		if (GUI.Button(new Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#->Boo]Dot Oper.")) {
			mngBoo = GameObject.Find("NativeModule_Boo").GetComponent<ModuleManagerBoo>();
			mngBoo.ShowNativeIndicator(true);

			StartCoroutine( OnEndOfShow() );
		}

		// [C# -> Boo] Call Class's Function with SendMessage
		nYPosCount++;
		if (GUI.Button(new Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#->Boo]SendMessage")) {
			mngBoo = GameObject.Find("NativeModule_Boo").GetComponent<ModuleManagerBoo>();
			mngBoo.SendMessage("ShowNativeIndicator", true);

			StartCoroutine( OnEndOfShow() );
		}
	}
}
