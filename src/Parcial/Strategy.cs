using System;

namespace Parcial
{
    public interface IStrategy {
        void PrepararCompresion();
        void IniciarCompresion();
        void GetEstado();
        void FinalizarCompresion();
    }
    public class TarStrategy : IStrategy
    {
        private string data;
        private string estado;
        public string infoExtra {get; set;}
        public TarStrategy(string data)
        {
            this.estado = "Pendiente";
            this.data = data;
        }

        public void FinalizarCompresion()
        {
            Console.WriteLine($"Finalizando Compresion Tar.");
            this.estado = "Finalizado";
        }

        public void IniciarCompresion()
        {
            Console.WriteLine($"Iniciando Compresion Tar. Datos:{this.data}");
            this.estado = "Iniciando";
        }

        public void PrepararCompresion()
        {
            Console.WriteLine($"Preparando Compresion Tar");
            this.estado = "En proceso";
        }

        public void GetEstado()
        {
            Console.WriteLine($"El estado es: {this.estado}. Info extra: {this.infoExtra}");
        }
    }
    public class RarStrategy : IStrategy
    {
        private string data;
        private string estado;
        public string promocion {get; set;}
        public RarStrategy(string data)
        {
            this.estado = "Pendiente";
            this.data = data;
        }

        public void FinalizarCompresion()
        {
            Console.WriteLine($"Finalizando Compresion Rar.");
            this.estado = "Finalizado";
        }

        public void IniciarCompresion()
        {
            Console.WriteLine($"Iniciando Compresion Rar. Datos:{this.data}");
            this.estado = "Iniciando";
        }

        public void PrepararCompresion()
        {
            Console.WriteLine($"Preparando Compresion Rar");
            this.estado = "En proceso";
        }

        public void GetEstado()
        {
            Console.WriteLine($"El estado es: {this.estado}. Promocion con RAR!: {this.promocion}");
        }
    }

    public class ZipStrategy : IStrategy
    {
        private string data;
        private string estado;
        public int descuento {get; set;}
        public ZipStrategy(string data)
        {
            this.estado = "Pendiente";
            this.data = data;
        }

        public void FinalizarCompresion()
        {
            Console.WriteLine($"Finalizando Compresion Zip.");
            this.estado = "Finalizado";
        }

        public void IniciarCompresion()
        {
            Console.WriteLine($"Iniciando Compresion Zip. Datos:{this.data}");
            this.estado = "Iniciando";
        }

        public void PrepararCompresion()
        {
            Console.WriteLine($"Preparando Compresion Zip");
            this.estado = "En proceso";
        }

        public void GetEstado()
        {
            Console.WriteLine($"El estado es: {this.estado}. Gracias por utilizar zip! tendras un descuento de: {this.descuento} dolares si compras el paquete exclusivo");
        }
    }

}