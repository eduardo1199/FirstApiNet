namespace FirstApiNet.Entities
{

    /**
    - abstract impede a instância de classes fora dessa
    */
    public abstract class Device
    {
        /**
          - protected protege a funcao e sendo usada apenas para essa classe
         */
        protected bool IsConnected() => true;

        /**
        - abstract obriga todas as classes herdadas dessa implementar GetBrand
        */
        public abstract string GetBrand();

        /**
        - virtual habilita sobrescrever essa funcao para classes herdadas dessa
        */
        public virtual string GetId()
        {
            return "awda5d45a";
        }
    }
}
