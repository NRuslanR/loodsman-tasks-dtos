using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UMP.Loodsman.Dtos
{
    public interface IBaseAttributeNames : IEnumerable<string>
    {
        string Author { get; }

        string AuthorDepartment { get; }

        string ReceiverDepartment { get; }

        string Title { get; }

        IEnumerator<string> GetEnumerator(params string[] enumerableAttributeNames);
    }

    public abstract class BaseAttributeNames : IBaseAttributeNames
    {
        public IEnumerator<string> GetEnumerator() => GetEnumerator(String.Empty);

        public IEnumerator<string> GetEnumerator(params string[] enumerableAttributeNames)
        {
            foreach (var attributeName in new string[] { Author, AuthorDepartment, ReceiverDepartment, Title })
            {
                if (enumerableAttributeNames.Contains(attributeName))
                    yield return attributeName;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public abstract string Author { get; }

        public abstract string AuthorDepartment { get; }

        public abstract string ReceiverDepartment { get; }

        public abstract string Title { get; }
    }
}
