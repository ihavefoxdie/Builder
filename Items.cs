using System.Collections.Generic;

namespace Items
{

    public class GPU
    {
        public GPU()
        {
            Additions = new();
        }
        public Silicon GPUSilicon { get; set; }
        public Cooling CoolingSystem { get; set; }
        public Type GPUType { get; set; }
        public List<string> Additions { get; set; }
    }

    public class Silicon
    {
        public string Name { get; set; }
    }

    public class Type
    {
        public string Name { get; set; }
    }

    public class Cooling
    {
        public string Name { get; set; }
    }

}
