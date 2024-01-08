using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gimnasio_Brothers.Models;

public partial class ClienteMembresium
{
    public int IdclienteMembresia { get; set; }

    public int IdcategoraMembresia { get; set; }

    public int Idcliente { get; set; }
    [DataType(DataType.Date)]
    public DateOnly FechaProxRenovacion { get; set; }
    [DataType(DataType.Date)]
    public DateOnly FechaInicio { get; set; }
    [DataType(DataType.Date)]
    public DateOnly FechaFin { get; set; }
    [DataType(DataType.Date)]
    public virtual ICollection<FacturaCliente> FacturaClientes { get; set; } = new List<FacturaCliente>();

    public virtual CategoriaMembresium IdcategoraMembresiaNavigation { get; set; }

    public virtual Cliente IdclienteNavigation { get; set; }

    public virtual ICollection<SesionesUv> SesionesUvs { get; set; } = new List<SesionesUv>();
}
