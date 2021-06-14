package AbstractFactory.Factories;

import AbstractFactory.Products.Bonnet.IBonnet;
import AbstractFactory.Products.Chain.BikeChain;
import AbstractFactory.Products.Chain.IChain;
import AbstractFactory.Products.Chassis.IChassis;
import AbstractFactory.Products.Door.IDoor;
import AbstractFactory.Products.Frame.BikeFrame;
import AbstractFactory.Products.Frame.IFrame;
import AbstractFactory.Products.Handlebars.BikeHandlebars;
import AbstractFactory.Products.Handlebars.IHandlebars;
import AbstractFactory.Products.Motor.IMotor;
import AbstractFactory.Products.Seat.BikeSeat;
import AbstractFactory.Products.Seat.ISeat;
import AbstractFactory.Products.SteeringWheel.ISteeringWheel;
import AbstractFactory.Products.TailPipe.ITailPipe;
import AbstractFactory.Products.Wheel.BikeWheel;
import AbstractFactory.Products.Wheel.IWheel;

public class BikeFactory implements IFactory {
    public IBonnet createBonnet(int size) {
        return null;
    }

    public IChain createChain() {
        return new BikeChain();
    }

    public IChassis createChassis() {
        return null;
    }

    public IDoor createDoor() {
        return null;
    }

    public IFrame createFrame() {
        return new BikeFrame();
    }

    public IHandlebars createHandlebars() {
        return new BikeHandlebars();
    }

    public IMotor createMotor() {
        return null;
    }

    public ISeat createSeat(String color, String measures) {
        return new BikeSeat(measures);
    }

    public ISteeringWheel createSteeringWheel() {
        return null;
    }

    public ITailPipe createTailPipe() {
        return null;
    }

    public IWheel createWheel(int size, int duration) {
        return new BikeWheel(size);
    }
}
