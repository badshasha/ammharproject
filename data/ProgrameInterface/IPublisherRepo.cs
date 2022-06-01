using simpleproject.app.Model.Repository;

namespace simpleproject.app.data.ProgrameInterface
{
    public interface IPublisherRepo
    {
        List<Publisher> GetAll();
        Publisher Get(int id);
        Publisher Create(Publisher objectinfo);
        Publisher Update(Publisher objectinfo);
        void Delete(Publisher objectinfo);       

        
    }
}
