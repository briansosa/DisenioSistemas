using Builder.Models;
using Builder.Products;


namespace Builder.Builders{
    public class CarFordFocusBuilder : IBuilder{
        private IVehicle vehicle;

        public CarFordFocusBuilder(){
            this.vehicle = new Car();
        }
        public void CreateWheel(){
            this.vehicle.wheels.Add(new CarWheel(14, 3));
        }
        public void CreateDoor(){
            this.vehicle.doors.Add(new CarDoor("puerta brillosa"));
        }
        public void CreateBonnet(){
            this.vehicle.bonnet = new CarBonnet(150);
        }
        
        public void CreateChassis(){
            this.vehicle.chassis = new CarChassis("Chasis blanco");
        
        }
        public void CreateMotor(){
            this.vehicle.motor = new CarMotor("Motor focus");
        }
        public void CreateSeat(){
            this.vehicle.seats.Add(new CarSeat("gris"));
        }
        public void CreateSteeringWheel(){
            this.vehicle.steeringWheel = new CarSteeringWheel("Volante antideslizante");
        }
        public void CreateTailPipe(){
            this.vehicle.tailPipe = new CarTailPipe("Caño de escape que no se siente");
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
