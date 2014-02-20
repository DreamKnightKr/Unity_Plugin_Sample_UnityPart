public interface ICWSNativePlugin {

	void Init();
	string GetName();
	string GetVersion();

	void CallSimpleFunction (string name);

	void OpenWebPage(string url);
	void OpenEmbeddedWebPage(string url);
	void OpenEmbeddedWebPageData(string data);
}

public interface ICWSNativePluginHandler {
	void OnCalledSimpleFunction (string arg);
}
