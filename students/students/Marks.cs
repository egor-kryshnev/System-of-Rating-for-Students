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
    
    public partial class Marks
    {
        public int ID { get; set; }
        public int ID_Student { get; set; }
        public int ID_Objects { get; set; }
        public int Mark { get; set; }
    
        public virtual Objects Objects { get; set; }
        public virtual Student Student { get; set; }
    }
}
