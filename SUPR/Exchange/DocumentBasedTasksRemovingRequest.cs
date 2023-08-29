namespace UMP.Loodsman.Dtos.SUPR.Exchange
{
    public class DocumentBasedTasksRemovingRequest : TaskManagingRequest
    {
        public DocumentBasedTasksRemovingRequest() { }

        public DocumentDto Document { get; set; }

        public DocumentRemovingPolicy DocumentRemovingPolicy { get; set; }
    }
}
