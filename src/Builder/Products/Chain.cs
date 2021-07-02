using System;

namespace Builder.Products{
    public class BikeChain : IProduct {
        public String getInformation() {
            return String.Format("Esto es una buena cadena de bici");
        }
    }

    public class MotorcycleChain : IProduct {
        private String info;
        public MotorcycleChain(string info){
            this.info = info;
        }
        public String getInformation() {
            return String.Format(this.info);
        }
    }
}