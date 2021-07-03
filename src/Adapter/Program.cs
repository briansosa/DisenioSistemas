using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Documento documento1, documento2;
            documento1 = new DocumentoHtml();
            documento1.setContenido("Hello");
            documento1.dibuja();
            documento1.imprime();
            Console.WriteLine();
            documento2 = new DocumentoPdfAdapter();
            documento2.setContenido("Hola");
            documento2.dibuja();
            documento2.imprime();
        }
    }

    public interface Documento{
        void setContenido(String contenido);
        void dibuja();
        void imprime();
    }

    public class DocumentoHtml : Documento
    {
        protected String contenido;
        public void dibuja()
        {
            Console.WriteLine("Dibuja documento HTML: " + this.contenido);
        }

        public void imprime()
        {
            Console.WriteLine("Imprime documento HTML: " + this.contenido);
        }

        public void setContenido(String contenido)
        {
            this.contenido = contenido;
        }
    }

    // Esta clase no se corresponde con la interfaz de Documento, por eso tengo que crear Adaptador
    public class ComponentePdf
    {
        protected String contenido;
        public void pdfFijaContenido(String contenido)
        {
            this.contenido = contenido;
        }
        public void pdfPreparaVisualizacion()
        {
            Console.WriteLine("Visualiza PDF: Comienzo");
        }
        public void pdfRefresca()
        {
            Console.WriteLine("Visualiza contenido PDF: " + contenido);
        }
        public void pdfFinalizaVisualizacion()
        {
            Console.WriteLine("Visualiza PDF: Fin");
        }
        public void pdfEnviaImpresora()
        {
            Console.WriteLine("Impresión PDF: " + contenido);
        }
    }

    public class DocumentoPdfAdapter : Documento
    {
        protected ComponentePdf componentePdf = new ComponentePdf();
        public void dibuja()
        {   
            Console.WriteLine("Dibujando PDF");
            this.componentePdf.pdfPreparaVisualizacion();
            this.componentePdf.pdfRefresca();
            this.componentePdf.pdfFinalizaVisualizacion();
        }

        public void imprime()
        {
            this.componentePdf.pdfEnviaImpresora();
        }

        public void setContenido(String contenido)
        {
            this.componentePdf.pdfFijaContenido(contenido);
        }
    }

}
