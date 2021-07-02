using Builder.Builders;
using Builder.Models;

namespace Builder.Directors {
    public class SedanDirector : IDirector {

        private IBuilder builder;  
        public SedanDirector(IBuilder builder){
            this.builder = builder;
        }

        public IVehicle Make(){
            this.builder.CreateWheel();
            this.builder.CreateWheel();
            this.builder.CreateWheel();
            this.builder.CreateWheel();
            this.builder.CreateDoor();
            this.builder.CreateDoor();
            this.builder.CreateDoor();
            this.builder.CreateDoor();
            this.builder.CreateBonnet();
            this.builder.CreateChassis();
            this.builder.CreateMotor();
            this.builder.CreateSeat();
            this.builder.CreateSeat();
            this.builder.CreateSeat();
            this.builder.CreateSteeringWheel();
            this.builder.CreateSteeringWheel();
            this.builder.CreateTailPipe();
            return this.builder.GetModel();
        }

        public void ChangeBuilder(IBuilder builder){
            this.builder = builder;
        }
    }
}