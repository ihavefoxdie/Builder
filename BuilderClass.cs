using System.Collections.Generic;
using System.Linq;
using Items;

namespace BuilderPattern
{
    public abstract class GPUBuilderClass
    {
        public GPU GPU { get; private set; }
        public void BuildGPU()
        {
            GPU = new();
        }

        public abstract void SetSilicon();
        public abstract void SetCoolingSystem(string name);
        public abstract void SetType();
        public abstract void IncludeAdditions(string addition);
        public GPU GetResult()
        {
            var newGPU = new GPU()
            {
                GPUSilicon = new() { Name = GPU.GPUSilicon.Name },
                CoolingSystem = new() { Name = GPU.CoolingSystem.Name },
                GPUType = new() { Name = GPU.GPUType.Name }
            };
            newGPU.Additions = GPU.Additions.ToList();
            return newGPU;
        }
    }

    public class Nvidia4070TiDesktopGPUBuilder : GPUBuilderClass
    {
        public override void IncludeAdditions(string addition)
        {
            GPU.Additions.Add(addition);
        }

        public override void SetCoolingSystem(string name)
        {
            GPU.CoolingSystem = new Cooling { Name = name };
        }

        public override void SetSilicon()
        {
            GPU.GPUSilicon = new Silicon { Name = "4070 Ti" };
        }

        public override void SetType()
        {
            GPU.GPUType = new Items.Type { Name = "Desktop" };
        }

    }

    public class NvidiaTegraX1GPUBuilder : GPUBuilderClass
    {
        public override void IncludeAdditions(string addition)
        {

        }

        public override void SetCoolingSystem(string name)
        {
            GPU.CoolingSystem = new Cooling { Name = name };
        }

        public override void SetSilicon()
        {
            GPU.GPUSilicon = new Silicon { Name = "Tegra X1" };
        }

        public override void SetType()
        {
            GPU.GPUType = new Items.Type { Name = "Mobile" };
        }
    }
}
