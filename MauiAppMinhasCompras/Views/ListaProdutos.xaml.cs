namespace MauiAppMinhasCompras.Views;

public partial class ListaProdutos : ContentPage
{
	public ListaProdutos()
	{
		InitializeComponent();
        lst_produtos.ItemsSource = new List<Models.Produto>() 
        {
            new Models.Produto() { Id = 1, Descricao = "Arroz", Quantidade = 2, Preço = 10.00 },
            new Models.Produto() { Id = 2, Descricao = "Feijão", Quantidade = 4, Preço = 8.00 },
            new Models.Produto() { Id = 3, Descricao = "Macarrão", Quantidade = 8, Preço = 5.00 },
            new Models.Produto() { Id = 4, Descricao = "Óleo", Quantidade = 5, Preço = 7.00 }
        };
    }

    private void Somar(object sender, EventArgs e)
    {

    }

    private void Adicionar(object sender, EventArgs e)
    {

    }

    private void txt_search_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void lst_produtos_Refreshing(object sender, EventArgs e)
    {

    }

    private void lst_produtos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

    }

    private void Remover(object sender, EventArgs e)
    {

    }
}