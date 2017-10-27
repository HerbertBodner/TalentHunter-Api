using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaCore.TalentHunter.Utils.Enums;
using WaCore.TalentHunter.Dtos;

namespace WaCore.TalentHunter.Api.Controllers
{
    [Route("api/[controller]")]
    public class CandidatesController : Controller
    {
        [HttpGet]
        public IEnumerable<CandidateDto> Get()
        {
            return new List<CandidateDto>() {
                new CandidateDto {
                    Id = 1,
                    FirstName = "Max",
                    LastName = "Mustermann",
                    Birthday = new DateTime(1974, 1,23),
                    AssessmentCategory = AssessmentCategoryEnum.PARTIALLY_MEETS_HIRING_STANDARDS,
                    AttachementList = new List<AttachementDto>() {
                        new AttachementDto {
                            FileName = "CV.pdf",
                            Path = "/assets/CV_Max_Mustermann.pdf",
                            PreviewImagePath = "/assets/CV_Max_Mustermann.png"
                        }
                    }
                },
                new CandidateDto {
                    Id = 2,
                    FirstName = "John",
                    LastName = "Doe",
                    Birthday = new DateTime(1992, 12, 3),
                    AssessmentCategory = AssessmentCategoryEnum.IDEALLY_MEETS_HIRING_STANDARDS, 
                    AttachementList = new List<AttachementDto>() {
                        new AttachementDto {
                            FileName = "Lebenslauf.pdf",
                            Path = "/assets/CV_John_Doe.pdf",
                            PreviewImagePath = "/assets/CV_John_Doe.jpg"},
                        new AttachementDto {
                            FileName = "Certificate.pdf",
                            Path = "/assets/CV_John_Doe_certificate.pdf",
                            PreviewImagePath = "/assets/CV_John_Doe_certificate.gif"}
                    }
                }
            };
        }
    }
}
