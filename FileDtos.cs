using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UMP.Loodsman.Dtos
{
    public class FileDtos : IEnumerable<FileDto>
    {
        private ICollection<FileDto> fileDtos;

        public FileDtos(IEnumerable<FileDto> source) 
        {
            fileDtos = new List<FileDto>(source);
        }

        public FileDtos()
        {
            fileDtos = new List<FileDto>();
        }

        public bool Contains(FileDto fileInfo) => fileDtos.Contains(fileInfo);

        public void Add(FileDto fileInfo) => fileDtos.Add(fileInfo);

        public void Remove(FileDto fileInfo) => fileDtos.Remove(fileInfo);

        public void Clear() => fileDtos.Clear();

        public IEnumerator<FileDto> GetEnumerator() => fileDtos.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
