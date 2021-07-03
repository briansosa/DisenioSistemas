using System;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Si la longitud de los datos a comprimir es menor o igual a 10 utilizamos Tar
            IComponente componente1 = Creator.MakeComponent("1234567890");
            componente1.Comprimir();

            Console.WriteLine();

            // Si la longitud de los datos a comprimir es mayor a 10 e menor o igual a 20 utilizamos Rar
            IComponente componente2 = Creator.MakeComponent("12345678901234567890");
            componente2.Comprimir();

            Console.WriteLine();

            // Si la longitud de los datos a comprimir es mayor a 25 utilizamos Zip
            IComponente componente3 = Creator.MakeComponent("123456789012345678901234567890");
            componente3.Comprimir();
        }
    }
}
