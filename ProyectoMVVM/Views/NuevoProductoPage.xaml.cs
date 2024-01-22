using ProyectoMVVM.ViewModels;

namespace ProyectoMVVM.Views;

public partial class NuevoProductoPage : ContentPage
{
	public NuevoProductoPage()
	{
		InitializeComponent();
        BindingContext = new NuevoProductoViewModel();
    }
}