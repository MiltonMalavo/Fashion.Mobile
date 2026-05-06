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
    public Categoria CategoriaSelecionada{get;set;} = new();
    public PopularProducViewModel()
    {
        _categoriaService = new();
        _produtoService = new ();
        Categorias = _categoriaService.GetAll();
        Products = _produtoService.GetAll();
        CategoriaSelecionada = _categoriaService.GetById(1);
    }

    [RelayCommand]
    public async Task BackHome()
    {
        await Shell.Current.GoToAsync("..", animate: true);
    }

    [RelayCommand]
    public async Task CategoriaSelect()
    {
        Products.Clear();
        if (CategoriaSelecionada.Id != 1)
        {
            var products = _produtoService.GetAll().Where(x=>x.Categoria.Id == CategoriaSelecionada.Id).ToList();
            foreach (var item in products)
                Products.Add(item);
        }
        else
        {
            var products = _produtoService.GetAll().ToList();
            foreach (var item in products)
                Products.Add(item);
        }
    }
}
