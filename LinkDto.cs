using System;
using System.Collections.Generic;
using System.Text;

namespace UMP.Loodsman.Dtos
{
    public class LinkDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string InverseName { get; set; }

        public int Type { get; set; }
    }
}
