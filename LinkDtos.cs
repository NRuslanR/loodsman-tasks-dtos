using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UMP.Loodsman.Dtos
{
    public class LinkDtos : IEnumerable<LinkDto>
    {
        private ICollection<LinkDto> linkDtos;

        public LinkDtos(IEnumerable<LinkDto> source)
        {
            linkDtos = new List<LinkDto>(source);
        }

        public LinkDtos()
        {
            linkDtos = new List<LinkDto>();
        }

        public bool Contains(LinkDto fileInfo) => linkDtos.Contains(fileInfo);

        public void Add(LinkDto fileInfo) => linkDtos.Add(fileInfo);

        public void Remove(LinkDto fileInfo) => linkDtos.Remove(fileInfo);

        public void Clear() => linkDtos.Clear();

        public IEnumerator<LinkDto> GetEnumerator() => linkDtos.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
