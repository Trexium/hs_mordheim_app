using HexedSceneryMordheimApp.ViewModels;

namespace HexedSceneryMordheimApp.Views;

public partial class EncountersView : ContentPage
{
	public EncountersView(EncountersViewModel model)
	{
		BindingContext = model;
		InitializeComponent();
	}
}