using System;

public class Student
{
	public Student()
	{
		public int Id { get; set; }
	public string Name { get; set; }

	public Student(int id, string name)
	{
		this.Name = name;
		this.Id = id;
	}

}
}
