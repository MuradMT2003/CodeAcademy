namespace Code.Core.Entities;

public class GroupType
{
    static int _id;
    public int GroupTypeId { get; }
    public string Type { get; set; }
    public GroupType()
    {
        GroupId = _id;
        _id++;
    }
    public GroupType(string type) : this()
    {
        Type = type;

    }
}
