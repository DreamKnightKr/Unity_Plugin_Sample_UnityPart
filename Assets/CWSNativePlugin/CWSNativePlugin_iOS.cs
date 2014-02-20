using UnityEngine;
using System.Collections;

public class CWSNativePlugin_iOS : CWSNativePlugin_Dummy {
#if UNITY_IPHONE
	public override void Init() {}
	public override string GetName()
	{
		return "iOS";
	}
	
	public override string GetVersion()
	{
		return "v1.0.0";
	}
#endif
}
