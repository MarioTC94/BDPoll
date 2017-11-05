using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic {
    public class Prueba {
        public bool OpenConnection() {
            return new Data.clsConnection().OpenConnection();
        }
    }
}
