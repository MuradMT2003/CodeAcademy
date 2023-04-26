using CodeAcademy;

Student s=new Student()
{
    Name="Murad",
    Surname="Mammadzada"
};
Group group = new Group(1,5);
group.AddStudent(s);
group.GetStudents();

