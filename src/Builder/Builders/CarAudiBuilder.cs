using Builder.Models;
using Builder.Products;


namespace Builder.Builders{
    public class CarAudiBuilder : IBuilder{
        private IVehicle vehicle;

        public CarAudiBuilder(){
            this.vehicle = new Car();
        }
        public void CreateWheel(){
            this.vehicle.wheels.Add(new CarWheel(17, 5));
        }
        public void CreateDoor(){
            this.vehicle.doors.Add(new CarDoor("puerta blindada"));
        }
        public void CreateBonnet(){
            this.vehicle.bonnet = new CarBonnet(150);
        }
        
        public void CreateChassis(){
            this.vehicle.chassis = new CarChassis("Chasis de auto super copado");
        
        }
        public void CreateMotor(){
            this.vehicle.motor = new CarMotor("Motor v8 4.0 TFSI 420CV 550Nm");
        }
        public void CreateSeat(){
            this.vehicle.seats.Add(new CarSeat("negro brilloso"));
        }
        public void CreateSteeringWheel(){
            this.vehicle.steeringWheel = new CarSteeringWheel("Volante antideslizante con luces que se prenden al ritmo de la música");
        }
        public void CreateTailPipe(){
            this.vehicle.tailPipe = new CarTailPipe("Caño de escape que te escuchan hasta Gerli cuando cruzas el Pueyrredon");
        }
        public void CreateChain(){
            // car not implement chain creation
        }
        public void CreateFrame(){
            // car not implement frame creation
        }
        public void CreateHandlebars(){
            // car not implement handlebars creation
        }
        public IVehicle GetModel(){
            return this.vehicle;
        }
    }    
}
