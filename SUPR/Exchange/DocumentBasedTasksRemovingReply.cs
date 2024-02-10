using System;
using System.Collections.Generic;
using System.Text;

namespace UMP.Loodsman.Dtos.SUPR.Exchange
{
    public class DocumentBasedTasksRemovingReply : TaskManagingReply
    {
        public DocumentFullInfoDto DocumentFullInfo { get; set; }
    }
}
