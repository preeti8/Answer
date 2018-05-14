namespace AnswerFrameworkTests.Core.Models
{
    public class Brand
{
    public string Name { get; set; }
    public string Url { get; set; }

    public Brand(string name, string url)
    {
        Name = name;
        Url = url;
    }
}
}
