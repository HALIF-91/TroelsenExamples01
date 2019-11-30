using System;

namespace CloneablePoint
{
    public class PointDescription
    {
        public string PetName { get; set; }
        public Guid PointId { get; set; }
        public PointDescription()
        {
            PetName = "No-name";
            PointId = Guid.NewGuid();
        }
    }
}