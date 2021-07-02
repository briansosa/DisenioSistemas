using Builder.Models;
using Builder.Products;


namespace Builder.Builders{
    public class MotorcycleZanellaBuilder : IBuilder{
        private IVehicle vehicle;

        public MotorcycleZanellaBuilder(){
            this.vehicle = new Motorcycle();
        }
        public void CreateWheel(){
            this.vehicle.wheels.Add(new MotorcycleWheel(10, 3));
        }
        public void CreateDoor(){
            // motorcycle not implement door creation
        }
        public void CreateBonnet(){
            // motorcycle not implement boonet creation
        }
        
        public void CreateChassis(){
            this.vehicle.chassis = new MotorcycleChassis("Chasis de moto irrompible");    
        }
        public void CreateMotor(){
            this.vehicle.motor = new MotorcycleMotor("Nose de motores de moto");
        }
        public void CreateSeat(){
            this.vehicle.seats.Add(new MotorcycleSeat("gris", "30x50"));
        }
        public void CreateSteeringWheel(){
            // motorcycle not implement steeringWheel creation        
        }
        public void CreateTailPipe(){
            // motorcycle not implement chassis creation        
            this.vehicle.tailPipe = new MotorcycleTailPipe("El mejor caño escape para hacer cortes con la moto");
        }
        public void CreateChain(){
            this.vehicle.chain = new MotorcycleChain("Esta es la mejor cadena de moto");
        }
        public void CreateFrame(){
            // car not implement frame creation
        }
        public void CreateHandlebars(){
            this.vehicle.handlebars = new MotorcycleHandlebars("manubrio de moto");
        }
        public IVehicle GetModel(){
            return this.vehicle;
        }
    }    
}
