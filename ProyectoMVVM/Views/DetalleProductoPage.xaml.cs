using ProyectoMVVM.Model;
using ProyectoMVVM.ViewModels;
using System.Security.Cryptography.X509Certificates;

namespace ProyectoMVVM.Views;

public partial class DetalleProductoPage : ContentPage
{
	private readonly DetalleProductoViewModel _viewModel;
	public DetalleProductoPage(Producto producto)
	{
		InitializeComponent();
		_viewModel = new DetalleProductoViewModel(producto);
		BindingContext = _viewModel;
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
		_viewModel.CargarNuevo();
    }
}