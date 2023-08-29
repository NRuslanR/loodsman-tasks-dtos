namespace UMP.Loodsman.Dtos.SUPR
{
    public class AttachmentDto
    {
        public long Id { get; set; }

        public long ObjectId { get; set; }

        public string Name { get; set; }

        public long ObjectType { get; set; }

        public long OwnerId { get; set; }

        public long Semantics { get; set; }

        public string Url { get; set; }
    }
}
