using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Fashion.Mobile.Models;
using Fashion.Mobile.Services;
namespace Fashion.Mobile.ViewModels;

public partial class HomeViewModels:ObservableObject
{
    public ObservableCollection<Types> Tipos { get; set; } = new();
    public ObservableCollection<Marcas> Marcas { get; set; } = new();
    public ObservableCollection<Categoria> Categorias { get; set; } = new();
    public ObservableCollection<Product> Products { get; set; } = new();
    
    private CategoriaService _categoriaService;
    private MarcaService _marcaService;
    private TiposService _tiposService;
    private ProdutoService _produtoService;

    public Categoria CategoriaSelecionada{get;set;} = new();
    public HomeViewModels()
    {
        _categoriaService = new();
        _marcaService = new();
        _tiposService = new();
        _produtoService = new ();
        Tipos = _tiposService.GetAll();
        Marcas = _marcaService.GetAll();
        Categorias = _categoriaService.GetAll();
        var products = _produtoService.GetAll().Take(4).ToList();
        Products = new  ObservableCollection<Product>(products);
        CategoriaSelecionada = _categoriaService.GetById(1);
      
    }

    [RelayCommand]
    public async Task SeeAllProducts()
    {
        await Shell.Current.GoToAsync(nameof(PopularPage), animate: true);
    }

    [RelayCommand]
    public async Task CategoriaSelect()
    {
        Products.Clear();
        if (CategoriaSelecionada.Id != 1)
        {
            var products = _produtoService.GetAll().Where(x=>x.Categoria.Id == CategoriaSelecionada.Id).Take(4).ToList();
            foreach (var item in products)
                Products.Add(item);
        }
        else
        {
            var products = _produtoService.GetAll().Take(4).ToList();
            foreach (var item in products)
                Products.Add(item);
        }
    }

}
