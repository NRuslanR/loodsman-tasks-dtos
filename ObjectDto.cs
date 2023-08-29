namespace UMP.Loodsman.Dtos
{
    public class ObjectDto
    {
        public ObjectDto()
        {
            Type = new TypeDto();
        }

        public long IdVersion { get; set; }

        public string TypeName
        {
            get => Type.Name;
            set => Type.Name = value;
        }

        public string Product
        {
            get => Type.Product;
            set => Type.Product = value;
        }

        public TypeDto Type { get; set; }

        public string Version { get; set; }

        public string ProductValue { get; set; } 

        public string State { get; set; }
    }
}
