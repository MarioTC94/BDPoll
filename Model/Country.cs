using System;
using System.Collections.Generic;

namespace Model{
      
    public class Country{
        
        public Country(){
            this.States = new HashSet<States>();
            this.Direccion = new HashSet<Direccion>();
        }
    
        public int IDCountry { get; set; }
        public string SortName { get; set; }
        public string NameCountry { get; set; }
        public int PhoneCode { get; set; }
        public bool Active { get; set; }
        
        public virtual ICollection<States> States { get; set; }      
        public virtual ICollection<Direccion> Direccion { get; set; }
    }
}
