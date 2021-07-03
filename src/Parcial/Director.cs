namespace Parcial {
    public interface IDirector{
        IComponente Make();
        void SetBuilder(IBuilder builder);
    }

    public class Director : IDirector
    {
        private IBuilder builder;
        public IComponente Make()
        {
            if (this.builder == null){
                throw new System.NotImplementedException();
            }
            // si el builder tendria mas métodos para setear cosas en el componente irian aca
            return this.builder.GetModel();
        }

        public void SetBuilder(IBuilder builder)
        {
            this.builder = builder;
        }
    }
}