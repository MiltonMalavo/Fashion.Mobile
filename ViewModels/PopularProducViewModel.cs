using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Fashion.Mobile.ViewModels;

public partial class PopularProducViewModel:ObservableObject
{
    public ObservableCollection<Categoria> Categorias { get; set; } = new();
    public ObservableCollection<Product> Products { get; set; } = new();
    private CategoriaService _categoriaService;
    private ProdutoService _produtoService;
    public PopularProducViewModel()
    {
        _categoriaService = new();
        _produtoService = new ();
        Categorias = _categoriaService.GetAll();
        Products = _produtoService.GetAll();
    }

    [RelayCommand]
    public async Task BackHome()
    {
        await Shell.Current.GoToAsync("..", animate: true);
    }
}
