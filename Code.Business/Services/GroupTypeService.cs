using Code.Business.Exceptions;
using Code.Business.Helpers;
using Code.Business.Interfaces;
using Code.Core.Entities;
using Code.DataAccess.Implementations;

namespace Code.Business.Services;

public class GroupTypeService : IGroupTypeService
{
    public GroupTypeRepository  _groupTypeRepository { get;  }
    public GroupTypeService()
    {
        _groupTypeRepository = new GroupTypeRepository();
        
    }
    public void Create(string type)
    {
        var exist=_groupTypeRepository.GetByName(type);
        if (exist != null) {
            throw new AlreadyExistException(Helper.errors["AlreadyExistException"]);
        }
        string res = type.Trim();
        if (res.Length <= 2)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        GroupType groupType = new(type);
        _groupTypeRepository.Add(groupType);
    }

    public void Delete(string type)
    {
        throw new NotImplementedException();
    }

    public List<GroupType> GetAll()
    {
        throw new NotImplementedException();
    }

    public GroupType GetById(int id)
    {
        throw new NotImplementedException();
    }
}
