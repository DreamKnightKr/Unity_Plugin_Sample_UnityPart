import UnityEngine

class ModuleWebBrowserBoo_Dummy (IModuleWebBrowserBoo): 
	
	public def Init() as void :
		pass
		
	public def GetName() as string :
		return "Dummy"

	public def GetVersion() as string :
		return "v1.0.0"

	public def OpenWebPage(url as string) as void:
		pass
