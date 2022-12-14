//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pjrFormula_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.PilotCars = new HashSet<PilotCar>();
        }
    
        public int id { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public int unit { get; set; }
        public int id_team { get; set; }
    
        public virtual Team Team { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PilotCar> PilotCars { get; set; }

        public override string ToString()
        {
            return $"Id: {this.id}\n" +
                $" Modelo: {this.model}\n" +
                $" Ano: {this.year}\n" +
                $" Unidade: {this.unit}\n" +
                $"{this.Team.ToString()}\n".ToString();
        }
    }
}
