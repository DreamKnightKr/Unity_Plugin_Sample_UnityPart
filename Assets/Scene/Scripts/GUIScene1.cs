using UnityEngine;
using System.Collections;

public class GUIScene1 : MonoBehaviour {
	public GUIText txt;

	void OnGUI ()
	{
		float fPosX = 250, fPosY = 50, fYInterval = 80;
		int nYPosCount = 0;

		if (GUI.Button (new Rect (fPosX, fPosY + (fYInterval * nYPosCount), 200, 60), "Call Native Function")) {
			CWSNativePluginMng.Instance().CallSimpleFunction( OnEventNativeCalled );
		}

		nYPosCount +=2;
		if (GUI.Button (new Rect (fPosX, fPosY + (fYInterval * nYPosCount), 200, 60), "Scene2 >")) {
			Application.LoadLevel("Scene2");
		}
	}

	void OnEventNativeCalled(string arg)
	{
		txt.text = "Return : " + arg;
	}
}
