using Assets.Scripts.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Interfaces
{
    public interface ISpaceship
    {
        int Health { get; set; }
        
        LightWeapon LightWeapon_1 { get; set; }
        LightWeapon LightWeapon_2 { get; set; }
    }
}
