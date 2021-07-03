using System;

namespace Bridge {
    public abstract class RemoteControl {
        protected IDevice device;

        public RemoteControl(IDevice device){
            this.device = device;
        }

        public void togglePower(){
            if (this.device.isEnabled()){
                this.device.disable();
            }
            else {
                this.device.enable();
            }
        }
        public void volumeDown(){
            this.device.setVolume(this.device.getVolume() - 10);
        }
        public void volumeUp(){
            this.device.setVolume(this.device.getVolume() + 10);
        }
        public void ChannelDown(){
            this.device.setChannel(this.device.getChannel() - 1);
        }
        public void ChannelUp(){
            this.device.setChannel(this.device.getChannel() + 1);
        }

        public abstract String deviceInfo();
    }

    public class SimpleControl : RemoteControl
    {
        public SimpleControl(IDevice device) : base(device)
        {
            Console.WriteLine("Creando un control simple");
        }

        public override String deviceInfo(){
            return String.Format("Simple control remoto. Device: {0}", this.device.ToString());
        }
    }

    public class AdvanceControl : RemoteControl
    {
        public AdvanceControl(IDevice device) : base(device)
        {
            Console.WriteLine("Creando un control avanzado");
        }

        public void mute(){
            this.device.setVolume(0);
        }

        public void channelTo(int channel){
            this.device.setChannel(channel);
        }

        public void volumeTo(int volume){
            this.device.setVolume(volume);
        }

        public override String deviceInfo(){
            return String.Format("Advance control remoto. Device: {0}", this.device.ToString());
        }

    }
}