import UnityEngine

class ModuleWebBrowserBoo_Dummy (IModuleWebBrowserBoo): 
	
	public virtual def Init() as void :
		pass
		
	public virtual def GetName() as string :
		return "Dummy"

	public virtual def GetVersion() as string :
		return "v1.0.0"

	public virtual def OpenWebPage(url as string) as void:
		pass
