//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COGERTI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CentroDeCusto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CentroDeCusto()
        {
            this.Funcionario = new HashSet<Funcionario>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public Nullable<int> GestorUPI { get; set; }
        public Nullable<int> CoordenadorUPI { get; set; }
    
        public virtual Funcionario CoordenadorCC { get; set; }
        public virtual Funcionario GestorCC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funcionario> Funcionario { get; set; }
    }
}