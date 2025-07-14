namespace FirstApiNet.Entities
{
    public sealed class Smartphone : Device
    {
        public override string GetBrand()
        {
            return "Motorola";
        }

        public override string GetId()
        {
            return base.GetId();
        }
    }
}
