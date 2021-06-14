package AbstractFactory.Models;

import AbstractFactory.Factories.IFactory;
import AbstractFactory.Products.Bonnet.IBonnet;
import AbstractFactory.Products.Chain.IChain;
import AbstractFactory.Products.Chassis.IChassis;
import AbstractFactory.Products.Door.IDoor;
import AbstractFactory.Products.Handlebars.IHandlebars;
import AbstractFactory.Products.Motor.IMotor;
import AbstractFactory.Products.Seat.ISeat;
import AbstractFactory.Products.SteeringWheel.ISteeringWheel;
import AbstractFactory.Products.TailPipe.ITailPipe;
import AbstractFactory.Products.Wheel.IWheel;

public class Motorcycle implements IVehicle {
    private IWheel[] wheels = new IWheel[2];
    private IChassis chassis;
    private IMotor motor;
    private ISeat seat;
    private ITailPipe tailPipe;
    private IChain chain;
    private IHandlebars handlebars;

    public Motorcycle(IFactory factory){
        this.wheels[0] = factory.createWheel(14, 3);
        this.wheels[1] = factory.createWheel(14, 3);
        this.chassis = factory.createChassis();
        this.motor = factory.createMotor();
        this.seat = factory.createSeat("negro", "30x25");
        this.tailPipe = factory.createTailPipe();
        this.chain = factory.createChain();
        this.handlebars = factory.createHandlebars();
    }

    public String getVehicleInformation(){
        return String.format("" +
            "La moto cuenta con %d ruedas caracterizadas por: %s. %n" +
            "%s. %n" +
            "Motor %s. %n" +
            "%s. %n" +
            "%s. %n" +
            "%s. %n" +
            "%s.%n",
            this.wheels.length, this.wheels[0].getInformation(),
            this.chassis.getInformation(),
            this.motor.getInformation(),
            this.seat.getInformation(),
            this.tailPipe.getInformation(),
            this.chain.getInformation(),
            this.handlebars.getInformation());
    }
}
