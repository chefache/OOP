using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
     
        private readonly List<IGun> models;

        public GunRepository()
        {
            this.models = new List<IGun>();
        }

        public IReadOnlyCollection<IGun> Models => models.AsReadOnly();

        public void Add(IGun model) // Check this !!!
        {
            if (!this.models.Contains(model))
            {
                this.models.Add(model);
            }
        }

        public IGun Find(string name)
        {
            foreach (var gun in models)
            {
                if (name == gun.Name)
                {
                    return gun;
                }
            }
            return null;
        }

        public bool Remove(IGun model)
        {
            return this.models.Remove(model);           
        }
    }
}
