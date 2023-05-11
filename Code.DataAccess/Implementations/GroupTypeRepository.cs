using Code.Core.Entities;
using Code.DataAccess.Contexts;

namespace Code.DataAccess.Implementations;

public class GroupTypeRepository:IRepository<GroupTypeRepository>
{
    public void Add(GroupType entity)
    {
        DbContext.Types.Add(entity);
    }
    public void Delete(GroupType entity)
    {
        DbContext.Types.Remove(entity);
    }
    public GroupType? Get(int id)
    {
        return DbContext.Types.Find(p => p.GroupTypeId == id);
    }
    public GroupType? GetByName(string type)
    {
        return DbContext.Types.Find(p => p.Type == type);
    }
    public List<GroupType> GetAll()
    {
        return DbContext.Types;
    }
    public void Update(GroupType entity)
    {
        var res = DbContext.Types.Find(p => p.GroupTypeId == entity.GroupTypeId);
        if (res != null)
        {
            res.Type=entity.Type;
        }
    }
}
