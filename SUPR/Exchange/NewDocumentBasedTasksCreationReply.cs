using System;
using System.Collections.Generic;
using System.Text;

namespace UMP.Loodsman.Dtos.SUPR.Exchange
{
    public class NewDocumentBasedTasksCreationReply : TaskManagingReply
    {
        public DocumentFullInfoDto DocumentFullInfo { get; set; }
    }
}
