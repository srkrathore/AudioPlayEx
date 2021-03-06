﻿using System;

using Xamarin.Forms;

namespace AudioPlayEx
{
	public class App : Application
	{
		public App ()
		{
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Button {
							Text = "Play mp3 file",
							Command = new Command(() =>
								{
									DependencyService.Get<IAudio>().PlayAudioFile("MySong.mp3");
								})
						}
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

