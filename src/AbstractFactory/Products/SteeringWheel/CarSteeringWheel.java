package AbstractFactory.Products.SteeringWheel;

public class CarSteeringWheel implements ISteeringWheel {
    public String getInformation() {
        return String.format("Volante antideslizante con luces que se prenden al ritmo de la música");
    }
}
