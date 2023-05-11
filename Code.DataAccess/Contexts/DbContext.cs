using Code.Core.Entities;

namespace Code.DataAccess.Contexts;

public static class DbContext
{
    public static List<Student> Students = new ();
    public static List<Group> Groups = new();
    public static List<GroupType> Types = new();
}
