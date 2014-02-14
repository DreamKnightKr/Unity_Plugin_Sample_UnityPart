using UnityEngine;
using System.Collections;

public class ModuleNativeIndicator_Dummy : IModuleNativeIndicator {

	public void Init() {}
	public string GetName()
	{
		return "Dummy";
	}

	public string GetVersion()
	{
		return "v1.0.0";
	}

	public void SetVisibleNativeIndicator(bool bVisible)
	{
	}
}
