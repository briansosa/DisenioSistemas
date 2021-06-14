package AbstractFactory.Factories;

import AbstractFactory.Products.Bonnet.IBonnet;
import AbstractFactory.Products.Chain.IChain;
import AbstractFactory.Products.Chain.MotorcycleChain;
import AbstractFactory.Products.Chassis.IChassis;
import AbstractFactory.Products.Chassis.MotorcycleChassis;
import AbstractFactory.Products.Door.IDoor;
import AbstractFactory.Products.Frame.IFrame;
import AbstractFactory.Products.Handlebars.IHandlebars;
import AbstractFactory.Products.Handlebars.MotorcycleHandlebars;
import AbstractFactory.Products.Motor.IMotor;
import AbstractFactory.Products.Motor.MotorcycleMotor;
import AbstractFactory.Products.Seat.ISeat;
import AbstractFactory.Products.Seat.MotorcycleSeat;
import AbstractFactory.Products.SteeringWheel.ISteeringWheel;
import AbstractFactory.Products.TailPipe.ITailPipe;
import AbstractFactory.Products.TailPipe.MotorcycleTailPipe;
import AbstractFactory.Products.Wheel.IWheel;
import AbstractFactory.Products.Wheel.MotorcycleWheel;

public class MotorcycleFactory implements IFactory {
    public IBonnet createBonnet(int size) {
        return null;
    }

    public IChain createChain() {
        return new MotorcycleChain();
    }

    public IChassis createChassis() {
        return new MotorcycleChassis();
    }

    public IDoor createDoor() {
        return null;
    }

    public IFrame createFrame() {
        return null;
    }

    public IHandlebars createHandlebars() {
        return new MotorcycleHandlebars();
    }

    public IMotor createMotor() {
        return new MotorcycleMotor();
    }

    public ISeat createSeat(String color, String measures) {
        return new MotorcycleSeat(color, measures);
    }

    public ISteeringWheel createSteeringWheel() {
        return null;
    }

    public ITailPipe createTailPipe() {
        return new MotorcycleTailPipe();
    }

    public IWheel createWheel(int size, int duration) {
        return new MotorcycleWheel(size, duration);
    }
}
