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

        public object Value { get; set; }
    }
}
