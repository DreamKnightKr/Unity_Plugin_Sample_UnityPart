using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI ()
	{
		float fPosX = 250, fPosY = 50, fYInterval = 120;
		int nYPosCount = 0;	

		if (GUI.Button (new Rect (fPosX, fPosY + (fYInterval * nYPosCount), 200, 100), "Indicator On/Off")) {
			ModuleManager mng = GameObject.Find("NativeModule").GetComponent<ModuleManager>();

			// C#과 Boo 둘다 사용하기 위해서 함수를 직접 호출하지 않는다.
			mng.ShowNativeIndicator();
		}
	}
}
