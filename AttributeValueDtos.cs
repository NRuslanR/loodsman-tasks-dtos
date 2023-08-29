using System;
using System.Collections;
using System.Collections.Generic;

namespace UMP.Loodsman.Dtos
{
    public partial class AttributeValueDtos : IEnumerable<KeyValuePair<string, AttributeValueDto>>
    {
        private IDictionary<string, AttributeValueDto> attributeValueDtos;
        private AttributeValues attributeValues;

        public AttributeValueDtos()
        {
            attributeValueDtos = new Dictionary<string, AttributeValueDto>();
            attributeValues = new AttributeValues(attributeValueDtos);
        }

        public IEnumerator<KeyValuePair<string, AttributeValueDto>> GetEnumerator() => attributeValueDtos.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); 
        }

        public AttributeValueDto this[string name]
        {
            get => attributeValueDtos[name];
            set => attributeValueDtos[name] = value;
        }

        public AttributeValues Values { get; set; }

        public AttributeValueDto NewAttributeValue(string name, object value = null) => new AttributeValueDto
        {
            Attribute = new AttributeDto
            {
                Name = name
            },
            Value = value
        };

        public bool Contains(string attributeName) => attributeValueDtos.ContainsKey(attributeName);
    }
}
