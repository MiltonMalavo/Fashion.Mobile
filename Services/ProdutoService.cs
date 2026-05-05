using System;
using System.Collections.ObjectModel;
using Fashion.Mobile.Models;


namespace Fashion.Mobile.Services;

public class ProdutoService : IBaseService<Product>
{
    public ObservableCollection<Product> GetAll()
    {
        return new ObservableCollection<Product>()
        {
            new Product()
            {
                Id = 1,
                Nome ="Tape Trim Coat",
                Imagem ="",
                Preco = 200,
                PercetualDeconto = 0.4m,
                Avaliacao = 2.8m,
                Marca = new MarcaService().GetAll().FirstOrDefault(x=>x.Id == 1),
                Sizes = new List<Models.Size>()
                {
                    new Models.Size(){Id = 1,Descricao = "S"},
                    new Models.Size(){Id = 2,Descricao = "M"},
                    new Models.Size(){Id = 3,Descricao = "L"},
                    new Models.Size(){Id = 4,Descricao = "XL"},
                },
                Cors = new List<Cor>()
                {
                    new Models.Cor(){Id = 1, Descricao = Colors.Gray},
                    new Models.Cor(){Id = 2, Descricao = Colors.Black},
                    new Models.Cor(){Id = 3, Descricao = Colors.Brown},
                }
            }
        };
    }

    public Product GetById(int Id)
    {
        throw new NotImplementedException();
    }
}
