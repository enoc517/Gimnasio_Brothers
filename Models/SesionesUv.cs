using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gimnasio_Brothers.Models;

public partial class SesionesUv
{
    public int Idsesiones { get; set; }

    public int IdclienteMembresia { get; set; }

    public int CantidadSesiones { get; set; }
    [DataType(DataType.Date)]
    public DateOnly FechaSesion { get; set; }
    [DataType(DataType.Time)]
    public TimeOnly HoraSesion { get; set; }

    public int Disponibles { get; set; }

    public virtual ClienteMembresium IdclienteMembresiaNavigation { get; set; }
}
