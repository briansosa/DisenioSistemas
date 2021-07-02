using System;

namespace Builder.Products{

    public class BikeHandlebars : IProduct {
        public String getInformation() {
            return String.Format("manubrio de bici");
        }
    }

    public class MotorcycleHandlebars : IProduct {
        private string info;
        public MotorcycleHandlebars(string info){
            this.info = info;
        }
        public String getInformation() {
            return String.Format(this.info);
        }
    }
}
