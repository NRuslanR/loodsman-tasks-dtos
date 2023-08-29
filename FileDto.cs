using System;

namespace UMP.Loodsman.Dtos
{
    public class FileDto : IEquatable<FileDto>
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string LocalName { get; set; } 

        public DateTime CreationDateTime { get; set; }

        public long Size { get; set; }

        public long Crc { get; set; }

        public DateTime ModificationDateTime { get; set; }

        public int ReadOnly { get; set; }

        public override bool Equals(object obj) => Equals(obj as FileDto);

        public bool Equals(FileDto other) => other != null && base.Equals(other);
    }
}
