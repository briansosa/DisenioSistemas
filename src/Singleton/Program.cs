using System;

namespace Singleton
{
    class Client
    {
        static void Main(string[] args)
        {
            Static instance1 = Static.Instance();
            instance1.name = "Brian";
            instance1.lastname = "Sosa";
            instance1.age = 24;
            instance1.dni = 1234567890;
            Console.WriteLine("Instance 1 info:" + Environment.NewLine + 
            instance1.ToString());
            Static instance2 = Static.Instance();
            instance1.age = 50;
            instance1.dni = 1111111111;
            Console.WriteLine("Instance 2 info:" + Environment.NewLine + 
            instance1.ToString());
        }
    }

    public class Static{
        private static Static instance = null;
        public String name {get; set; }
        public String lastname {get; set; }
        public int age {get; set; }
        public int dni {get; set; }
        private Static(){
        }
        public static Static Instance(){
            if (instance == null){
                instance = new Static();
            }

            return instance;
        }

        public override string ToString(){
            return String.Format("" +
            "Nombre: {0}" + Environment.NewLine + 
            "Apellido:{1}" + Environment.NewLine +
            "Edad:{2}" + Environment.NewLine +
            "DNI:{3}" + Environment.NewLine,
            this.name, this.lastname, this.age, this.dni);
        }
    }
}
