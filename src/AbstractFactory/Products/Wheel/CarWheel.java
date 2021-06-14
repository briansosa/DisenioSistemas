package AbstractFactory.Products.Wheel;

public class CarWheel implements IWheel {
    private int size;
    private int duration;

    public CarWheel(int size, int duration){
        this.size = size;
        this.duration = duration;
    }

    public String getInformation() {
        return String.format("La rueda del auto es rodado %d y tiene una duracion de %d años", this.size, this.duration);
    }
}
