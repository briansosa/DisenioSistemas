using Builder.Products;
using System.Collections.Generic;
using System;

namespace Builder.Models{

public class Car : IVehicle{
    public List<IProduct> wheels {get; set;}
    public List<IProduct> doors {get; set;}
    public IProduct bonnet {get; set;}
    public IProduct chassis {get; set;}
    public IProduct motor {get; set;}
    public List<IProduct> seats {get; set;}
    public IProduct steeringWheel {get; set;}
    public IProduct tailPipe {get; set;}
    public IProduct frame {get; set;}
    public IProduct handlebars {get; set;}
    public IProduct chain {get; set;}

    public Car(){
        this.wheels = new List<IProduct>();
        this.doors = new List<IProduct>();
        this.seats = new List<IProduct>();
    }

    public String getVehicleInformation(){
        return String.Format("" +
            "El auto cuenta con {0} ruedas caracterizadas por: {1}. " + Environment.NewLine + "" +
            "Es un auto de {2} puertas caracterizadas por: {3}. " + Environment.NewLine + "" +
            "Contiene {4} asientos. {5}. " + Environment.NewLine + "" +
            "{6}. " + Environment.NewLine + "" +
            "{7}. " + Environment.NewLine + "" +
            "{8}. " + Environment.NewLine + "" +
            "{9}. " + Environment.NewLine + "" +
            "{10}." + Environment.NewLine + "",
            this.wheels.Count, this.wheels[0].getInformation(),
            this.doors.Count, this.doors[0].getInformation(),
            this.seats.Count, this.seats[0].getInformation(),
            this.bonnet.getInformation(),
            this.chassis.getInformation(),
            this.motor.getInformation(),
            this.steeringWheel.getInformation(),
            this.tailPipe.getInformation());
    }
}
}