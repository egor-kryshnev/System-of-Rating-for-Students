//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace students
{
    using System;
    using System.Collections.Generic;
    
    public partial class Groups
    {
        public int ID { get; set; }
        public int ID_Courses { get; set; }
        public int N_Group { get; set; }
    
        public virtual Courses Courses { get; set; }
    }
}
