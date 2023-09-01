using System;
using System.Collections.Generic;
using System.Text;

namespace UMP.Loodsman.Dtos
{
    public class BaseCompanionObjects
    {
        public BaseCompanionObjects()
        {
            AttributeValueList = new AttributeValueDtos();
            Links = new LinkDtos();
        }

        public AttributeValueDtos AttributeValueList { get; set; }

        public LinkDtos Links { get; set; }
    }
}
