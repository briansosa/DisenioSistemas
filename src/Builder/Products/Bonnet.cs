using System;

namespace Builder.Products{
    public class CarBonnet : IProduct {
        private int size;

        public CarBonnet(int size){
            this.size = size;
        }

        public String getInformation() {
            return String.Format("El capot del auto tiene una medida de {0}cm", this.size);
        }
    }
}