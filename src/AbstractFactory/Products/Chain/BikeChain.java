package AbstractFactory.Products.Chain;

public class BikeChain implements IChain {
    public String getInformation() {
        return String.format("Esto es una buena cadena de bici");
    }
}
