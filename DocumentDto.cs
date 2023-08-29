using System.Collections.Generic;

namespace UMP.Loodsman.Dtos
{
    public class DocumentDto
    {
        public DocumentDto()
        {
            Object = new ObjectDto();
        }

        public long IdVersion
        {
            get => Object.IdVersion;
            set => Object.IdVersion = value;
        }

        public string TypeName
        {
            get => Object.TypeName;
            set => Object.TypeName = value;
        }

        public string Product
        {
            get => Object.Product;
            set => Object.Product = value;
        }

        public string Version
        {
            get => Object.Version; 
            set => Object.Version = value;
        }

        public string ProductValue
        {
            get => Object.ProductValue;
            set => Object.ProductValue = value;
        }

        public string State
        {
            get => Object.State;
            set => Object.State = value;
        }

        public ObjectDto Object { get; set; }
    }
}
