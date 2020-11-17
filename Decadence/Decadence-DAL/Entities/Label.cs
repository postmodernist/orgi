using System;
using Decadence_DAL.Interfaces;

namespace Decadence_DAL.Entities
{
    public class Label : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Triger { get; set; }
    }
}
