using System;
using System.Collections.Generic;
using System.Text;

namespace UMP.Loodsman.Dtos
{
    public class ObjectFullInfoDto : BaseCompanionObjects
    {
        public ObjectFullInfoDto()
        {
            Object = new ObjectDto();
        }

        public ObjectDto Object { get; set; }
    }
}
