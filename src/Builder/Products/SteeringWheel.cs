using System;

namespace Builder.Products{

    public class CarSteeringWheel : IProduct {
        private String information;
        public CarSteeringWheel(string information){
            this.information = information;
        }
        public String getInformation() {
            return String.Format(this.information);
        }
    }
}
