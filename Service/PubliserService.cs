using simpleproject.app.data;
using simpleproject.app.data.ProgrameInterface;
using simpleproject.app.Model.Repository;

namespace simpleproject.app.Service
{
    public class PubliserService : IPublisherRepo
    {
        private readonly ApplicationDbContext _context;

        public PubliserService(ApplicationDbContext context)
        {
            this._context = context;
        }
  

        public Publisher Create(Publisher objectinfo)
        {
            throw new NotImplementedException();
        }

        public void Delete(Publisher objectinfo)
        {
            throw new NotImplementedException();
        }

        public Publisher Get(int id)
        {
            var value = this._context.Publishers.Where(x => x.Id == id).FirstOrDefault();
            if (value == null) throw new Exception();
            return value;
        }

        public List<Publisher> GetAll()
        {
            return this._context.Publishers.ToList();  
        }

        public Publisher Update(Publisher objectinfo)
        {
            throw new NotImplementedException();
        }
    }
}
