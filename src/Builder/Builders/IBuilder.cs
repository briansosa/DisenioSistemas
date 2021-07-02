using Builder.Models;

namespace Builder.Builders {
    public interface IBuilder {
        void CreateWheel();
        void CreateDoor();
        void CreateBonnet();
        void CreateChassis();
        void CreateMotor();
        void CreateSeat();
        void CreateSteeringWheel();
        void CreateTailPipe();
        void CreateChain();
        void CreateFrame();
        void CreateHandlebars();
        IVehicle GetModel();
    }
}