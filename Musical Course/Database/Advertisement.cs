//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Musical_Course.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Advertisement
    {
        public int AdvertisementId { get; set; }
        public int TypeAdvertisement { get; set; }
        public int Representative { get; set; }
        public Nullable<int> Area { get; set; }
        public Nullable<int> Group { get; set; }
        public int Moderation { get; set; }
    
        public virtual Areas Areas { get; set; }
        public virtual Groups Groups { get; set; }
        public virtual TypeAdvertisement TypeAdvertisement1 { get; set; }
        public virtual Users Users { get; set; }
    }
}
