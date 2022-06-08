using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Dz_16_TextRiderMemento
{
    class Originator
    { 
        private string _state;

        public Originator(string state)
        {
            _state = state;
            Console.WriteLine("Originator: My initial state is: " + state);
        }
         
        public void DoSomething(string s)
        { 
            _state = s; 
        } 
         
        public IMemento Save()
        {
            return new ConcreteMemento(_state);
        }
         
        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento)) 
                throw new Exception("Unknown memento class " + memento.ToString()); 

            _state = memento.GetState();
            Console.Write($"Originator: My state has changed to: {_state}");
        }
    }
}