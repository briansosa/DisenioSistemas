package AbstractFactory.Products.Wheel;

public class BikeWheel implements IWheel {
    private int size;

    public BikeWheel(int size){
        this.size = size;
    }

    public String getInformation() {
        return String.format("La rueda de la bici es rodado %d", this.size);
    }
}
