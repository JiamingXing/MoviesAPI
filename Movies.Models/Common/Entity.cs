﻿
namespace Movies.Models.Common
{
    public abstract class Entity : IEntity
    {
        public virtual int Id { get; set; }
    }
}
