import UnityEngine

class ModuleManagerBoo (MonoBehaviour): 
	module as IModuleNativeIndicatorBoo = null;
	
	def Start ():
		txt as TextMesh = null;
		
		if RuntimePlatform.Android == Application.platform:
    		module = ModuleNativeIndicatorBoo_Android()
    	if RuntimePlatform.IPhonePlayer == Application.platform:
    		module = ModuleNativeIndicatorBoo_iOS()
    	else:
    		module = ModuleNativeIndicatorBoo_Dummy()

		if null != module:
			module.Init()
			txt = GetComponent("TextMesh")
			txt.text += (module.GetName() + module.GetVersion())
		else:
			Debug.LogError("Can't Not Create Module")
	
	public def ShowNativeIndicator(bVisible as bool) as void:
		module.SetVisibleNativeIndicator( bVisible )
