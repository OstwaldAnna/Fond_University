//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fond63.DataBases
{
    using System;
    using System.Collections.Generic;
    
    public partial class UnifercityFacultyRoom
    {
        public int Id { get; set; }
        public Nullable<int> IdUnifersity { get; set; }
        public Nullable<int> IdFaculty { get; set; }
        public Nullable<int> IdRoom { get; set; }
    
        public virtual Faculty Faculty { get; set; }
        public virtual Room Room { get; set; }
        public virtual Unifercity Unifercity { get; set; }
    }
}