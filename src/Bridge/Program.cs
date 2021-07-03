using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleControl simpleControlTv = new SimpleControl(new Tv());
            SimpleControl simpleControlRadio = new SimpleControl(new Radio());
            AdvanceControl advanceControlTv = new AdvanceControl(new Tv());
            AdvanceControl advanceControlRadio = new AdvanceControl(new Radio());

            simpleControlRadio.togglePower();
            simpleControlRadio.ChannelUp();
            simpleControlRadio.ChannelUp();
            simpleControlRadio.ChannelUp();
            simpleControlRadio.volumeUp();
            Console.WriteLine(simpleControlRadio.deviceInfo());
            
            simpleControlTv.togglePower();
            simpleControlTv.volumeUp();
            simpleControlTv.volumeUp();
            simpleControlTv.volumeUp();
            Console.WriteLine(simpleControlTv.deviceInfo());

            advanceControlTv.togglePower();
            advanceControlTv.channelTo(11);
            advanceControlTv.volumeTo(50);
            Console.WriteLine(advanceControlTv.deviceInfo());

            advanceControlRadio.togglePower();
            advanceControlRadio.ChannelUp();
            advanceControlRadio.mute();
            Console.WriteLine(advanceControlRadio.deviceInfo());

        }
    }
}
