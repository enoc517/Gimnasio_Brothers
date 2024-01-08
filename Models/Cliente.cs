using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gimnasio_Brothers.Models;

public partial class Cliente
{
    public int Idcliente { get; set; }

    public string Nombre { get; set; }

    public string Apellidos { get; set; }

    public string Dirrecion { get; set; }
    [DataType(DataType.Date)]
    public DateOnly FechaNacimento { get; set; }

    public int Telefono { get; set; }

    public int Cedula { get; set; }

    public string EstadoCliente { get; set; }

    public string SesionesRayosUva { get; set; }

    public virtual ICollection<ClienteMembresium> ClienteMembresia { get; set; } = new List<ClienteMembresium>();

    public virtual ICollection<Martricula> Martriculas { get; set; } = new List<Martricula>();
}
