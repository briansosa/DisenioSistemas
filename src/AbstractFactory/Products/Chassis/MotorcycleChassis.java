package AbstractFactory.Products.Chassis;

public class MotorcycleChassis implements IChassis {
    public String getInformation() {
        return String.format("Chasis de moto irrompible");
    }
}
