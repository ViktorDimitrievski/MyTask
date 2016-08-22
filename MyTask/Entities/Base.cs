using System;

namespace Entities
{
    public class Base
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual bool isActive { get; set; }
    }
}
