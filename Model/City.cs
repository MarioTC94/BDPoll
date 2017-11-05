using System;
using System.Collections.Generic;

namespace Model{
    
    public class City{
       
        public City(){
            this.Direccion = new HashSet<Direccion>();
        }
    
        public int IDCity { get; set; }
        public string NameCity { get; set; }
        public int IDState { get; set; }
        public bool Active { get; set; }

        public virtual States States { get; set; }
        public virtual ICollection<Direccion> Direccion { get; set; }
    }
}
