﻿public interface IModuleNativeIndicator {

	void Init();
	string GetName();
	string GetVersion();

	void SetVisibleNativeIndicator(bool bVisible);
}