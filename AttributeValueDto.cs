namespace UMP.Loodsman.Dtos
{
    public class AttributeValueDto
    {
        public AttributeValueDto()
        {
            Attribute = new AttributeDto();
        }

        public long Id { get; set; }

        public AttributeDto Attribute { get; set; }

        public string Name
        {
            get => Attribute.Name;
            set => Attribute.Name = value;
        }

        public int Type
        {
            get => Attribute.Type;
            set => Attribute.Type = value;
        }

        public object Value { get; set; }
    }
}
