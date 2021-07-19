using SolvexWorkshopApi.Model.Entities;
using System;
using System.Collections.Generic;
using SolvexWorkshopApi.Model.Repository;

namespace SolvexWorkshopApi.Services.Services
{
    public class DocumentService : IDocumentService
    {

        private IRepository<Document> _repository;

        public DocumentService(IRepository<Document> repository)
        {
            _repository = repository;
        }
        public void DeleteDocument(int id)
        {
            Document document = GetDocument(id);
            _repository.Remove(document);
            _repository.SaveChanges();
        }

        public IEnumerable<Document> GetAllDocuments()
        {
            return _repository.GetAll();
        }

        public Document GetDocument(int id)
        {
            return _repository.Get(id);
        }

        public void InsertDocument(Document document)
        {
            _repository.Insert(document);
        }

        public void UpdateDocument(Document document)
        {
            _repository.Update(document);
        }
    }
}
