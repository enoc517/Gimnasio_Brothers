using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gimnasio_Brothers.Models;

public partial class FacturaCliente
{
    public int Idfactura { get; set; }

    public int IdclienteMembresia { get; set; }
    [DataType(DataType.Date)]
    public DateOnly FechaEmicion { get; set; }

    public string MetodoPago { get; set; }

    public virtual ClienteMembresium IdclienteMembresiaNavigation { get; set; }
}
