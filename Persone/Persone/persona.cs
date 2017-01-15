using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persone
{
    class persona
    {
        private string _nome;
        public string nome { get; set; }
    

        private string _cognome;
        public string cognome { get; set; }
    

        private int _anni;
        public int anni
        {
            set
            {
                if (value < 1) value = 1;
                _anni = value;
            }
            get
            { return _anni; } 
            
        }

        private string _codicefiscale;
        public string codicefiscale
        {
            get { return _codicefiscale; }
        }

        public persona(string nome, string cognome, int anni)
        {
            _nome = nome;

            _cognome = cognome;

            _anni = anni;

        }

        public string describe()
        {
            string output = "Nome: " + nome + "/r/n";
            output += "Cognome: " + cognome + "/r/n";
            output += "Anni: " + anni + "/r/n";

            return output;
        } 

               
          
    
    }
}
