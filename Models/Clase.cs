using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gimnasio_Brothers.Models;

public partial class Clase
{
    public int Idclase { get; set; }

    public int Idmatricula { get; set; }

    public int Idactividad { get; set; }

    public int Idempleado { get; set; }

    public int Idsala { get; set; }
    [DataType(DataType.Date)]
    public DateOnly FechaClase { get; set; }
    [DataType(DataType.Date)]
    public TimeOnly HoraInicio { get; set; }
    [DataType(DataType.Time)]
    public TimeOnly HoraFin { get; set; }
    [DataType(DataType.Time)]
    public bool Estado { get; set; }

    public int Capacidad { get; set; }

    public virtual Actividade IdactividadNavigation { get; set; }

    public virtual Empleado IdempleadoNavigation { get; set; }

    public virtual Martricula IdmatriculaNavigation { get; set; }

    public virtual Sala IdsalaNavigation { get; set; }
}
