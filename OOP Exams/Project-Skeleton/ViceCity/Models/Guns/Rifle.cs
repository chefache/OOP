using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public class Rifle : Gun, IGun
    {
        private const int RifleBulletsPerBarrel = 50;
        private const int RifleTotalBullets = 100;
        private const int RifleBulletsPerFire = 5;

        public Rifle(string name) 
            : base(name, RifleBulletsPerBarrel, RifleTotalBullets)
        {
        }

        public override int Fire()
        {
            if (this.BulletsPerBarrel < RifleBulletsPerFire)
            {
                this.Reload(RifleBulletsPerBarrel);
            }

            int firedBullets = this.DecreaseBullets(RifleBulletsPerFire);

            return firedBullets;
        }

    }
}
