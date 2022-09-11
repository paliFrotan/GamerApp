using System;

namespace GamerService
{
    
    public class Gamer
    {
        public string Name;
        //private int _age;
        /*public int Age 
        { 
            get 
            { 
                return _age; 
            }
        }*/
        public int Age { get; private set; }

        public Gamer(int age)
        {
            //_age = 27;
            //_age = age;
            Age = age;
        }
        public string playAGame(string game)
        {
            return "";
        }
    }
}
