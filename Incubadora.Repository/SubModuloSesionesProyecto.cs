
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Incubadora.Repository
{

using System;
    using System.Collections.Generic;
    
public partial class SubModuloSesionesProyecto
{

    public string IdProyecto { get; set; }

    public Nullable<int> IdSesion { get; set; }

    public Nullable<System.DateTime> DteFechaInicio { get; set; }

    public Nullable<System.DateTime> DteFechaTermino { get; set; }

    public string StrAsunto { get; set; }

    public string StrDescripcion { get; set; }

    public string StrColorTema { get; set; }

    public Nullable<int> IdStatus { get; set; }



    public virtual Sesiones Sesiones { get; set; }

    public virtual Status Status { get; set; }

    public virtual Proyectos Proyectos { get; set; }

}

}
