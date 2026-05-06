using System;
using System.Collections.ObjectModel;
using Fashion.Mobile.Models;


namespace Fashion.Mobile.Services;

public class ProdutoService : IBaseService<Product>
{
  public ObservableCollection<Product> GetAll()
    {
        var marcas = new MarcaService().GetAll();

        return new ObservableCollection<Product>()
        {
            new Product
            {
                Id = 1,
                Nome = "Tape Trim Coat",
                Descricao = "Modern coat with tape trim detailing, designed for a refined urban look.",
                Imagem = "coat1.png",
                Preco = 200,
                PercetualDeconto = 0.40m,
                Avaliacao = 2.8m,
                Marca = marcas.First(x => x.Id == 1),
                Categoria = new CategoriaService().GetById(1),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Gray, Colors.Black, Colors.Brown)
            },

            new Product
            {
                Id = 2,
                Nome = "Winter Puffer Jacket",
                Descricao = "Insulated puffer jacket designed to provide maximum warmth during cold winter days.",
                Imagem = "coat2.png",
                Preco = 180,
                PercetualDeconto = 0.25m,
                Avaliacao = 4.5m,
                Marca = marcas.First(x => x.Id == 2),
                Categoria = new CategoriaService().GetById(2),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Blue, Colors.Black, Colors.White, Colors.Red)
            },

