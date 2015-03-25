using System;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using Xamarin.Forms;





namespace WorkingwithFiles
{
	public class Displaytext : ContentPage
	{
		public Displaytext ()
		{

		
						var editor = new Label { Text = "loading...", HeightRequest = 300};

						#region How to load a text file embedded resource
					var assembly = typeof(Displaytext).GetTypeInfo().Assembly;
					Stream stream = assembly.GetManifestResourceStream("WorkingwithFiles.PCLTextResource.txt");

						string text = "";
						using (var reader = new System.IO.StreamReader (stream)) {
							text = reader.ReadToEnd ();
						}
						#endregion

						editor.Text = text;
						
						




						Content = new StackLayout {
							Padding = new Thickness (0,20,0,0),
							VerticalOptions = LayoutOptions.StartAndExpand,
							Children = {
								new Label { Text = "Embedded Resource Text File (PCL)", 
									Font = Font.BoldSystemFontOfSize(NamedSize.Medium) }
								, editor}
						};
					}
				}
			}





