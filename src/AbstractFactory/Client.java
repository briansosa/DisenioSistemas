package AbstractFactory;

import AbstractFactory.Factories.BikeFactory;
import AbstractFactory.Factories.CarFactory;
import AbstractFactory.Factories.IFactory;
import AbstractFactory.Factories.MotorcycleFactory;
import AbstractFactory.Models.Car;
import AbstractFactory.Models.IVehicle;
import AbstractFactory.Models.Motorcycle;
import AbstractFactory.Models.Bike;

import java.util.ArrayList;
import java.util.List;

public class Client {
    public static void main(String[] args) {
        IFactory carFactory = new CarFactory();
        IFactory motorcycleFactory = new MotorcycleFactory();
        IFactory BikeFactory = new BikeFactory();

        IVehicle[] vehicles = new IVehicle[]{new Car(carFactory), new Motorcycle(motorcycleFactory), new Bike(BikeFactory)};

        for (int i = 0; i < vehicles.length; i++){
            System.out.println("INFO VEHICLE");
            System.out.println(vehicles[i].getVehicleInformation());
        }
    }
}