            new Product
            {
                Id = 3,
                Nome = "Classic Wool Overcoat",
                Descricao = "Timeless wool overcoat crafted for elegance and formal winter styling.",
                Imagem = "coat3.png",
                Preco = 250,
                PercetualDeconto = 0.15m,
                Avaliacao = 4.0m,
                Marca = marcas.First(x => x.Id == 3),
                Categoria = new CategoriaService().GetById(3),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Brown, Colors.Black, Colors.DarkGray)
            },

            new Product
            {
                Id = 4,
                Nome = "Urban Street Jacket",
                Descricao = "Casual street jacket built for everyday comfort and modern urban style.",
                Imagem = "coat4.png",
                Preco = 150,
                PercetualDeconto = 0.30m,
                Avaliacao = 3.9m,
                Marca = marcas.First(x => x.Id == 4),
                Categoria = new CategoriaService().GetById(1),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Green, Colors.Black, Colors.Gray, Colors.White)
            },

            new Product
            {
                Id = 5,
                Nome = "Slim Fit Tailored Coat",
                Descricao = "Tailored slim-fit coat designed to enhance a sharp and elegant silhouette.",
                Imagem = "coat5.png",
                Preco = 220,
                PercetualDeconto = 0.20m,
                Avaliacao = 4.3m,
                Marca = marcas.First(x => x.Id == 5),
                Categoria = new CategoriaService().GetById(2),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Black, Colors.Navy, Colors.Gray)
            },

            new Product
            {
                Id = 6,
                Nome = "Vintage Leather Jacket",
                Descricao = "Premium leather jacket with a vintage design and strong character.",
                Imagem = "coat6.png",
                Preco = 300,
                PercetualDeconto = 0.10m,
                Avaliacao = 4.7m,
                Marca = marcas.First(x => x.Id == 1),
                Categoria = new CategoriaService().GetById(3),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Black, Colors.Brown, Colors.Red, Colors.Gray)
            },

            new Product
            {
                Id = 7,
                Nome = "Denim Rider Jacket",
                Descricao = "Classic denim jacket with a modern twist for casual everyday wear.",
                Imagem = "coat7.png",
                Preco = 140,
                PercetualDeconto = 0.35m,
                Avaliacao = 3.5m,
                Marca = marcas.First(x => x.Id == 2),
                Categoria = new CategoriaService().GetById(1),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Blue, Colors.LightBlue, Colors.Gray)
            },

            new Product
            {
                Id = 8,
                Nome = "Hooded Arctic Parka",
                Descricao = "Heavy-duty parka with hood, built for extreme cold weather conditions.",
                Imagem = "coat8.png",
                Preco = 210,
                PercetualDeconto = 0.18m,
                Avaliacao = 4.2m,
                Marca = marcas.First(x => x.Id == 3),
                Categoria = new CategoriaService().GetById(2),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Green, Colors.Black, Colors.Brown, Colors.Gray)
            },

            new Product
            {
                Id = 9,
                Nome = "Minimalist Long Coat",
                Descricao = "Clean and minimalist long coat designed for a refined modern style.",
                Imagem = "coat9.png",
                Preco = 190,
                PercetualDeconto = 0.22m,
                Avaliacao = 3.8m,
                Marca = marcas.First(x => x.Id == 4),
                Categoria = new CategoriaService().GetById(3),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.White, Colors.Black, Colors.Gray)
            },

            new Product
            {
                Id = 10,
                Nome = "Luxury Double Breasted Coat",
                Descricao = "Premium double-breasted coat designed for a sophisticated luxury appearance.",
                Imagem = "coat10.png",
                Preco = 350,
                PercetualDeconto = 0.12m,
                Avaliacao = 4.9m,
                Marca = marcas.First(x => x.Id == 5),
                Categoria = new CategoriaService().GetById(1),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Beige, Colors.Brown, Colors.Black, Colors.White)
            },

            new Product
            {
                Id = 11,
                Nome = "Thermal Insulated Jacket",
                Descricao = "Lightweight thermal jacket designed for optimal insulation and comfort.",
                Imagem = "coat1.png",
                Preco = 210,
                PercetualDeconto = 0.28m,
                Avaliacao = 4.1m,
                Marca = marcas.First(x => x.Id == 1),
                Categoria = new CategoriaService().GetById(2),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Black, Colors.Gray, Colors.Blue)
            },

            new Product
            {
                Id = 12,
                Nome = "Feather Down Coat",
                Descricao = "Ultra-light down coat offering superior warmth and softness.",
                Imagem = "coat2.png",
                Preco = 170,
                PercetualDeconto = 0.50m,
                Avaliacao = 3.7m,
                Marca = marcas.First(x => x.Id == 2),
                Categoria = new CategoriaService().GetById(3),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Red, Colors.Black, Colors.White, Colors.Gray)
            },

            new Product
            {
                Id = 13,
                Nome = "Heritage Wool Coat",
                Descricao = "Classic heritage wool coat with premium craftsmanship and timeless design.",
                Imagem = "coat3.png",
                Preco = 260,
                PercetualDeconto = 0.33m,
                Avaliacao = 4.6m,
                Marca = marcas.First(x => x.Id == 3),
                Categoria = new CategoriaService().GetById(4),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Brown, Colors.Black, Colors.Beige)
            },

            new Product
            {
                Id = 14,
                Nome = "Lightweight Windbreaker",
                Descricao = "Breathable windbreaker ideal for outdoor activities and light weather protection.",
                Imagem = "coat4.png",
                Preco = 155,
                PercetualDeconto = 0.08m,
                Avaliacao = 3.2m,
                Marca = marcas.First(x => x.Id == 4),
                Categoria = new CategoriaService().GetById(2),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Green, Colors.White, Colors.Black, Colors.Gray)
            },

            new Product
            {
                Id = 15,
                Nome = "Premium Cashmere Coat",
                Descricao = "Luxurious cashmere coat offering unmatched softness and elegance.",
                Imagem = "coat5.png",
                Preco = 230,
                PercetualDeconto = 0.60m,
                Avaliacao = 4.8m,
                Marca = marcas.First(x => x.Id == 5),
                Categoria = new CategoriaService().GetById(4),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Navy, Colors.Black, Colors.Gray)
            },

            new Product
            {
                Id = 16,
                Nome = "Structured Blazer Coat",
                Descricao = "Structured coat blending blazer sophistication with outerwear functionality.",
                Imagem = "coat6.png",
                Preco = 310,
                PercetualDeconto = 0.18m,
                Avaliacao = 4.4m,
                Marca = marcas.First(x => x.Id == 1),
                Categoria = new CategoriaService().GetById(1),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Black, Colors.Red, Colors.Brown, Colors.Gray)
            },

            new Product
            {
                Id = 17,
                Nome = "Casual Zip Jacket",
                Descricao = "Everyday casual jacket with zip closure and comfortable fit.",
                Imagem = "coat7.png",
                Preco = 145,
                PercetualDeconto = 0.27m,
                Avaliacao = 3.6m,
                Marca = marcas.First(x => x.Id == 2),
                Categoria = new CategoriaService().GetById(4),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Blue, Colors.LightBlue, Colors.White)
            },

            new Product
            {
                Id = 18,
                Nome = "Outdoor Expedition Coat",
                Descricao = "Durable expedition coat built for outdoor adventures and harsh conditions.",
                Imagem = "coat8.png",
                Preco = 205,
                PercetualDeconto = 0.41m,
                Avaliacao = 4.0m,
                Marca = marcas.First(x => x.Id == 3),
                Categoria = new CategoriaService().GetById(3),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Green, Colors.Black, Colors.Gray, Colors.Brown)
            },

            new Product
            {
                Id = 19,
                Nome = "Modern Fit Overcoat",
                Descricao = "Modern fit overcoat designed for a sleek and contemporary appearance.",
                Imagem = "coat9.png",
                Preco = 195,
                PercetualDeconto = 0.19m,
                Avaliacao = 3.9m,
                Marca = marcas.First(x => x.Id == 4),
                Categoria = new CategoriaService().GetById(4),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.White, Colors.Black, Colors.Gray)
            },

            new Product
            {
                Id = 20,
                Nome = "Executive Long Coat",
                Descricao = "Executive-style long coat crafted for a professional and elegant look.",
                Imagem = "coat10.png",
                Preco = 360,
                PercetualDeconto = 0.14m,
                Avaliacao = 4.9m,
                Marca = marcas.First(x => x.Id == 5),
                Categoria = new CategoriaService().GetById(2),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Beige, Colors.Black, Colors.Brown, Colors.White)
            },

            new Product
            {
                Id = 21,
                Nome = "Soft Shell Jacket",
                Descricao = "Flexible soft shell jacket offering comfort and weather resistance.",
                Imagem = "coat1.png",
                Preco = 180,
                PercetualDeconto = 0.05m,
                Avaliacao = 3.5m,
                Marca = marcas.First(x => x.Id == 3),
                Categoria = new CategoriaService().GetById(3),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Black, Colors.Gray, Colors.Blue)
            },

            new Product
            {
                Id = 22,
                Nome = "All Weather Coat",
                Descricao = "Versatile coat designed to perform in all weather conditions.",
                Imagem = "coat2.png",
                Preco = 200,
                PercetualDeconto = 0.45m,
                Avaliacao = 4.2m,
                Marca = marcas.First(x => x.Id == 1),
                Categoria = new CategoriaService().GetById(1),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Red, Colors.Black, Colors.White, Colors.Gray)
            },

            new Product
            {
                Id = 23,
                Nome = "Signature Wool Jacket",
                Descricao = "Signature wool jacket combining tradition with modern tailoring.",
                Imagem = "coat3.png",
                Preco = 240,
                PercetualDeconto = 0.38m,
                Avaliacao = 4.6m,
                Marca = marcas.First(x => x.Id == 2),
                Categoria = new CategoriaService().GetById(2),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Brown, Colors.Black, Colors.Beige)
            },

            new Product
            {
                Id = 24,
                Nome = "Rainproof Urban Coat",
                Descricao = "Water-resistant urban coat designed for rainy city days.",
                Imagem = "coat4.png",
                Preco = 160,
                PercetualDeconto = 0.12m,
                Avaliacao = 3.4m,
                Marca = marcas.First(x => x.Id == 4),
                Categoria = new CategoriaService().GetById(3),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Green, Colors.White, Colors.Black, Colors.Gray)
            },

            new Product
            {
                Id = 25,
                Nome = "Elegant Evening Coat",
                Descricao = "Elegant coat designed for formal evening occasions.",
                Imagem = "coat5.png",
                Preco = 220,
                PercetualDeconto = 0.52m,
                Avaliacao = 4.7m,
                Marca = marcas.First(x => x.Id == 5),
                Categoria = new CategoriaService().GetById(1),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Navy, Colors.Black, Colors.Gray)
            },

            new Product
            {
                Id = 26,
                Nome = "Classic Buttoned Overcoat",
                Descricao = "Traditional buttoned overcoat with a timeless elegant style.",
                Imagem = "coat6.png",
                Preco = 310,
                PercetualDeconto = 0.09m,
                Avaliacao = 4.3m,
                Marca = marcas.First(x => x.Id == 1),
                Categoria = new CategoriaService().GetById(2),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Black, Colors.Red, Colors.Brown, Colors.Gray)
            },

            new Product
            {
                Id = 27,
                Nome = "Urban Explorer Jacket",
                Descricao = "Functional urban jacket designed for exploration and daily use.",
                Imagem = "coat7.png",
                Preco = 150,
                PercetualDeconto = 0.29m,
                Avaliacao = 3.6m,
                Marca = marcas.First(x => x.Id == 2),
                Categoria = new CategoriaService().GetById(3),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Blue, Colors.LightBlue, Colors.White)
            },

            new Product
            {
                Id = 28,
                Nome = "Heavy Duty Parka",
                Descricao = "Heavy-duty insulated parka built for extreme winter protection.",
                Imagem = "coat8.png",
                Preco = 210,
                PercetualDeconto = 0.34m,
                Avaliacao = 4.1m,
                Marca = marcas.First(x => x.Id == 3),
                Categoria = new CategoriaService().GetById(1),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Green, Colors.Black, Colors.Gray, Colors.Brown)
            },

            new Product
            {
                Id = 29,
                Nome = "Refined Minimal Coat",
                Descricao = "Minimalist coat designed with refined clean aesthetics.",
                Imagem = "coat9.png",
                Preco = 190,
                PercetualDeconto = 0.21m,
                Avaliacao = 3.9m,
                Marca = marcas.First(x => x.Id == 4),
                Categoria = new CategoriaService().GetById(2),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.White, Colors.Black, Colors.Gray)
            },

            new Product
            {
                Id = 30,
                Nome = "Premium Winter Trench",
                Descricao = "Premium trench coat designed for warmth, elegance, and winter sophistication.",
                Imagem = "coat10.png",
                Preco = 350,
                PercetualDeconto = 0.17m,
                Avaliacao = 4.8m,
                Marca = marcas.First(x => x.Id == 5),
                Categoria = new CategoriaService().GetById(3),
                Sizes = GetSizes(),
                Cors = GetColors(Colors.Beige, Colors.Black, Colors.Brown, Colors.White)
            }
        };
    }

    private List<Models.Size> GetSizes()
    {
        return new List<Models.Size>()
        {
            new Models.Size { Id = 1, Descricao = "S" },
            new Models.Size { Id = 2, Descricao = "M" },
            new Models.Size { Id = 3, Descricao = "L" },
            new Models.Size { Id = 4, Descricao = "XL" }
        };
    }

    private List<Cor> GetColors(params Color[] colors)
    {
        return colors.Select((c, i) => new Cor
        {
            Id = i + 1,
            Descricao = c
        }).ToList();
    }

    public Product GetById(int Id)
    {
        throw new NotImplementedException();
    }
}
