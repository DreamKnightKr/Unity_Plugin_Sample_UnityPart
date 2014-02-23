interface IModuleWebBrowserBoo : 
	
	def Init()
	def GetName() as string
	def GetVersion() as string

	def OpenWebPage(url as string) as void
