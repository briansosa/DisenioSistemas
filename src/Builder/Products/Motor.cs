using System;

namespace Builder.Products{
    public class CarMotor : IProduct {
        private String information;
        public CarMotor(string information){
            this.information = information;
        }
        public String getInformation() {
            return String.Format(this.information);
        }
    }

    public class MotorcycleMotor : IProduct {
        private String information;
        public MotorcycleMotor(string information){
            this.information = information;
        }
        public String getInformation() {
            return String.Format(this.information);
        }
    }
}
