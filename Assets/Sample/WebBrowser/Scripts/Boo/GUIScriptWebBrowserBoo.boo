import UnityEngine
import System.Collections

class GUIScriptWebBrowserBoo (MonoBehaviour): 
	mngCSharp as ModuleManagerWebBrowser = null;
	mngBoo as ModuleManagerWebBrowserBoo = null;
		
	def Start ():
		pass
	
	def Update ():
		pass
		
	def OnGUI() as void:
		
		fPosX as double = 250
		fPosY as double = 50
		fYInterval as double = 100
		nYPosCount as int = 0
		/*
		// [Boo -> C#] Call Class's Function With Dot Operation
		if GUI.Button(Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[Boo->C#]Dot Oper."):
			mngCSharp = GameObject.Find("NativeModule_CSharp").GetComponent("ModuleManagerWebBrowser")
			mngCSharp.OpenWebPage("http://www.naver.com")

		// [Boo -> C#] Call Class's Function with SendMessage
		nYPosCount++
		if GUI.Button(Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[Boo->C#]SendMessage"):
			mngCSharp = GameObject.Find("NativeModule_CSharp").GetComponent("ModuleManagerWebBrowser")
			mngCSharp.SendMessage("OpenWebPage", "http://www.naver.com")
			
		// [Boo -> Boo] Call Class's Function With Dot Operation
		nYPosCount++
		if GUI.Button(Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[Boo->Boo]Dot Oper."):
			mngBoo = GameObject.Find("NativeModule_Boo").GetComponent("ModuleManagerWebBrowserBoo")
			mngBoo.OpenWebPage("http://www.naver.com")
			
		// [Boo -> Boo] Call Class's Function with SendMessage
		nYPosCount++
		if GUI.Button(Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[Boo->Boo]SendMessage"):
			mngBoo = GameObject.Find("NativeModule_Boo").GetComponent("ModuleManagerWebBrowserBoo")
			mngBoo.SendMessage("OpenWebPage", "http://www.naver.com")

*/