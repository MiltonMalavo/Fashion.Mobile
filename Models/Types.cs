using System;

namespace Fashion.Mobile.Models;

public class Types
{
    public string Descricao { get; set; } = string.Empty;
    public string Imagem { get; set; } = string.Empty;
    public Color CorDeCima { get; set; }
    public Color CorDeBaixo { get; set; }
}
