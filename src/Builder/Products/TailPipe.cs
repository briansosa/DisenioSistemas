using System;

namespace Builder.Products{
    public class CarTailPipe : IProduct {
        private String info;
        public CarTailPipe(string info){
            this.info = info;
        }
        public String getInformation() {
            return String.Format(this.info);
        }
    }


    public class MotorcycleTailPipe : IProduct {
        private String info;
        public MotorcycleTailPipe(string info){
            this.info = info;
        }
        public String getInformation() {
            return String.Format(this.info);
        }
    }
}
