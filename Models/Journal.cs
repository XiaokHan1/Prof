//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProfRabot.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Journal
    {
        public int Id { get; set; }
        public int IdVagon { get; set; }
        public int IdRabota { get; set; }
        public System.DateTime DateAdd { get; set; }
        public System.DateTime DateEnd { get; set; }
    
        public virtual Rabota Rabota { get; set; }
        public virtual Vagon Vagon { get; set; }
    }
}
