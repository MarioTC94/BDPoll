using System;
using System.Collections.Generic;

namespace Model {
      
    public class States{
        
        public States(){
            this.City = new HashSet<City>();
            this.Direccion = new HashSet<Direccion>();
        }
    
        public int IDState { get; set; }
        public string NameState { get; set; }
        public int IDCountry { get; set; }
        public bool Active { get; set; }
    
        public virtual ICollection<City> City { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Direccion> Direccion { get; set; }
    }
}
