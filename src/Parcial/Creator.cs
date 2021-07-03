using System;

namespace Parcial
{
    public class Creator
    {
        public static IComponente MakeComponent(String data)
        {
            IDirector director = new Director();
            IBuilder builder;
            if (data.Length <= 10){
                builder = new TarBuilder(data);
            }
            else if (10 < data.Length && data.Length <= 20){
                builder = new RarBuilder(data);
            }
            else {
                builder = new ZipBuilder(data);
            }
            
            director.SetBuilder(builder);
            return director.Make();
        }
    }
}
