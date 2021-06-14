package AbstractFactory.Products.Wheel;

public class MotorcycleWheel implements IWheel {
    private int size;
    private int duration;

    public MotorcycleWheel(int size, int duration){
        this.size = size;
        this.duration = duration;
    }

    public String getInformation() {
        return String.format("La rueda de la moto es rodado %d y tiene una duracion de %d años", this.size, this.duration);
    }
}
