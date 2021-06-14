package AbstractFactory.Products.Motor;

public class CarMotor implements IMotor {
    public String getInformation() {
        return String.format("Motor v8 4.0 TFSI 420CV 550Nm");
    }
}
