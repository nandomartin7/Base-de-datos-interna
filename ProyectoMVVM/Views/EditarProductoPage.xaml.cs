using ProyectoMVVM.Model;
using ProyectoMVVM.ViewModels;

namespace ProyectoMVVM.Views;

public partial class EditarProductoPage : ContentPage
{
	public EditarProductoPage(Producto producto)
	{
		InitializeComponent();
        BindingContext = new EditarProductoViewModel(producto);
    }
}