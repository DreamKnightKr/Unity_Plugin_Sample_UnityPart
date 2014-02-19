import UnityEngine

class ModuleManagerWebBrowserBoo (MonoBehaviour): 
	module as IModuleWebBrowserBoo = null;
	
	def Start ():
		txt as TextMesh = null;
		
		if RuntimePlatform.Android == Application.platform:
    		module = ModuleWebBrowserBoo_Android()
    	elif RuntimePlatform.IPhonePlayer == Application.platform:
    		module = ModuleWebBrowserBoo_iOS()
    	else:
    		module = ModuleWebBrowserBoo_Dummy()

		if null != module:
			module.Init()
			txt = GetComponent("TextMesh")
			txt.text += (module.GetName() + module.GetVersion())
		else:
			Debug.LogError("Can't Not Create Module")
	
	public def OpenWebPage(url as string) as void:
		module.OpenWebPage( url )
