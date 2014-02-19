public interface IModuleWebBrowser {

	void Init();
	string GetName();
	string GetVersion();

	void OpenWebPage(string url);
	void OpenEmbeddedWebPage(string url);
	void OpenEmbeddedWebPageData(string data);
}
