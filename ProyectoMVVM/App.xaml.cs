using ProyectoMVVM.Services;
using ProyectoMVVM.Views;

namespace ProyectoMVVM
{
    public partial class App : Application
    {
        public static ProductoRepository ProductoRepository { get; set; }
        public App()
        {
            InitializeComponent();
            ProductoRepository = new ProductoRepository();
            MainPage = new NavigationPage(new ProductoPage());
        }
    }
}