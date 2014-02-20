using UnityEngine;
using System.Collections;

public class GUIScriptWebBrowser : MonoBehaviour {
	WWW www = null;

	void OnGUI ()
	{
		float fPosX = 0, fPosY = 50, fYInterval = 100;
		int nYPosCount = 0;	

		// [C# -> C#] Change To Web page
		if (GUI.Button (new Rect (fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#->C#]Web View")) {
			CWSNativePluginMng.Instance().OpenEmbeddedWebPage("http://www.naver.com");
		}

		// [C# -> C#] Show On Web View
		nYPosCount++;
		if (GUI.Button(new Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[C#->C#]Web View(StreamAsset)")) {
			string url = Application.streamingAssetsPath + "/TestPage.html";
			if (Application.platform != RuntimePlatform.Android)
				url = "file://" + url;
			Debug.Log ("Get from : " + url);

			// Loading -> Need Decompressing
			www = new WWW (url);
			StartCoroutine (LoadAsset ());
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
