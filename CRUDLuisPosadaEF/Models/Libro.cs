using System;
using System.Collections.Generic;

namespace CRUDLuisPosadaEF.Models;

public partial class Libro
{
    public string Isbn { get; set; } = null!;

    public string Titulo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateOnly? Publicacion { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public int? CodigoCategoria { get; set; }

    public int? NitEditorial { get; set; }

    public virtual Categoria? Codigo { get; set; }

    public virtual ICollection<LibrosAutor> LibrosAutors { get; set; } = new List<LibrosAutor>();

    public virtual Editoriale? Nit { get; set; }
}
