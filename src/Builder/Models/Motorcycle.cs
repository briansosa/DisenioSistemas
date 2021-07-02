using Builder.Products;
using System.Collections.Generic;
using System;

namespace Builder.Models{
    public class Motorcycle : IVehicle{
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

        public Motorcycle(){
            this.wheels = new List<IProduct>();
            this.seats = new List<IProduct>();
        }

        public String getVehicleInformation(){
            return String.Format("" +
                "La moto cuenta con {0} ruedas caracterizadas por: {1}. " + Environment.NewLine +
                "{2} ." + Environment.NewLine +
                "Motor {3}." + Environment.NewLine +
                "{4} ." + Environment.NewLine +
                "{5} ." + Environment.NewLine +
                "{6} ." + Environment.NewLine +
                "{7}." + Environment.NewLine,
                this.wheels.Count, this.wheels[0].getInformation(),
                this.chassis.getInformation(),
                this.motor.getInformation(),
                this.seats[0].getInformation(),
                this.tailPipe.getInformation(),
                this.chain.getInformation(),
                this.handlebars.getInformation());
        }
    }
}