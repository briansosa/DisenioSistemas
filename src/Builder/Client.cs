using System;
using Builder.Directors;
using Builder.Builders;
using Builder.Models;

namespace Builder{
    public class Builder {
        static void Main(string[] args){
            Console.WriteLine("AUTOS SEDAN");
            IBuilder audiSedanBuilder = new CarAudiBuilder();
            IDirector sedanDirector = new SedanDirector(audiSedanBuilder);
            IVehicle sedanAudi = sedanDirector.Make();
            Console.WriteLine(sedanAudi.getVehicleInformation());

            IBuilder fordSedanBuilder = new CarFordFocusBuilder();
            sedanDirector.ChangeBuilder(fordSedanBuilder);
            IVehicle sedanFord = sedanDirector.Make();
            Console.WriteLine(sedanFord.getVehicleInformation());

            Console.WriteLine("AUTOS DEPORTIVOS");
            IBuilder audiBuilder = new CarAudiBuilder();
            IDirector deportivoDirector = new DeportivoDirector(audiBuilder);
            IVehicle deportivoAudi = deportivoDirector.Make();
            Console.WriteLine(deportivoAudi.getVehicleInformation());

            IBuilder fordDeportivoBuilder = new CarFordFocusBuilder();
            deportivoDirector.ChangeBuilder(fordDeportivoBuilder);
            IVehicle deportivoFord = deportivoDirector.Make();
            Console.WriteLine(deportivoFord.getVehicleInformation());

            Console.WriteLine("Moto Standard");
            IBuilder zanellaBuilder = new MotorcycleZanellaBuilder();
            IDirector standardMotoDirector = new StandardMotoDirector(zanellaBuilder);
            IVehicle zanella = standardMotoDirector.Make();
            Console.WriteLine(zanella.getVehicleInformation());
        }
    }
}