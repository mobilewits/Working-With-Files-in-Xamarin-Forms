using System;
using System.IO;
using System.Reflection;


using Xamarin.Forms;

namespace WorkingwithFiles
{
	public class App : Application
	{
		public App ()
		{
			MainPage = new LoadAndSave ();
			// The root page of your application

//			var editor = new Label { Text = "loading...", HeightRequest = 300};
//
//			#region How to load a text file embedded resource
//			var assembly = typeof(App).GetTypeInfo().Assembly;
//			Stream stream = assembly.GetManifestResourceStream("WorkingwithFiles.PCLTextResource.txt");
//
//			string text = "";
//			using (var reader = new System.IO.StreamReader (stream)) {
//				text = reader.ReadToEnd ();
//			}
//			#endregion
//
//			editor.Text = text;
//
//
//
//			MainPage = new ContentPage {
//				Content = new StackLayout {
//					VerticalOptions = LayoutOptions.Center,
//					Children = {
//
//						new Label { Text = "Embedded Resource Text File (PCL)", 
//							Font = Font.BoldSystemFontOfSize (NamedSize.Medium)
//						}
//						, editor
//					}
//
//				}
//			};

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

