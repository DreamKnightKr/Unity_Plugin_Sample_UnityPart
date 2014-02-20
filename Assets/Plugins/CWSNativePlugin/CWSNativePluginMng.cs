using UnityEngine;
using System.Collections;

public class CWSNativePluginMng : MonoBehaviour, ICWSNativePluginHandler
{
	public delegate void eventDelegate(string arg);
	public event eventDelegate onEvent;

	static CWSNativePluginMng _Instance = null;
	
	public static CWSNativePluginMng Instance()
	{
		return _Instance;
	}

	ICWSNativePlugin module = null;

	void Start()
	{
		_Instance = this;

		switch(Application.platform)
		{
		case RuntimePlatform.Android:
			module = new CWSNativePlugin_Android();
			break;
		case RuntimePlatform.IPhonePlayer:
			module = new CWSNativePlugin_iOS();
			break;
		default:
			module = new CWSNativePlugin_Dummy();
			break;
		}

		if(null != module)
		{
			module.Init();
		}
		else
			Debug.LogError("Can't Not Create Module");
	}

	public void CallSimpleFunction(eventDelegate onEvent)
	{
		if (null == module)
			return;

		this.onEvent = onEvent;

		Debug.Log("[CWSNativePluginMng]Call CallSimpleFunction");
		module.CallSimpleFunction (gameObject.name);
	}

	public void OnCalledSimpleFunction (string arg)
	{
		this.onEvent(arg);
	}

	public void OpenWebPage(string url)
	{
		if (null == module)
			return;

		Debug.Log("[CWSNativePluginMng]Call OpenWebPage");
		module.OpenWebPage( url );
	}

	public void OpenEmbeddedWebPage(string url)
	{
		if (null == module)
			return;

		Debug.Log("[CWSNativePluginMng]Call OpenEmbeddedWebPage");
		module.OpenEmbeddedWebPage( url );
	}

	public void OpenEmbeddedWebPageData(string data)
	{
		if (null == module)
			return;

		Debug.Log("[CWSNativePluginMng]Call OpenEmbeddedWebPageData");
		module.OpenEmbeddedWebPageData( data );
	}
}
