using Moq;
using System.Threading.Tasks;

var moq = new Mock<IFoo>();
var res = moq.Setup(foo => foo.DosomethingStringy("One"));
System.Console.WriteLine(res);

public interface IFoo
{
    int Id { get; set; }
    string Name { get; set; }
    Bar Bar { get; set; }
    Task<bool> DosomethingAsync();
    string DosomethingStringy(string str);
}

public class Bar
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Baz
{
    public string Name { get; set; }
    public bool IsActive { get; set; }
}
