using System.Collections.Generic;

namespace UMP.Loodsman.Dtos.SUPR.Exchange
{
    public class TaskManagingReply
    {
        public static TaskManagingReply WithUnprocessableRequest(object requestId)
        {
            return new TaskManagingReply { RequestId = requestId, Result = TaskManagingRequestProcessingResult.RequestUnprocessable };
        }

        public object RequestId { get; set; }

        public TaskManagingRequestProcessingResult Result { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}
