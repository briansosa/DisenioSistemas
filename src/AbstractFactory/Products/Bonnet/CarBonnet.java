package AbstractFactory.Products.Bonnet;

public class CarBonnet implements IBonnet {
    private int size;

    public CarBonnet(int size){
        this.size = size;
    }

    public String getInformation() {
        return String.format("El capot del auto tiene una medida de %d", this.size);
    }
}
