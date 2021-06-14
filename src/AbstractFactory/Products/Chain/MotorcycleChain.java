package AbstractFactory.Products.Chain;

public class MotorcycleChain implements IChain {
    public String getInformation() {
        return String.format("Esta es la mejor cadena de moto");
    }
}
