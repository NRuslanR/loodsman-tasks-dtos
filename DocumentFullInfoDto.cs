using System;
using System.Collections.Generic;
using System.Text;

namespace UMP.Loodsman.Dtos
{
    public class DocumentFullInfoDto : BaseCompanionObjects
    {
        public DocumentFullInfoDto()
        {
            Document = new DocumentDto();
            Files = new FileDtos();
        }

        public DocumentDto Document { get; set; }

        public FileDtos Files { get; set; }
    }
}
