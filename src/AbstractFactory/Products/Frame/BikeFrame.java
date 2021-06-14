package AbstractFactory.Products.Frame;

public class BikeFrame implements IFrame {
    public String getInformation() {
        return String.format("Cuadro de bici que si te caes no se dobla");
    }
}
