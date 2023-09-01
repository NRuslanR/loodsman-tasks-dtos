using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UMP.Loodsman.Dtos
{
    public class LinkTypeDtos : IEnumerable<LinkTypeDto>
    {
        private ICollection<LinkTypeDto> linkTypeDtos;

        public LinkTypeDtos(IEnumerable<LinkTypeDto> source)
        {
            linkTypeDtos = new List<LinkTypeDto>(source);
        }

        public LinkTypeDtos()
        {
            linkTypeDtos = new List<LinkTypeDto>();
        }

        public bool Contains(LinkTypeDto fileInfo) => linkTypeDtos.Contains(fileInfo);

        public void Add(LinkTypeDto fileInfo) => linkTypeDtos.Add(fileInfo);

        public void Remove(LinkTypeDto fileInfo) => linkTypeDtos.Remove(fileInfo);

        public void Clear() => linkTypeDtos.Clear();

        public IEnumerator<LinkTypeDto> GetEnumerator() => linkTypeDtos.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
