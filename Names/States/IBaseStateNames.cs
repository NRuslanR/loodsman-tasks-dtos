using System;
using System.Collections.Generic;
using System.Text;

namespace UMP.Loodsman.Dtos.Names.States
{
    public interface IBaseStateNames
    {
        string DesigningStateName { get; }

        string ApprovingStateName { get; } 

        string ApprovedStateName { get; } 

        string ReworkingStateName { get; }

        string AffirmedStateName { get; } 
    }
}
