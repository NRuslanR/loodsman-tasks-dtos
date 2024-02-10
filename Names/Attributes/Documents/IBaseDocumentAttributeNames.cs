using System.Collections.Generic;

namespace UMP.Loodsman.Dtos.Names.Attributes.Documents
{
    public interface IBaseDocumentAttributeNames : IEnumerable<string>
    {
        string Author { get; }

        string AuthorDepartment { get; }

        string ReceiverDepartment { get; }

        string Title { get; }

        string Note { get; }

        string SheetCount { get; }
    }
}