using Code.Core.Entities;
using Code.Core.Interfaces;
using Code.DataAccess.Contexts;

namespace Code.DataAccess.Implementations;

public class StudentRepository : IRepository<Student>
{
    public void Add(Student entity)
    {
        DbContext.Students.Add(entity);
    }

    public void Delete(Student entity)
    {
        DbContext.Students.Remove(entity);
    }

    public Student? Get(int id)
    {
        return DbContext.Students.Find(p=>p.StudentId==id);
    }

    public List<Student> GetAll()
    {
        return DbContext.Students;
    }

    public void Update(Student entity)
    {
        var res= DbContext.Students.Find(p => p.StudentId == entity.StudentId);
        if (res != null)
        {
            res.Name = entity.Name;
            res.SurName = entity.SurName;
        }
    }
}
