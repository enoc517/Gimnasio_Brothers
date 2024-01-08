using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gimnasio_Brothers.Models;

public partial class Pedido
{
    public int Idpedido { get; set; }

    public int Idempleado { get; set; }

    public int Idprovedores { get; set; }

    public string Estado { get; set; }
    [DataType(DataType.Date)]
    public DateOnly FechaCompra { get; set; }
    [DataType(DataType.Date)]
    public DateOnly FechaRecibido { get; set; }
    [DataType(DataType.Date)]
    public int Cantidad { get; set; }

    public virtual Empleado IdempleadoNavigation { get; set; }

    public virtual Proveedore IdprovedoresNavigation { get; set; }
}
