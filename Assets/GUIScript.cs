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
		float fPosX = 250, fPosY = 50, fYInterval = 40;
		int nYPosCount = 0;	

		if (GUI.Button (new Rect (fPosX, fPosY + (fYInterval * nYPosCount), 200, 30), "Indicator On/Off")) {
			ModuleManager mng = GameObject.Find("NativeModule").GetComponent<ModuleManager>();
			mng.ShowNativeIndicator();
		}
	}
}
