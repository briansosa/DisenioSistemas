namespace FactoryMethod{
    public abstract class Visualizador {
        protected IDocumento documento;

        public Visualizador(){
            this.documento = new DocumentoGenerico();
        }

        public void abrir(){
            this.documento.abrir();
        }
        public void mostrar(){
            this.documento.mostrar();
        }
        public void cerrar(){
            this.documento.cerrar();
        }
    }

    public class VisualizadorPDF : Visualizador{

        public VisualizadorPDF(){
            this.documento = new PDF("El mejor pdf de la historia");
        }
        
    }
    public class VisualizadorODT : Visualizador{

        public VisualizadorODT(){
            this.documento = new ODT("Word? No, Open Source siempre");
        }
    }
    public class VisualizadorHTML : Visualizador{

        public VisualizadorHTML(){
            this.documento = new HTML("<title>Hola Mundo!</title>");
        }
    }

    public class VisualizadorGenerico : Visualizador{

    }
}