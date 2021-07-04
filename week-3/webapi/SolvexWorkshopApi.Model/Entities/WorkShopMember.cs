using SolvexWorkshopApi.Core.BaseModel;
using SolvexWorkshopApi.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolvexWorkshopApi.Model.Entities
{
    public class WorkShopMember : BaseEntity
    {
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public WorkShopMemberDocumentType DocumentType { get; set; }
        public string DocumentTypeValue { get; set; }
        public Gender Gender { get; set; }
        public DateTime? Dob { get; set; }

        [NotMapped]
        public int? PhotoId { get; set; }
        [NotMapped]
        public virtual Document Photo { get; set; }
    }
}
