
using BuilderPattern;

namespace Director
{
    public class DirectorClass
    {
        public GPUBuilderClass Builder { get; set; }

        public void BuildPremiumProduct()
        {
            Builder.BuildGPU();
            Builder.SetSilicon();
            Builder.SetType();
            Builder.SetCoolingSystem("Water cooling");
            Builder.IncludeAdditions("Additional cooling");
            Builder.IncludeAdditions("OC profiles");
            Builder.IncludeAdditions("Additional power connectors");
        }

        public void BuildStandardProduct()
        {
            Builder.BuildGPU();
            Builder.SetSilicon();
            Builder.SetType();
            Builder.SetCoolingSystem("Air cooling");
        }

        public void BuildBareBonesProduct()
        {
            Builder.BuildGPU();
            Builder.SetSilicon();
        }


    }
}
