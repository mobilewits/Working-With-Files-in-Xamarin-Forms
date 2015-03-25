using System;
using System.Runtime;
using Xamarin.Forms;
using System.Collections.Generic;



[assembly: Dependency (typeof ())]

namespace WorkingwithFiles
{
	public class LoadAndSave : ILoadAndSave
	{
		public LoadAndSave ()
		{
			var input = new Editor { Text = "" };
			if (Device.OS == TargetPlatform.iOS)
				input.HeightRequest = 40;

			var output = new Label { Text = "" };
			var saveButton = new Button {Text = "Save"};
			saveButton.Clicked += (sender, e) => {

				System.Diagnostics.Debug.WriteLine(input.Text);

				DependencyService.Get<ILoadAndSave>().SaveText("input.txt", input.Text.ToString());
			};
			var loadButton = new Button {Text = "Load"};
			loadButton.Clicked += (sender, e) => {
				output.Text = DependencyService.Get<ILoadAndSave>().LoadText("input.txt");
			};
			var buttonLayout = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Children = { saveButton, loadButton }
			};

			Content = new StackLayout {
				Padding = new Thickness (0,20,0,0),
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children = {
					new Label { Text = "Save and Load Text (PCL)", Font = Font.BoldSystemFontOfSize(NamedSize.Medium)},
					new Label { Text = "Type below and press Save, then Load" },
					input,
					buttonLayout,
					//System.Diagnostics.Debug.WriteLine(input.Text)

				


				} 
			};
					
		}





	}

}






