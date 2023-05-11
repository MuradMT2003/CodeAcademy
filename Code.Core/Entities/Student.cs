using Code.Core.Interfaces;

namespace Code.Core.Entities;

public class Student:IEntity
{
    static int _id;
    public int StudentId { get; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public Student()
    {
        StudentId = _id;
        _id++;
        
    }
    public Student(string name,string surName):this()
    {
        Name = name;
        SurName  =surName;
    }
}
