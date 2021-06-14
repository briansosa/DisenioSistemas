package AbstractFactory.Models;

import AbstractFactory.Factories.IFactory;
import AbstractFactory.Products.Bonnet.IBonnet;
import AbstractFactory.Products.Chassis.IChassis;
import AbstractFactory.Products.Door.IDoor;
import AbstractFactory.Products.Motor.IMotor;
import AbstractFactory.Products.Seat.ISeat;
import AbstractFactory.Products.SteeringWheel.ISteeringWheel;
import AbstractFactory.Products.TailPipe.ITailPipe;
import AbstractFactory.Products.Wheel.IWheel;

public class Car implements IVehicle{
    private IWheel[] wheels = new IWheel[4];
    private IDoor[] doors = new IDoor[4];
    private IBonnet bonnet;
    private IChassis chassis;
    private IMotor motor;
    private ISeat[] seats = new ISeat[3];
    private ISteeringWheel steeringWheel;
    private ITailPipe tailPipe;

    public Car(IFactory factory){
        this.wheels[0] = factory.createWheel(17, 3);
        this.wheels[1] = factory.createWheel(17, 3);
        this.wheels[2] = factory.createWheel(17, 3);
        this.wheels[3] = factory.createWheel(17, 3);
        this.doors[0] = factory.createDoor();
        this.doors[1] = factory.createDoor();
        this.doors[2] = factory.createDoor();
        this.doors[3] = factory.createDoor();
        this.bonnet = factory.createBonnet(160);
        this.chassis = factory.createChassis();
        this.motor = factory.createMotor();
        this.seats[0] = factory.createSeat("negro", "70x90");
        this.seats[1] = factory.createSeat("negro", "70x90");
        this.seats[2] = factory.createSeat("negro", "180x90");
        this.steeringWheel = factory.createSteeringWheel();
        this.tailPipe = factory.createTailPipe();
    }

    public String getVehicleInformation(){
        return String.format("" +
            "El auto cuenta con %d ruedas caracterizadas por: %s. %n" +
            "Es un auto de %d puertas caracterizadas por: %s. %n" +
            "Contiene %d asientos. %s. %n" +
            "%s. %n" +
            "%s. %n" +
            "%s. %n" +
            "%s. %n" +
            "%s.%n",
            this.wheels.length, this.wheels[0].getInformation(),
            this.doors.length, this.doors[0].getInformation(),
            this.seats.length, this.seats[0].getInformation(),
            this.bonnet.getInformation(),
            this.chassis.getInformation(),
            this.motor.getInformation(),
            this.steeringWheel.getInformation(),
            this.tailPipe.getInformation());
    }
}
