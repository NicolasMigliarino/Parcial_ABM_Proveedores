using System;
using System.Collections.Generic;

namespace Parcial_ABM_Proveedores.Models;

public partial class Proveedore
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public string? Ciudad { get; set; }

    public string? Pais { get; set; }

    public string? CodigoPostal { get; set; }

    public DateTime FechaRegistro { get; set; }

    public bool Activo { get; set; }
}
