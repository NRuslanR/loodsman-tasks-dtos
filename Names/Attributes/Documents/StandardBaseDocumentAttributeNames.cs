using System.Collections;
using System.Collections.Generic;
using UMP.Loodsman.Dtos.Names.Attributes;

namespace UMP.Loodsman.Dtos.Names.Attributes.Documents
{
    public class StandardBaseDocumentAttributeNames : IBaseDocumentAttributeNames
    {
        private readonly IBaseAttributeNames baseAttributeNames;

        public StandardBaseDocumentAttributeNames(IBaseAttributeNames baseAttributeNames)
        {
            this.baseAttributeNames = baseAttributeNames;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return baseAttributeNames.GetEnumerator(Author, AuthorDepartment, ReceiverDepartment, Title, Note,
                SheetCount);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public string Author => baseAttributeNames.Author;

        public string AuthorDepartment => baseAttributeNames.AuthorDepartment;

        public string ReceiverDepartment => baseAttributeNames.ReceiverDepartment;

        public string Title => baseAttributeNames.Title;

        public string Note => baseAttributeNames.Note;

        public string SheetCount => baseAttributeNames.SheetCount;
    }
}