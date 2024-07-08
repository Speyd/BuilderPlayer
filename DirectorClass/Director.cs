using Builder;
using PlayerClass;

namespace DirectorClass
{
    public class Director(IBuilder? builder)
    {
        public void setBuilder(IBuilder _builder) => builder = _builder;

        public Player? creatPlayer()
        {
            builder?.reset();
            builder?.setBonusDamage();
            builder?.setWeaknessDamage();
            builder?.setHp();
            builder?.setShield();
            builder?.setEnergy();

            return builder?.getResult();
        }
    }
}
