using UnityEngine;
using System.Collections;

public class ModuleWebBrowser_Dummy : IModuleWebBrowser {

	public virtual void Init() {}
	public virtual string GetName()
	{
		return "Dummy";
	}

	public virtual string GetVersion()
	{
		return "v1.0.0";
	}

	public virtual void OpenWebPage(string url)
	{
	}

	public virtual void OpenEmbeddedWebPage(string url)
	{
	}

	public virtual void OpenEmbeddedWebPageData(string data)
	{
	}
}
