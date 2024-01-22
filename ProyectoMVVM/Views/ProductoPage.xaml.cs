using ProyectoMVVM.Model;
using ProyectoMVVM.ViewModels;

namespace ProyectoMVVM.Views;

public partial class ProductoPage : ContentPage
{
	private readonly ProductoViewModel _productoViewModel;
	public ProductoPage()
	{
		InitializeComponent();
        _productoViewModel = new ProductoViewModel();
		BindingContext = _productoViewModel;

    }
    protected override void OnAppearing()
    {
		base.OnAppearing();
		_productoViewModel.CargarDatos();
    }

    private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		if (e.SelectedItem is Producto producto)
		{
			(BindingContext as ProductoViewModel)?.OnClickShowDetails.Execute(producto);
		}
	}
}