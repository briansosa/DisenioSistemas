namespace Parcial
{
    public interface IBuilder
    {
        IComponente GetModel();
    }

    public class TarBuilder : IBuilder {
        private IComponente componente;

        public TarBuilder(string data){
            TarStrategy strategy = new TarStrategy(data);
            strategy.infoExtra = "Tar puede demorar varios minutos en comprimir";
            this.componente = new Componente(strategy);
        }

        public IComponente GetModel()
        {
            return this.componente;
        }

    }
    public class RarBuilder : IBuilder {
        private IComponente componente;
        public RarBuilder(string data){
            RarStrategy strategy = new RarStrategy(data);
            strategy.promocion = "Recomendando Rar a un amigo tenes 3 meses gratis de uso!";
            this.componente = new Componente(strategy);
        }

        public IComponente GetModel()
        {
            return this.componente;
        }

    }
    public class ZipBuilder : IBuilder {
        private IComponente componente;

        public ZipBuilder(string data){
            ZipStrategy strategy = new ZipStrategy(data);
            strategy.descuento = 10;
            this.componente = new Componente(strategy);
        }

        public IComponente GetModel()
        {
            return this.componente;
        }

    }
}