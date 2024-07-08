using PlayerClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon.Weapon;

namespace Builder
{
    public class ArcherBuilder : IBuilder
    {
        private Player? player = null;
        public void reset()
        {
            player = new Player(ClassPlayer.Archer, 150, 75, 200);
        }
        public void setBonusDamage()
        {
            player?.getBonusDamage().Add(typeof(Bow), 10);
        }
        public void setWeaknessDamage()
        {
            player?.getWeaknessDamage().Add(typeof(Sword), 20);
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
