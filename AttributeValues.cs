using System.Collections;
using System.Collections.Generic;

namespace UMP.Loodsman.Dtos
{
    public partial class AttributeValueDtos
    {
        public class AttributeValues : IEnumerable<KeyValuePair<string, object>>
        {
            private IDictionary<string, AttributeValueDto> attributeValueDtos;

            internal AttributeValues(IDictionary<string, AttributeValueDto> attributeValueDtos)
            {
                this.attributeValueDtos = attributeValueDtos;
            }

            public IEnumerator<KeyValuePair<string, object>> GetEnumerator() =>
                new AttributeValuesEnumerator(attributeValueDtos.GetEnumerator());

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public object this[string name]
            {
                get => attributeValueDtos[name].Value;
                set => attributeValueDtos[name].Value = value;
            }
        }

        public class AttributeValuesEnumerator : IEnumerator<KeyValuePair<string, object>>
        {
            private IEnumerator<KeyValuePair<string, AttributeValueDto>> internalEnumerator;

            internal AttributeValuesEnumerator(IEnumerator<KeyValuePair<string, AttributeValueDto>> internalEnumerator)
            {
                this.internalEnumerator = internalEnumerator;
            }

            public bool MoveNext() => internalEnumerator.MoveNext();

            public void Reset() => internalEnumerator.Reset();

            public KeyValuePair<string, object> Current =>
                new KeyValuePair<string, object>(internalEnumerator.Current.Key,
                    internalEnumerator.Current.Value.Value);

            object IEnumerator.Current => Current;

            public void Dispose() => internalEnumerator.Dispose();
        }
    }
}
