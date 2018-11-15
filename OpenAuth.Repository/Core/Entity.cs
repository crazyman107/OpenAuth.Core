using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenAuth.Repository.Core
{
    public abstract class Entity
    {
        [NotMapped]
        public string Id { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
