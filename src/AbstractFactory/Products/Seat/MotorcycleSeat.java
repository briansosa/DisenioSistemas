package AbstractFactory.Products.Seat;

public class MotorcycleSeat implements ISeat {
    private String color;
    private String measures;

    public MotorcycleSeat(String color, String measures){
        this.color = color;
        this.measures = measures;
    }

    public String getInformation() {
        return String.format("El asiento de la moto es antideslizante de color %s y medidas %s", this.color, this.measures);
    }
}
