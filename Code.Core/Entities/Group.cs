using Code.Core.Interfaces;
using System.Xml.Linq;

namespace Code.Core.Entities;

public class Group : IEntity
{
    static int _id;
    public int GroupId { get; }
    public string GroupName { get; set; }
    public int GroupTypeId { get; set; }
    public int Capacity { get; set; }
    public Group()
    {
        GroupId = _id;
        _id++;
    }
    public Group(string name,int capacity) : this()
    {
        GroupName = name;
        Capacity = capacity;
      
    }



}
    

