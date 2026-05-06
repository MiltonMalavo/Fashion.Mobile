using System;
using System.Collections.ObjectModel;
using Fashion.Mobile.Models;

namespace Fashion.Mobile.Services;

public class CategoriaService : IBaseService<Categoria>
{
    public ObservableCollection<Categoria> GetAll()
    {
        return new ObservableCollection<Categoria>()
        {
            new Categoria(){Id = 1, Descricao = "All"},
            new Categoria(){Id = 2, Descricao = "Promo"},
            new Categoria(){Id = 3, Descricao = "Best Deals"},
            new Categoria(){Id = 4, Descricao = "Windy Basic"},
        };;
    }

    public Categoria GetById(int Id)
    {
        return GetAll().FirstOrDefault(x=>x.Id == Id);
    }
}
