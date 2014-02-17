using UnityEngine;
using System.Collections;

public class ModuleNativeIndicator_iOS : IModuleNativeIndicator {

	public void Init() {}
	public  string GetName()
	{
		return "iOS";
	}
	
	public string GetVersion()
	{
		return "v1.0.0";
	}

	public void SetVisibleNativeIndicator(bool bVisible)
	{
	}
}
