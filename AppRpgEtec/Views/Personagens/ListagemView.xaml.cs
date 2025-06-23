using AppRpgEtec.ViewModels.Personagens;

namespace AppRpgEtec.Views.Personagens;

public partial class ListagemView : ContentPage
{
	ListagemPersonagemViewModel viewModel	;	
	public ListagemView()
	{
		InitializeComponent();

		viewModel = new ListagemPersonagemViewModel();
		BindingContext = viewModel;
		Title = "Personagem - App Rpg Etec";
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
		_= viewModel.ObterPersonagens();
    }
}