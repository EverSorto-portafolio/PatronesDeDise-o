namespace Codigo_Limpio.Estructural.Wrapper.WrapperEjercicio1
{
    public abstract class DecoradorCafe : ICafe
    {
        protected ICafe _cafe;
        protected DecoradorCafe(ICafe cafe)
        {
            _cafe = cafe ?? throw new ArgumentNullException(nameof(cafe));
        }
        public virtual double GetCost()
        {
            return _cafe.GetCost();
        }

        public virtual string GetDescription()
        {
            return _cafe.GetDescription();
        }
    }
}
