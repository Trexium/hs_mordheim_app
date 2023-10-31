using HexedSceneryMordheimApp.ViewModels;

namespace HexedSceneryMordheimApp.Views;

public partial class CombatTablesView : ContentPage
{
	public CombatTablesView(CombatTablesViewModel model)
	{
		BindingContext = model;
		InitializeComponent();
	}
}