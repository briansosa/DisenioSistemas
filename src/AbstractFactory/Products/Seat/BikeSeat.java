package AbstractFactory.Products.Seat;

public class BikeSeat implements ISeat {
    private String measures;

    public BikeSeat(String measures){
        this.measures = measures;
    }

    public String getInformation() {
        return String.format("El asiento de la bici es acolchada y de medidas %s", this.measures);
    }
}
