using System;
using System.Collections.Generic;

namespace UMP.Loodsman.Dtos.SUPR
{
    public class NewTaskDto
    {
        public NewTaskDto()
        {
            SubTasks = new List<NewTaskDto>();
            Attachments = new List<AttachmentDto>();
        }

        public UserDto Author { get; set; }

        public long CalcDirection { get; set; }

        public UserDto Checker { get; set; }

        public DateTime DateFinish { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime Deadline { get; set; }

        public string Description { get; set; } 

        public IEnumerable<AttachmentDto> Attachments { get; set; }

        public double Duration { get; set; }

        public ICollection<NewTaskDto> SubTasks { get; set; }

        public DateTime PlanDateFinish { get; set; }

        public DateTime PlanDateStart { get; set; }

        public double PlanDuration { get; set; }

        public long PlanFinishRestriction { get; set; }

        public long PlanStartRestriction { get; set; }

        public int Priority { get; set; }

        public long State { get; set; }

        public string Topic { get; set; }

        public UserDto Worker { get; set; }

        public bool WorkerIsTrusted { get; set; }
    }
}
