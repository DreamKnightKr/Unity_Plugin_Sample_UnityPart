public interface IModuleWebBrowser {

	void Init();
	string GetName();
	string GetVersion();

	void OpenWebPage(string url);
}
