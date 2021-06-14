package AbstractFactory.Factories;

import AbstractFactory.Products.Bonnet.CarBonnet;
import AbstractFactory.Products.Bonnet.IBonnet;
import AbstractFactory.Products.Chain.IChain;
import AbstractFactory.Products.Chassis.CarChassis;
import AbstractFactory.Products.Chassis.IChassis;
import AbstractFactory.Products.Door.CarDoor;
import AbstractFactory.Products.Door.IDoor;
import AbstractFactory.Products.Frame.IFrame;
import AbstractFactory.Products.Handlebars.IHandlebars;
import AbstractFactory.Products.Motor.CarMotor;
import AbstractFactory.Products.Motor.IMotor;
import AbstractFactory.Products.Seat.CarSeat;
import AbstractFactory.Products.Seat.ISeat;
import AbstractFactory.Products.SteeringWheel.CarSteeringWheel;
import AbstractFactory.Products.SteeringWheel.ISteeringWheel;
import AbstractFactory.Products.TailPipe.CarTailPipe;
import AbstractFactory.Products.TailPipe.ITailPipe;
import AbstractFactory.Products.Wheel.CarWheel;
import AbstractFactory.Products.Wheel.IWheel;

public class CarFactory implements IFactory {
    public IBonnet createBonnet(int size) {
        return new CarBonnet(size);
    }

    public IChain createChain() {
        return null;
    }

    public IChassis createChassis() {
        return new CarChassis();
    }

    public IDoor createDoor() {
        return new CarDoor();
    }

    public IFrame createFrame() {
        return null;
    }

    public IHandlebars createHandlebars() {
        return null;
    }

    public IMotor createMotor() {
        return new CarMotor();
    }

    public ISeat createSeat(String color, String measures) {
        return new CarSeat(color);
    }

    public ISteeringWheel createSteeringWheel() {
        return new CarSteeringWheel();
    }

    public ITailPipe createTailPipe() {
        return new CarTailPipe();
    }

    public IWheel createWheel(int size, int duration) {
        return new CarWheel(size, duration);
    }
}
