using System;

namespace Builder.Products{
    public class CarDoor : IProduct {
        private String info;
        public CarDoor(string info){
            this.info = info;
        }
        public String getInformation() {
            return String.Format(this.info);
        }
    }
}