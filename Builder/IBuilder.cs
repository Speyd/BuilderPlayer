using System.Numerics;
using PlayerClass;

namespace Builder
{
    public interface IBuilder
    {
        void reset();
        void setBonusDamage();
        void setWeaknessDamage();
        void setHp();
        void setShield();
        void setEnergy();
        Player? getResult();

    }
}
