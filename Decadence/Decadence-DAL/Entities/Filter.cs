using Decadence_DAL.Interfaces;
using System;

namespace Decadence_DAL.Entities
{
    public class Filter : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Condition { get; set; }
    }
}
