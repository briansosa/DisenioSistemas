package AbstractFactory.Factories;
import AbstractFactory.Products.Bonnet.IBonnet;
import AbstractFactory.Products.Chain.IChain;
import AbstractFactory.Products.Chassis.IChassis;
import AbstractFactory.Products.Door.IDoor;
import AbstractFactory.Products.Frame.IFrame;
import AbstractFactory.Products.Handlebars.IHandlebars;
import AbstractFactory.Products.Motor.IMotor;
import AbstractFactory.Products.Seat.ISeat;
import AbstractFactory.Products.SteeringWheel.ISteeringWheel;
import AbstractFactory.Products.TailPipe.ITailPipe;
import AbstractFactory.Products.Wheel.IWheel;

public interface IFactory {
    IBonnet createBonnet(int size);
    IChain createChain();
    IChassis createChassis();
    IDoor createDoor();
    IFrame createFrame();
    IHandlebars createHandlebars();
    IMotor createMotor();
    ISeat createSeat(String color, String measures);
    ISteeringWheel createSteeringWheel();
    ITailPipe createTailPipe();
    IWheel createWheel(int size, int duration);
}
