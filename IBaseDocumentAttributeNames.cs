using System;
using System.Collections.Generic;
using System.Text;

namespace UMP.Loodsman.Dtos
{
    public interface IBaseDocumentAttributeNames : IEnumerable<string>
    {
        string Author { get; }

        string AuthorDepartment { get; }

        string ReceiverDepartment { get; }

        string Title { get; }
    }
}
