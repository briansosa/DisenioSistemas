using System;

namespace Builder.Products.Frame{
    public class BikeFrame : IProduct {
        public String getInformation() {
            return String.Format("Cuadro de bici que si te caes no se dobla");
        }
    }
}
