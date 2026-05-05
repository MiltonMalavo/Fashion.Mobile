using System;
using System.Collections.ObjectModel;
using Fashion.Mobile.Models;

namespace Fashion.Mobile.Services;

public class TiposService : IBaseService<Types>
{
    public ObservableCollection<Types> GetAll()
    {
                return new ObservableCollection<Types>
        {
            new Types
            {
                Descricao = "Best Value",
                Imagem = "shirt.png",
                CorDeCima = Color.FromArgb("#FB8989"),
                CorDeBaixo = Color.FromArgb("#EEBBBC")
            },
            new Types
            {
                Descricao = "Flash",
                Imagem = "pants.png",
                CorDeCima = Color.FromArgb("#FD6894"),
                CorDeBaixo = Color.FromArgb("#EFB4C8")
            },
            new Types
            {
                Descricao = "Gift",
                Imagem = "shoes.png",
                CorDeCima = Color.FromArgb("#539DF8"),
                CorDeBaixo = Color.FromArgb("#93BFF1")
            },
            new Types
            {
                Descricao = "Cupon",
                Imagem = "accessories.png",
                CorDeCima = Color.FromArgb("#5FA3F9"),
                CorDeBaixo = Color.FromArgb("#ADCFF1")
            },
            new Types
            {
                Descricao = "VIP area",
                Imagem = "accessories.png",
                CorDeCima = Color.FromArgb("#F0D394"),
                CorDeBaixo = Color.FromArgb("#FEBE4D")
            }
        };
    }

    public Types GetById(int Id)
    {
        throw new NotImplementedException();
    }
}
