//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LufthavnsAssignment
{
    using System;
    using System.Collections.Generic;
    
    public partial class Airport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Airport()
        {
            this.Routes = new HashSet<Route>();
        }
    
        public string Name { get; set; }
        public string IATACode { get; set; }
        public string stateCode { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    
        public virtual Route Route { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Route> Routes { get; set; }
    }
}