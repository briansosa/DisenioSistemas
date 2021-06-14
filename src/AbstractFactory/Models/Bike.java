package AbstractFactory.Models;

import AbstractFactory.Factories.IFactory;
import AbstractFactory.Products.Chain.IChain;
import AbstractFactory.Products.Chassis.IChassis;
import AbstractFactory.Products.Frame.IFrame;
import AbstractFactory.Products.Handlebars.IHandlebars;
import AbstractFactory.Products.Motor.IMotor;
import AbstractFactory.Products.Seat.ISeat;
import AbstractFactory.Products.TailPipe.ITailPipe;
import AbstractFactory.Products.Wheel.IWheel;

public class Bike implements IVehicle {
    private IWheel[] wheels = new IWheel[2];
    private ISeat seat;
    private IFrame frame;
    private IChain chain;
    private IHandlebars handlebars;

    public Bike(IFactory factory){
        this.wheels[0] = factory.createWheel(14, 3);
        this.wheels[1] = factory.createWheel(14, 3);
        this.seat = factory.createSeat("negro", "30x25");
        this.frame = factory.createFrame();
        this.chain = factory.createChain();
        this.handlebars = factory.createHandlebars();
    }

    public String getVehicleInformation(){
        return String.format("" +
            "La bici cuenta con %d ruedas caracterizadas por: %s. %n" +
            "%s. %n" +
            "%s. %n" +
            "%s. %n" +
            "%s.%n",
            this.wheels.length, this.wheels[0].getInformation(),
            this.seat.getInformation(),
            this.frame.getInformation(),
            this.chain.getInformation(),
            this.handlebars.getInformation());
    }
}
