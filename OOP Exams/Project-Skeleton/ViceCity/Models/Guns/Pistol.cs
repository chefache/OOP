using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public class Pistol : Gun, IGun
    {
        private const int PistolBulletsPerBarrel = 10;
        private const int PistolTotalBulets = 100;
        private const int BulletsPerFire = 1;
        public Pistol(string name) 
            : base(name, PistolBulletsPerBarrel, PistolTotalBulets)
        {
        }

        public override int Fire()
        {
            if (this.BulletsPerBarrel < BulletsPerFire)
            {
                this.Reload(PistolBulletsPerBarrel);
            }

            int firedBullets = this.DecreaseBullets(BulletsPerFire);

            return firedBullets;
        }

    }
}
