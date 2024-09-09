using Microsoft.AspNetCore.Components.WebView.Maui;

namespace TabIssueRedrect.Components.Pages;

public partial class NewPage2 : ContentPage
{
	public NewPage2(string name)
	{
		InitializeComponent();
        // Pass the parameter to the Blazor component


        weatherRoot.Parameters = new Dictionary<string, object>()
          {
                {"FromWhichPage",name }
           };

    }
}