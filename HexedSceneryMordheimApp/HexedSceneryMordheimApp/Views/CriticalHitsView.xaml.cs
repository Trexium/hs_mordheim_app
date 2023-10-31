using HexedSceneryMordheimApp.ViewModels;

namespace HexedSceneryMordheimApp.Views;

public partial class CriticalHitsView : ContentPage
{
	public CriticalHitsView(CriticalHitsViewModel model)
	{
		BindingContext = model;
		InitializeComponent();
	}
}