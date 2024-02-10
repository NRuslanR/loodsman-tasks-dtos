using System;
using System.Collections.Generic;
using System.Text;

namespace UMP.Loodsman.Dtos.Names.States
{
    public class ConstantBaseStateNames : IBaseStateNames
    {
        public string DesigningStateName { get; } = "Проектирование";

        public string ApprovingStateName { get; } = "Согласование";

        public string ApprovedStateName { get; } = "Согласовано";

        public string ReworkingStateName { get; } = "Доработка";

        public string AffirmedStateName { get; } = "Утвержден";
    }
}
