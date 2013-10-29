using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class cambio
    {
        
        public double pesosdolar(string peso,string valordolar)
        {
         
             double pesoconbertido;
             double dolarconbertido;



             if (Double.TryParse(peso, out pesoconbertido) && Double.TryParse(valordolar, out dolarconbertido))
             {
                 return (pesoconbertido / dolarconbertido);
             
             }

            return (0);



        }

        public bool validar(string peso, string valordolar)
        {

            double pesoconbertido;
            double dolarconbertido;



            if (Double.TryParse(peso, out pesoconbertido) && Double.TryParse(valordolar, out dolarconbertido))
            {
            return (true);

            }

            return (false);



        }
                       
    
    
    




    }
}
