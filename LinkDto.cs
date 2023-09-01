using System;
using System.Collections.Generic;
using System.Text;

namespace UMP.Loodsman.Dtos
{
    public class LinkDto
    {
        public LinkDto()
        {
            Type = new LinkTypeDto();
        }

        public LinkTypeDto Type { get; set; }

        public long ParentVersionId { get; set; }

        public string ParentTypeName { get; set; }

        public string ParentProductValue { get; set; }

        public  string ParentVersion { get; set; }

        public long ChildVersionId { get; set; }

        public string ChildTypeName { get; set; }   

        public string ChildProductValue { get; set; }

        public string ChildVersion { get; set;}
    }
}
