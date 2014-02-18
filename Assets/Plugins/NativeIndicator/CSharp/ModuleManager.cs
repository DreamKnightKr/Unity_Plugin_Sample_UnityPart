using UnityEngine;
using System.Collections;

public class ModuleManager : MonoBehaviour
{
	IModuleNativeIndicator module = null;

	void Start()
	{
		switch(Application.platform)
		{
		case RuntimePlatform.Android:
			module = new ModuleNativeIndicator_Android();
			break;
		case RuntimePlatform.IPhonePlayer:
			module = new ModuleNativeIndicator_iOS();
			break;
		default:
			module = new ModuleNativeIndicator_Dummy();
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

	public void ShowNativeIndicator(bool bVisible)
	{
		Debug.Log("[ModuleManager]Call SetVisibleNativeIndicator");
		module.SetVisibleNativeIndicator( bVisible );
	}
}
