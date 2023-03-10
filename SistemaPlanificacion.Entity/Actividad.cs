using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class Actividad
{
    public string IdActividad { get; set; } = null!;

    public string? NombreActividad { get; set; }

    public bool? EsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<DocmPlanificacion> DocmPlanificacions { get; } = new List<DocmPlanificacion>();

    public virtual ICollection<Planificacion> Planificacions { get; } = new List<Planificacion>();

    public virtual ICollection<Presupuesto> Presupuestos { get; } = new List<Presupuesto>();
}
