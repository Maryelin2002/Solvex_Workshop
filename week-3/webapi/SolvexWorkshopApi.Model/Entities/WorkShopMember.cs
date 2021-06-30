using SolvexWorkshopApi.Core.BaseModel;
using SolvexWorkshopApi.Core.Enums;
using System;

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

        public int? PhotoId { get; set; }
        public virtual Document Photo { get; set; }
    }
}
