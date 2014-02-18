import UnityEngine
import System.Collections

class GUIScriptBoo (MonoBehaviour): 
	mngCSharp as ModuleManager = null;
	mngBoo as ModuleManagerBoo = null;
		
	def Start ():
		pass
	
	def Update ():
		pass

	def OnEndOfShow() as IEnumerator:
		yield WaitForSeconds(1.0f)
				
		// Close...Indicator
		if (null != mngCSharp):
			mngCSharp.ShowNativeIndicator(false)
		if (null != mngBoo):
			mngBoo.ShowNativeIndicator(false)
		
	def OnGUI() as void:
		
		fPosX as double = 250
		fPosY as double = 50
		fYInterval as double = 100
		nYPosCount as int = 0

		// [Boo -> C#] Call Class's Function With Dot Operation
		if GUI.Button(Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[Boo->C#]Dot Oper."):
			mngCSharp = GameObject.Find("NativeModule_CSharp").GetComponent("ModuleManager")
			mngCSharp.ShowNativeIndicator(true)
			
			StartCoroutine( OnEndOfShow() )

		// [Boo -> C#] Call Class's Function with SendMessage
		nYPosCount++
		if GUI.Button(Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[Boo->C#]SendMessage"):
			mngCSharp = GameObject.Find("NativeModule_CSharp").GetComponent("ModuleManager")
			mngCSharp.SendMessage("ShowNativeIndicator", true)
			
			StartCoroutine( OnEndOfShow() )
			
		// [Boo -> Boo] Call Class's Function With Dot Operation
		nYPosCount++
		if GUI.Button(Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[Boo->Boo]Dot Oper."):
			mngBoo = GameObject.Find("NativeModule_Boo").GetComponent("ModuleManagerBoo")
			mngBoo.ShowNativeIndicator(true)
			
			StartCoroutine( OnEndOfShow() )
			
		// [Boo -> Boo] Call Class's Function with SendMessage
		nYPosCount++
		if GUI.Button(Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 80), "[Boo->Boo]SendMessage"):
			mngBoo = GameObject.Find("NativeModule_Boo").GetComponent("ModuleManagerBoo")
			mngBoo.SendMessage("ShowNativeIndicator", true)
			
			StartCoroutine( OnEndOfShow() )
