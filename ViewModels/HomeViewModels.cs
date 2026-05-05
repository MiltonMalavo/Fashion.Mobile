using System;
using System.Collections.ObjectModel;
using Fashion.Mobile.Models;
using Fashion.Mobile.Services;
namespace Fashion.Mobile.ViewModels;

public class HomeViewModels
{
    public ObservableCollection<Types> Tipos { get; set; } = new();
    public ObservableCollection<Marcas> Marcas { get; set; } = new();
    public ObservableCollection<Categoria> Categorias { get; set; } = new();
    public ObservableCollection<Product> Products { get; set; } = new();
    private CategoriaService _categoriaService;
    private MarcaService _marcaService;
    private TiposService _tiposService;
    private ProdutoService _produtoService;
    public HomeViewModels()
    {
        _categoriaService = new();
        _marcaService = new();
        _tiposService = new();
        _produtoService = new ();
        Tipos = _tiposService.GetAll();
        Marcas = _marcaService.GetAll();
        Categorias = _categoriaService.GetAll();
        Products = _produtoService.GetAll();
    }


}
