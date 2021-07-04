

using Microsoft.EntityFrameworkCore;

namespace SolvexWorkshopApi.Model.Entities
{
    [Keyless]
    public class Document
    {
        public string FileName { get; set; } //file-store name
        public string OriginalName { get; set; } //selected file
        public string ContentType { get; set; }
    }
}
