using System.Collections.Generic;

namespace UMP.Loodsman.Dtos.SUPR.Exchange
{
    public class NewDocumentBasedTasksCreationRequest : TaskManagingRequest
    {
        public NewDocumentBasedTasksCreationRequest(DocumentFullInfoDto newDocumentFullInfo, IEnumerable<NewTaskDto> newTasks)
        {
            DocumentFullInfo = newDocumentFullInfo;
            NewTasks = newTasks;
        }

        public NewDocumentBasedTasksCreationRequest() { }

        public DocumentFullInfoDto DocumentFullInfo { get; set; }

        public IEnumerable<NewTaskDto> NewTasks { get; set; }
    }
}
