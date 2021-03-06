﻿using Advisor.Properties;
using GalaSoft.MvvmLight;

namespace HDT.Plugins.Advisor.Layout
{
	public class SettingsViewModel : ViewModelBase
	{
		//private SettingsScreenshotViewModel _screenshotSettings;

		//public SettingsScreenshotViewModel ScreenshotSettings
		//{
		//	get { return _screenshotSettings; }
		//	set { Set(() => ScreenshotSettings, ref _screenshotSettings, value); }
		//}

		//private SettingsArchetypeViewModel _archetypeSettings;

		//public SettingsArchetypeViewModel ArchetypeSettings
		//{
		//	get { return _archetypeSettings; }
		//	set { Set(() => ArchetypeSettings, ref _archetypeSettings, value); }
		//}

		private Settings _settings;

		public Settings Settings
		{
			get { return _settings; }
			set { Set(() => Settings, ref _settings, value); }
		}

		public SettingsViewModel()
		{
			//ScreenshotSettings = new SettingsScreenshotViewModel();
			//ArchetypeSettings = new SettingsArchetypeViewModel();
			Settings = Settings.Default;
		}
	}
}