using System.Collections.Generic;

namespace UMP.Loodsman.Dtos.SUPR.Exchange
{
    public class NewDocumentBasedTasksCreationRequest : TaskManagingRequest
    {
        public NewDocumentBasedTasksCreationRequest(DocumentDto newDocument, IEnumerable<NewTaskDto> newTasks)
        {
            NewDocument = newDocument;
            NewTasks = newTasks;
        }

        public NewDocumentBasedTasksCreationRequest() { }

        public DocumentDto NewDocument { get; set; }

        public AttributeValueDtos NewDocumentAttributeValues { get; set; }

        public FileDtos NewDocumentFiles { get; set; }

        public ObjectDto NewDocumentParentObject { get; set; }

        public LinkDto NewDocumentParentObjectLink { get; set; }

        public IEnumerable<NewTaskDto> NewTasks { get; set; }
    }
}
