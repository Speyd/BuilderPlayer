using PlayerClass;
using Weapon;
using Weapon.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class No_ProfessionBuilder : IBuilder
    {
        private Player? player = null;

        public void reset()
        {
            player = new Player(ClassPlayer.No_Profession, 100, 100);
        }
        public void setBonusDamage()
        {
            player?.getBonusDamage().Add(typeof(Pitchfork), 10);
        }
        public void setWeaknessDamage()
        {
            player?.getWeaknessDamage().Add(typeof(IWeapon), 20);
        }
        public void setHp()
        {
            if (player is not null)
                player.Hp = player.MaxHp;
        }
        public void setShield()
        {
            if (player is not null)
                player.Shield = player.MaxShield;
        }
        public void setEnergy()
        {
            if (player is not null)
                player.Energy = player.MaxEnergy;
        }
        public Player? getResult()
        {
            Player? tempPlayer = player;
            player = null;
            return tempPlayer;
        }
    }
}
