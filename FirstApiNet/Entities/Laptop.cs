namespace FirstApiNet.Entities
{
    /**
    - sealed impede dessa classe ser herdada para outra classe como pai ou classe base
    */
    public sealed class Laptop : Device
    {
        public override string GetBrand()
        {
            return "Apple";
        }

        public string GetModel()
        {
            var isConnected = IsConnected();

            if(isConnected)
            {
                return "MacBook";
            }

            return "Unknow";
        }

        /**
       - override sobrescreve o metodo GetId da classe pai
       */
        public override string GetId()
        {
            return base.GetId();
        }
    }
}
