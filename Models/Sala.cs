using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gimnasio_Brothers.Models;

public partial class Sala
{
    public int Idsala { get; set; }
    [DataType(DataType.Date)]
    public DateOnly Dia { get; set; }

    public int Cupo { get; set; }

    public string Descripción { get; set; }

    public virtual ICollection<Clase> Clases { get; set; } = new List<Clase>();
}
