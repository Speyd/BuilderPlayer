using PlayerClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon.Weapon;

namespace Builder
{
    public class WarriorBuilder : IBuilder
    {
        private Player? player = null;

        public void reset()
        {
            player = new Player(ClassPlayer.Warrior, 200, 100, 150);
        }
        public void setBonusDamage()
        {
            player?.getBonusDamage().Add(typeof(Sword), 10);
        }
        public void setWeaknessDamage()
        {
            player?.getWeaknessDamage().Add(typeof(Bow), 20);
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
