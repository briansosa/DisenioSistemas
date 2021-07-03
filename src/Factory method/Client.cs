namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Visualizador[] visualizadores = new Visualizador[]{
                new VisualizadorGenerico(), 
                new VisualizadorPDF(), 
                new VisualizadorODT(), 
                new VisualizadorHTML()
            };

            foreach (Visualizador visualizador in visualizadores){
                visualizador.abrir();
                visualizador.mostrar();
                visualizador.cerrar();
            }
        }
    }
}
