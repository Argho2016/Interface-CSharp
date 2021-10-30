using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass
{
    class Employee : Person
    {
       
        private string id;
        

        public void setId(string id)
        {
            this.id = id;
        }

        
       


        public string getId()
        {
            return id;
        }
    }
}
