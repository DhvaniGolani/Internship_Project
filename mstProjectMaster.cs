//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project2021
{
    using System;
    using System.Collections.Generic;
    
    public partial class mstProjectMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mstProjectMaster()
        {
            this.mstMailMatrices = new HashSet<mstMailMatrix>();
        }
    
        public int Id { get; set; }
        public string Project_code { get; set; }
        public string Project_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mstMailMatrix> mstMailMatrices { get; set; }
    }
}
