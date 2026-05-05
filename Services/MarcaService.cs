using System;
using System.Collections.ObjectModel;
using Fashion.Mobile.Models;

namespace Fashion.Mobile.Services;

public class MarcaService : IBaseService<Marcas>
{
    public ObservableCollection<Marcas> GetAll()
    {
        return new ObservableCollection<Marcas>()
        {
            new Marcas(){Id = 1, Descricao = "Nike", Imagem="notification.png"},
            new Marcas(){Id = 2, Descricao = "Adidas", Imagem="notification.png"},
            new Marcas(){Id = 3, Descricao = "Puma", Imagem="notification.png"},
            new Marcas(){Id = 4, Descricao = "Chanel", Imagem="notification.png"},
            new Marcas(){Id = 5, Descricao = "DJI", Imagem="notification.png"}
        };
    }

    public Marcas GetById(int Id)
    {
        throw new NotImplementedException();
    }
}
