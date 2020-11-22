using Decadence_DAL.Interfaces;
using System;

namespace Decadence_DAL.Entities
{
    public class Label : IEntity
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public string Triger { get; set; }
    }
}
