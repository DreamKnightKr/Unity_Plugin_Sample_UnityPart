import UnityEngine

class GUIScriptBoo (MonoBehaviour): 
	mngCSharp as ModuleManager = null;
	mngBoo as ModuleManagerBoo = null;
		
	def Start ():
		pass
	
	def Update ():
		OnPressKey()

	def OnPressKey():
		if Input.GetKeyUp(KeyCode.Escape):
			// Close...Indicator
			if (null != mngCSharp):
				mngCSharp.ShowNativeIndicator(false)
			if (null != mngBoo):
				mngCSharp.ShowNativeIndicator(false)
		
	def OnGUI() as void:
		
		fPosX as double = 250
		fPosY as double = 50
		fYInterval as double = 100
		nYPosCount as int = 0

		// [Boo -> C#] Call Class's Function With Dot Operation
		if GUI.Button(Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[Boo]Indicator On(1)"):
			mngCSharp = GameObject.Find("NativeModule_CSharp").GetComponent("ModuleManager")
			mngCSharp.ShowNativeIndicator(true)

		// [Boo -> C#] Call Class's Function with SendMessage
		nYPosCount++
		if GUI.Button(Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[Boo]Indicator On(2)"):
			mngCSharp = GameObject.Find("NativeModule_CSharp").GetComponent("ModuleManager")
			mngCSharp.SendMessage("ShowNativeIndicator", true)
			
		// [Boo -> Boo] Call Class's Function With Dot Operation
		nYPosCount++
		if GUI.Button(Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[Boo]Indicator On(3)"):
			mngBoo = GameObject.Find("NativeModule_Boo").GetComponent("ModuleManagerBoo")
			mngBoo.ShowNativeIndicator(true)
			
		// [Boo -> Boo] Call Class's Function with SendMessage
		nYPosCount++
		if GUI.Button(Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[Boo]Indicator On(4)"):
			mngBoo = GameObject.Find("NativeModule_Boo").GetComponent("ModuleManagerBoo")
			mngBoo.SendMessage("ShowNativeIndicator", true)
