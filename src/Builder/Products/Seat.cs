using System;

namespace Builder.Products{

    public class BikeSeat : IProduct {
        private String measures;

        public BikeSeat(String measures){
            this.measures = measures;
        }

        public String getInformation() {
            return String.Format("El asiento de la bici es acolchada y de medidas {0}", this.measures);
        }
    }

    public class CarSeat : IProduct {
        private String color;

        public CarSeat(String color){
            this.color = color;
        }

        public String getInformation() {
            return String.Format("El asiento del auto es una butaca de color {0}", this.color);
        }
    }

    public class MotorcycleSeat : IProduct {
        private String color;
        private String measures;

        public MotorcycleSeat(String color, String measures){
            this.color = color;
            this.measures = measures;
        }

        public String getInformation() {
            return String.Format("El asiento de la moto es antideslizante de color {0} y medidas {1}", this.color, this.measures);
        }
    }

}
