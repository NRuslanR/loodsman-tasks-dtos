using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UMP.Loodsman.Dtos
{
    public partial class AttributeValueDtos : IEnumerable<KeyValuePair<string, AttributeValueDto>>
    {
        private IDictionary<string, AttributeValueDto> attributeValueDtos;
        private AttributeValues attributeValues;

        public AttributeValueDtos(params Tuple<string, object>[] nameValuePairs) : this(nameValuePairs.AsEnumerable())
        {

        }

        public AttributeValueDtos(IEnumerable<Tuple<string, object>> nameValuePairs) : 
            this(nameValuePairs.Select(
                pair => 
                    new KeyValuePair<string, AttributeValueDto>(
                        pair.Item1, 
                        new AttributeValueDto { Name = pair.Item1, Value = pair.Item2}
                        )
                )
            )
        {
            
        }

        public AttributeValueDtos(IEnumerable<KeyValuePair<string, AttributeValueDto>> source) : 
            this(new Dictionary<string, AttributeValueDto>(
                source.ToDictionary(pair => pair.Key, pair => pair.Value)))
        {

        }

        public AttributeValueDtos() : this(new Dictionary<string, AttributeValueDto>())
        {
        }

        private AttributeValueDtos(IDictionary<string, AttributeValueDto> attributeValueDtos)
        {
            this.attributeValueDtos = attributeValueDtos;

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
            Name = name,
            Value = value
        };

        public bool Contains(string attributeName) => attributeValueDtos.ContainsKey(attributeName);
    }
}
