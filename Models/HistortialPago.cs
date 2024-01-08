using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gimnasio_Brothers.Models;

public partial class HistortialPago
{
    public int IdhistorialPago { get; set; }

    public int IdgeneracionPagos { get; set; }
    [DataType(DataType.Date)]
    public DateOnly FechaPago { get; set; }

    public decimal MontoTotal { get; set; }

    public virtual GeneracionPago IdgeneracionPagosNavigation { get; set; }
}
