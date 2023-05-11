using Code.Core.Entities;

namespace Code.Business.Interfaces;

public interface IGroupTypeService
{
    void Create(string type);
    void Delete(string type);
    GroupType GetById(int id);
    List<GroupType> GetAll();
    

}
