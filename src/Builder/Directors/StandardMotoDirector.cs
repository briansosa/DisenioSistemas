using Builder.Builders;
using Builder.Models;

namespace Builder.Directors {
    public class StandardMotoDirector : IDirector {

        private IBuilder builder;  
        public StandardMotoDirector(IBuilder builder){
            this.builder = builder;
        }

        public IVehicle Make(){
            this.builder.CreateWheel();
            this.builder.CreateWheel();
            this.builder.CreateMotor();
            this.builder.CreateChassis();
            this.builder.CreateSeat();
            this.builder.CreateTailPipe();
            this.builder.CreateChain();
            this.builder.CreateHandlebars();
            return this.builder.GetModel();
        }

        public void ChangeBuilder(IBuilder builder){
            this.builder = builder;
        }
    }
}