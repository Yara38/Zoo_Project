//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zoo_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountingsSet
    {
        public int Id { get; set; }
        public Nullable<int> Balance { get; set; }
        public int IdAgent { get; set; }
        public int IdClient { get; set; }
        public int IdProduct { get; set; }
        public int IdSupplier { get; set; }
    
        public virtual AgentsSet AgentsSet { get; set; }
        public virtual ClientsSet ClientsSet { get; set; }
        public virtual ProductsSet ProductsSet { get; set; }
        public virtual SuppliersSet SuppliersSet { get; set; }
    }
}
