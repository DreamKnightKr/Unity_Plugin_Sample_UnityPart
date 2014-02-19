using UnityEngine;
using System.Collections;

public class ModuleWebBrowser_Dummy : IModuleWebBrowser {

	public void Init() {}
	public string GetName()
	{
		return "Dummy";
	}

	public string GetVersion()
	{
		return "v1.0.0";
	}

	public void OpenWebPage(string url)
	{
	}

	public void OpenEmbeddedWebPage(string url)
	{
	}

	public void OpenEmbeddedWebPageData(string data)
	{
	}
}
