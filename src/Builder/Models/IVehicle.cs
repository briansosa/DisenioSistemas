using System;
using Builder.Products;
using System.Collections.Generic;

namespace Builder.Models{
    public interface IVehicle {
        String getVehicleInformation();
        List<IProduct> wheels {get; set;}
        List<IProduct> doors {get; set;}
        IProduct bonnet {get; set;}
        IProduct chassis {get; set;}
        IProduct motor {get; set;}
        List<IProduct> seats {get; set;}
        IProduct steeringWheel {get; set;}
        IProduct tailPipe {get; set;}
        IProduct chain {get; set;}
        IProduct handlebars {get; set;}
        IProduct frame {get; set;}
    }
}