using System;
using System.Collections.Generic;
using System.Text;
using WaCore.TalentHunter.Utils.Enums;

namespace WaCore.TalentHunter.Dtos
{
    public class CandidateDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public AssessmentCategoryEnum AssessmentCategory { get; set; }
        public List<AttachementDto> AttachementList { get; set; }
    }
}
