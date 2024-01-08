using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gimnasio_Brothers.Models;

public partial class ProductosVentum
{
    public int Idproductos { get; set; }

    public int Idprovedores { get; set; }

    public string Nombre { get; set; }

    public decimal PrecioUnitario { get; set; }

    public int Cantidad { get; set; }

    public int IdcategoriaProducto { get; set; }
    [DataType(DataType.Date)]
    public DateOnly FechaCaducidad { get; set; }

    public virtual CategoriaProducto IdcategoriaProductoNavigation { get; set; }

    public virtual Proveedore IdprovedoresNavigation { get; set; }
}
