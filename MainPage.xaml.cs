namespace ElementosDeMenu
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            listView.ItemsSource = ElementoTipoLista;
        }

        List<string> ElementoTipoLista = new List<string> 
        {
            "Elemento 1",
            "Elemento 2",
            "Elemento 3"
        };
        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            MenuItem elemento = sender as MenuItem;

            if(elemento?.BindingContext is string selectedItem)
            {
                DisplayAlert("Mensaje", $"Seleccionaste el elemento '{selectedItem}' de la lista", "Cancelar");
            }
        }
    }

}
