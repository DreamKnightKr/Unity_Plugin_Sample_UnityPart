import UnityEngine

class ModuleNativeIndicatorBoo_Dummy (IModuleNativeIndicatorBoo): 
	
	public def Init() as void :
		pass
		
	public def GetName() as string :
		return "Dummy"

	public def GetVersion() as string :
		return "v1.0.0"

	public def SetVisibleNativeIndicator(bVisible as bool) as void:
		pass
