using UnityEngine;
using System.Collections;

public class ModuleManagerWebBrowser : MonoBehaviour
{
	IModuleWebBrowser module = null;

	void Start()
	{
		switch(Application.platform)
		{
		case RuntimePlatform.Android:
			module = new ModuleWebBrowser_Android();
			break;
		case RuntimePlatform.IPhonePlayer:
			module = new ModuleWebBrowser_iOS();
			break;
		default:
			module = new ModuleWebBrowser_Dummy();
			break;
		}

		if(null != module)
		{
			module.Init();
			GetComponent<TextMesh>().text += (module.GetName() + module.GetVersion());
		}
		else
			Debug.LogError("Can't Not Create Module");
	}

	public void OpenWebPage(string url)
	{
		Debug.Log("[ModuleManager]Call OpenWebPage");
		module.OpenWebPage( url );
	}

	public void OpenEmbeddedWebPage(string url)
	{
		Debug.Log("[ModuleManager]Call OpenEmbeddedWebPage");
		module.OpenEmbeddedWebPage( url );
	}

	public void OpenEmbeddedWebPageData(string data)
	{
		Debug.Log("[ModuleManager]Call OpenEmbeddedWebPageData");
		module.OpenEmbeddedWebPageData( data );
	}
}
