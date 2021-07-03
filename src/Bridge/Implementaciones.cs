namespace Bridge {
    using System;
    public interface IDevice {
        bool isEnabled();
        void enable();
        void disable();
        int getVolume();
        void setVolume(int volume);
        int getChannel();
        void setChannel(int channel);
        // String toString();
    }

    public class Tv : IDevice
    {
        private bool enabled;
        private int channel;
        private int volume;
        public void disable()
        {
            this.enabled = false;
        }

        public void enable()
        {
            this.enabled = true;
        }

        public int getChannel()
        {
            return this.channel;
        }

        public int getVolume()
        {
            return this.volume;
        }

        public bool isEnabled()
        {
            return this.enabled;
        }

        public void setChannel(int channel)
        {
            this.channel = channel;
        }

        public void setVolume(int volume)
        {
            this.volume = volume;
        }

        public override string ToString(){
            if (!this.enabled){
                return "La TV está apagada";
            }
            else {
                return String.Format("La TV esta prendida en el canal {0} y un volumen de {1}", this.channel, this.volume);
            }
        }
    }

    public class Radio : IDevice
    {
        private bool enabled;
        private int channel;
        private int volume;
        public void disable()
        {
            this.enabled = false;
        }

        public void enable()
        {
            this.enabled = true;
        }

        public int getChannel()
        {
            return this.channel;
        }

        public int getVolume()
        {
            return this.volume;
        }

        public bool isEnabled()
        {
            return this.enabled;
        }

        public void setChannel(int channel)
        {
            this.channel = channel;
        }

        public void setVolume(int volume)
        {
            this.volume = volume;
        }

        public override string ToString(){
            if (!this.enabled){
                return "La Radio está apagada";
            }
            else {
                return String.Format("La Radio esta prendida sintonizando la frecuencia {0} en un volumen de {1} puntos", this.channel, this.volume);
            }
        }
    }
}