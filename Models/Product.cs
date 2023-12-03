using System;
using System.Collections.Generic;

namespace Test.Models;

public partial class Product
{
    public int Idproduct { get; set; }

    public string Nameproduct { get; set; } = null!;

    public decimal Price { get; set; }

    public string Imageurl { get; set; } = null!;

    public string? Introduction { get; set; }
}
