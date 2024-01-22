using ProyectoMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ProyectoMVVM.Views;
using System.Collections.ObjectModel;
using PropertyChanged;

namespace ProyectoMVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ProductoViewModel
    {
        public ObservableCollection<Producto> ListaProductos { get; set; }
        public ProductoViewModel() 
        {
            CargarDatos();
        }

        public async void CargarDatos()
        {
            ListaProductos = new ObservableCollection<Producto>(App.ProductoRepository.GetAll());
        }
        

        public ICommand CrearProducto =>
            new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new NuevoProductoPage());
            });

        public ICommand OnClickShowDetails =>
            new Command<Producto>(async (producto) =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new DetalleProductoPage(producto));
            });
    }
}
