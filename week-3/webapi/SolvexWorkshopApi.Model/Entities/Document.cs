

using Microsoft.EntityFrameworkCore;
using SolvexWorkshopApi.Core.BaseModel;

namespace SolvexWorkshopApi.Model.Entities
{
    [Keyless]
    public class Document : BaseEntity
    {
        public string FileName { get; set; } //file-store name
        public string OriginalName { get; set; } //selected file
        public string ContentType { get; set; }
    }
}
