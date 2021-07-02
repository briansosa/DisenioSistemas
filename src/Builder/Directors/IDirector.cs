using Builder.Models;
using Builder.Builders;

namespace Builder.Directors {
    public interface IDirector {
        IVehicle Make();
        void ChangeBuilder(IBuilder builder);
    }
}