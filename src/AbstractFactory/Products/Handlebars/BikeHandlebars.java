package AbstractFactory.Products.Handlebars;

public class BikeHandlebars implements IHandlebars {
    public String getInformation() {
        return String.format("manubrio de bici");
    }
}
