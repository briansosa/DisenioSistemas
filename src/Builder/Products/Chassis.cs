using System;

namespace Builder.Products{

    public class CarChassis : IProduct {
        private String info;
        public CarChassis(string info){
            this.info = info;
        }
        public String getInformation() {
            return String.Format(this.info);
        }
    }

    public class MotorcycleChassis : IProduct {
        private String info;
        public MotorcycleChassis(string info){
            this.info = info;
        }
        public String getInformation() {
            return String.Format(this.info);
        }
    }
}
