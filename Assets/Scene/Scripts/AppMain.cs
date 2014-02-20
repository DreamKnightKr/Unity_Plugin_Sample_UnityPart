using UnityEngine;
using System.Collections;

public class AppMain : MonoBehaviour {
	public GameObject objNativeModuleMng;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (objNativeModuleMng);

		Application.LoadLevel ("Scene1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
