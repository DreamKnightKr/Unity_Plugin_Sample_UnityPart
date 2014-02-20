using UnityEngine;
using System.Collections;

public class GUIScene3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI ()
	{
		float fPosX = 250, fPosY = 50, fYInterval = 80;
		int nYPosCount = 0;
		
		if (GUI.Button (new Rect (fPosX, fPosY + (fYInterval * nYPosCount), 200, 60), "...")) {
			
		}
		
		nYPosCount +=2;
		if (GUI.Button (new Rect (fPosX, fPosY + (fYInterval * nYPosCount), 200, 60), "< Scene2")) {
			Application.LoadLevel("Scene2");
		}
	}
}
