using PropertyChanged;
using ProyectoMVVM.Model;
using ProyectoMVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoMVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class DetalleProductoViewModel
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public Producto producto1 { get; set; }

        public DetalleProductoViewModel(Producto producto)
        {
            if (producto != null)
            {
                IdProducto = producto.IdProducto;
                Nombre = producto.Nombre;
                Cantidad = producto.Cantidad;
                Descripcion = producto.Descripcion;
                producto1 = producto;
            }
        }

        public async void CargarNuevo()
        {
            Producto producto2 = App.ProductoRepository.Get(producto1.IdProducto);
            IdProducto = producto2.IdProducto;
            Nombre = producto2.Nombre;
            Cantidad = producto2.Cantidad;
            Descripcion = producto2.Descripcion;
        }

        public ICommand EditarProducto =>
            new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new EditarProductoPage(producto1));
            });

        public ICommand EliminarProducto =>
            new Command(async () =>
            {
                App.ProductoRepository.Delete(producto1.IdProducto);
                await App.Current.MainPage.Navigation.PopAsync();
            });
    }
}