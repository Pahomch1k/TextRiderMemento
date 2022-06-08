using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_16_TextRiderMemento
{
    class ConcreteMemento : IMemento
    {
        private string _state; 

        public ConcreteMemento(string state)
        {
            _state = state; 
        } 

        public string GetState() => _state;
         
        public string GetName() => $"{_state}\n"; 
    }
}
