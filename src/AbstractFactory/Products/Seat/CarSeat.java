package AbstractFactory.Products.Seat;

public class CarSeat implements ISeat {
    private String color;

    public CarSeat(String color){
        this.color = color;
    }

    public String getInformation() {
        return String.format("El asiento del auto es una butaca de color %s", this.color);
    }
}
