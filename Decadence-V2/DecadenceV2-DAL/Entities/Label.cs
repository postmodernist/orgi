using DecadenceV2_DAL.Interfaces.Entity;

namespace DecadenceV2_DAL.Entities
{
    public class Label : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Triger { get; set; }
    }
}