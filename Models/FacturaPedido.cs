using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gimnasio_Brothers.Models;

public partial class FacturaPedido
{
    public int IdfacturaPedidos { get; set; }

    public int IdDetalleFactura { get; set; }

    public int Idempleado { get; set; }
    [DataType(DataType.Date)]
    public DateOnly FechaPedido { get; set; }
    [DataType(DataType.Date)]
    public DateOnly FechaRecibido { get; set; }

    public virtual DetalleFactura IdDetalleFacturaNavigation { get; set; }

    public virtual Empleado IdempleadoNavigation { get; set; }
}
