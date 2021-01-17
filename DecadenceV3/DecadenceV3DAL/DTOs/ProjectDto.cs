namespace DecadenceV3BLL.DTOs
{
    public class ProjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ColorMarker { get; set; }
        public bool isFavorite { get; set; }
        public string DisplayAs { get; set; }
        public int SubProjectId { get; set; }
    }
}