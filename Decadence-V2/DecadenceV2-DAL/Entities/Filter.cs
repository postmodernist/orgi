using DecadenceV2_DAL.Interfaces.Entity;

namespace DecadenceV2_DAL.Entities
{
    public class Filter : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Condition { get; set; }
    }
}