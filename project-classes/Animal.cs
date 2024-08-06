using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project_classes
{
    internal class Animal
    {

        protected string Species = "Meil";

        public Animal() {

           
        }

        public string GetSpecies()
        {
            return Species;
        }
    }

    internal class Dog : Animal
    {

        public Dog() 
        {
           
             Species = GetSpecies();
            
        }
    }

}


