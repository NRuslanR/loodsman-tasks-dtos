using System;
using System.Collections.Generic;
using System.Text;

namespace UMP.Loodsman.Dtos
{
    public class ConstantBaseAttributeNames : BaseAttributeNames
    {
        private const string AUTHOR = "Разработал";
        private const string AUTHOR_DEPARTMENT = "Подразделение-разработчик";
        private const string RECEIVER_DEPARTMENT = "Подразделение-адресат";
        private const string TITLE = "Наименование";

        public override string Author => AUTHOR;

        public override string AuthorDepartment => AUTHOR_DEPARTMENT;

        public override string ReceiverDepartment => RECEIVER_DEPARTMENT;

        public override string Title => TITLE;
    }
}
