using UnityEngine;
using System.Collections;

public class ModuleManager : MonoBehaviour
{
	IModuleNativeIndicator module = null;
	bool m_bVisibleIndicator = false;

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

	public void ShowNativeIndicator()
	{
		module.SetVisibleNativeIndicator( true );
	}
}
