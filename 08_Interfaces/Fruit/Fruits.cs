using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    public class Banana : IFruit
    {
        //contructors
        public Banana() { }
        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        //Properties
        public string Name
        {
            get
            {
                return "Banana";
            }
        }

        public bool IsPeeled { get; private set; }

        //Class Method
        public string peel()
        {
            IsPeeled = true;
            return "You peeled the banana";
        }
    }

    public class Orange : IFruit
    {
        //Constructors

        public Orange() { }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public string Name
        {
            get
            {
                return "Orange";
            }
        }
        public bool IsPeeled { get; private set; }

        // USe the same interface methos but bodies can be diferent as long as the return type matches 
        public string peel()
        {
            if (IsPeeled)
            {
                return "It's already peeled";
            }
            else
            {
                IsPeeled = true;
                return "You peeled the orange";
            }
        }

        // Classes that use interfaces can still have unique properties and methods
        public string Squeeze()
        {
            return "You squeezed the orange, and juice comes out";
        }
    }

    public class Grape : IFruit
    {
        public string Name
        {
            get
            {
                return "Grape";
            }
        }

        //Hardsetting proerty as false
        public bool IsPeeled { get; } = false;

        public string peel()
        {
            return "Who peels grapes?";
        }
    }

    //Make an apple class inheriting from IFruit

    public class Apple : IFruit
    {
        // lamda functionm 'phat arrow'
        public string Name => "Apple";
 
        public bool IsPeeled { get; private set; }

        public string peel()
        {
            if (IsPeeled)
            {
                return "It's already peeled";
            }
            else
            {
                IsPeeled = true;
                return "you peeled the apple";
            }
        }
    }
}
