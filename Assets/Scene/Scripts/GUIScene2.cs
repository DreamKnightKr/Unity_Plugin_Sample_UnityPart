using UnityEngine;
using System.Collections;

public class GUIScene2 : MonoBehaviour {
	WWW www = null;

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
		
		if (GUI.Button (new Rect (fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "Web View")) {
			CWSNativePluginMng.Instance().OpenEmbeddedWebPage("http://www.google.com");
		}
		
		nYPosCount++;
		if (GUI.Button(new Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "Web View(StreamAsset)")) {
			string url = Application.streamingAssetsPath + "/TestPage.html";
			if (Application.platform != RuntimePlatform.Android)
				url = "file://" + url;
			Debug.Log ("Get from : " + url);
			
			// Loading -> Need Decompressing
			www = new WWW (url);
			StartCoroutine (LoadAsset ());
		}
		
		nYPosCount +=2;
		if (GUI.Button (new Rect (fPosX, fPosY + (fYInterval * nYPosCount), 200, 60), "< Scene1")) {
			Application.LoadLevel("Scene1");
		}
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
			CWSNativePluginMng.Instance().OpenEmbeddedWebPageData(System.Text.Encoding.UTF8.GetString (www.bytes));
			Debug.Log ("Load Done -> " + System.Text.Encoding.UTF8.GetString (www.bytes));
		}
		
		yield return null;
	}
}
