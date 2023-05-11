using Code.Core.Entities;
using Code.DataAccess.Contexts;

namespace Code.DataAccess.Implementations;

public class GroupRepository : IRepository<Group>
{
    public void Add(Group entity)
    {
        DbContext.Groups.Add(entity);
    }
    public void Delete(Group entity)
    {
        DbContext.Groups.Remove(entity);
    }
    public Group? Get(int id)
    {
        return DbContext.Groups.Find(p => p.GroupId == id);
    }
    public List<Group> GetAll()
    {
        return DbContext.Groups;
    }
    public void Update(Group entity)
    {
        var res = DbContext.Groups.Find(p => p.GroupId == entity.GroupId);
        if (res != null)
        {
            res.GroupName = entity.GroupName;
            res.Capacity = entity.Capacity;
            res.GroupTypeId = entity.GroupTypeId;
        }
    }
}


