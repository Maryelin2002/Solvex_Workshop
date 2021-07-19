using SolvexWorkshopApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolvexWorkshopApi.Services.Services
{
    public interface IDocumentService
    {
        IEnumerable<Document> GetAllDocuments();

        Document GetDocument(int id);
        void InsertDocument(Document document);
        void UpdateDocument(Document document);
        void DeleteDocument(int id);
    }
}
