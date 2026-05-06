using System;

namespace Fashion.Mobile.Models;

public class Product
{
    public int Id{get;set;}
    public string Nome{get;set;} = string.Empty;
    public string Descricao{get;set;} = string.Empty;
    public string Imagem{get;set;} = string.Empty;
    public decimal Preco{get;set;}
    public decimal PercetualDeconto{get;set;}
    public decimal PrecoDesconto => Preco*PercetualDeconto;
    public decimal Avaliacao{get;set;}
    public Categoria Categoria {get;set;}
    public Marcas? Marca {get;set;}
    public List<Size>? Sizes{get;set;}
    public List<Cor>? Cors{get;set;}

}
