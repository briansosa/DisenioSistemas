using System;

namespace Builder.Products{
    public class BikeWheel : IProduct {
        private int size;

        public BikeWheel(int size){
            this.size = size;
        }

        public String getInformation() {
            return String.Format("La rueda de la bici es rodado {0}", this.size);
        }
    }

    public class MotorcycleWheel : IProduct {
        private int size;
        private int duration;

        public MotorcycleWheel(int size, int duration){
            this.size = size;
            this.duration = duration;
        }

        public String getInformation() {
            return String.Format("La rueda de la moto es rodado {0} y tiene una duracion de {1} años", this.size, this.duration);
        }
    }

    public class CarWheel : IProduct {
        private int size;
        private int duration;

        public CarWheel(int size, int duration){
            this.size = size;
            this.duration = duration;
        }

        public String getInformation() {
            return String.Format("La rueda del auto es rodado {0} y tiene una duracion de {1} años", this.size, this.duration);
        }
    }
}