package AbstractFactory.Products.Door;

public class CarDoor implements IDoor {
    public String getInformation() {
        return String.format("puerta blindada");
    }
}
