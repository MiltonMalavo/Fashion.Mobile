using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Fashion.Mobile.ViewModels;

public partial class DetalhesViewModels:ObservableObject
{
    public Product Product {get;set;} = new();
    private ProdutoService _produtoService;
    public DetalhesViewModels()
    {
        _produtoService = new ProdutoService();
        Product = null;
        int id = Preferences.Get("id", 0);
        Product = _produtoService.GetById(id);
    }

    [RelayCommand]
    public async Task BackHome()
    {
        await Shell.Current.GoToAsync("..", animate: true);
    }

}
