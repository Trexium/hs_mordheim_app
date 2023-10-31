using HexedSceneryMordheimApp.ViewModels;

namespace HexedSceneryMordheimApp.Views;

public partial class PostBattleTablesView : ContentPage
{
	public PostBattleTablesView(PostBattleTablesModelView model)
	{
		BindingContext = model;
		InitializeComponent();
	}
}