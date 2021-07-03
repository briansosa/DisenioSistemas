using System;

namespace FactoryMethod{
    public interface IDocumento{
        void abrir();
        void mostrar();
        void cerrar();
    }

    public class DocumentoGenerico : IDocumento
    {
        public void abrir()
        {
            Console.WriteLine("Soy un documento genérico y estoy abriendo");
        }

        public void cerrar()
        {
            Console.WriteLine("Soy un documento genérico y estoy cerrando");
        }

        public void mostrar()
        {
            Console.WriteLine("Soy un documento genérico sin título");
        }
    }

    public class PDF : IDocumento
    {
        private String title;

        public PDF(String title){
            this.title = title;
        }
        public void abrir()
        {
            Console.WriteLine("Soy un PDF y estoy abriendo");
        }

        public void cerrar()
        {
            Console.WriteLine("Soy un PDF y estoy cerrando");
        }

        public void mostrar()
        {
            Console.WriteLine(String.Format("Soy un PDF titulado: {0}", this.title));
        }
    }
    public class ODT : IDocumento
    {
        private String title;

        public ODT(String title){
            this.title = title;
        }
        public void abrir()
        {
            Console.WriteLine("Soy un ODT y estoy abriendo");
        }

        public void cerrar()
        {
            Console.WriteLine("Soy un ODT y estoy cerrando");
        }

        public void mostrar()
        {
            Console.WriteLine(String.Format("Soy un ODT titulado: {0}", this.title));
        }
    }
    public class HTML : IDocumento
    {
        private String title;

        public HTML(String title){
            this.title = title;
        }
        public void abrir()
        {
            Console.WriteLine("Soy un HTML y estoy abriendo");
        }

        public void cerrar()
        {
            Console.WriteLine("Soy un HTML y estoy cerrando");
        }

        public void mostrar()
        {
            Console.WriteLine(String.Format("Soy un HTML titulado: {0}", this.title));
        }
    }
}