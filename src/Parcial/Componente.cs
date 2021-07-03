using System;

namespace Parcial
{
    public interface IComponente
    {
        void Comprimir();
    }

    public class Componente : IComponente{
        private IStrategy strategy;
        public Componente(IStrategy strategy){
            this.strategy = strategy;
        }

        public void Comprimir(){
            Console.WriteLine("Soy el componente y estoy comprimiendo");
            this.strategy.IniciarCompresion();
            this.strategy.PrepararCompresion();
            this.strategy.GetEstado();
            this.strategy.FinalizarCompresion();
        }
    }
}