using ProyectoMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoMVVM.ViewModels
{
    public class EditarProductoViewModel
    {

        public Producto productoedit { get; set; }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
       
        public EditarProductoViewModel(Producto producto)
        {
            productoedit = App.ProductoRepository.Get(producto.IdProducto);
            IdProducto = producto.IdProducto;
            Nombre = producto.Nombre;
            Cantidad = producto.Cantidad;
            Descripcion = producto.Descripcion;
        }

        public ICommand GuardarCambios =>
            new Command(async () =>
            {
                Producto producto = new Producto
                {
                    IdProducto = IdProducto,
                    Nombre = Nombre,
                    Descripcion = Descripcion,
                    Cantidad = Cantidad
                };
                App.ProductoRepository.Update(producto);
                await App.Current.MainPage.Navigation.PopAsync();
            });
    }
}
