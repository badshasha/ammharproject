using System.ComponentModel.DataAnnotations;

namespace simpleproject.app.Model.Repository.BaseClass
{
    public abstract class BaseInfoRepo
    {
        [Key]
        public int Id { get; set; }
    }
}
