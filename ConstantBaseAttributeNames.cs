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
        private const string NOTE = "Комментарий";
        private const string SHEET_COUNT = "Количество листов";

        public override string Author => AUTHOR;

        public override string AuthorDepartment => AUTHOR_DEPARTMENT;

        public override string ReceiverDepartment => RECEIVER_DEPARTMENT;

        public override string Title => TITLE;

        public override string Note => NOTE;

        public override string SheetCount => SHEET_COUNT;
    }
}
