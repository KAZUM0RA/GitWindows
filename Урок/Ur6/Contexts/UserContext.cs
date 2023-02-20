using VpuDotnet.Entities;
using System.Text.Json;
namespace VpuDotnet.Contexts;


public class UserContext : IContext<User>
{
    private string _fileName = "users.json";
    // private StringWriter _witer;
    // private StringReader _reader;
    private List<User> _user;
    public UserContext()
    {
        if (!File.Exists(_fileName))
        {
            File.Create(_fileName);
        }
        var reader = new StreamReader(_fileName);

        string fileContent = reader.ReadToEnd();
        reader.Close();
        if (fileContent.Length < 2)
        {
            _user = new List<User>();
        }
        else
        {
            _user = JsonSerializer.Deserialize<List<User>>(fileContent);
        }
    }
    public void Save()
    {
        string json = JsonSerializer.Serialize(_user);
        var write = new StreamWriter(_fileName);
        write.Write(json);
        write.Close();
    }
    public void Create(User entity)
    {
        _user.Add(entity);
    }

    public void Delete(Guid id)
    {
        _user.RemoveAll(user => user.Id == id);

    }

    public void Delete(User entity)
    {
        Delete(entity.Id);
    }

    public IEnumerable<User> GetAll()
    {
        return _user;

    }

    public void Update(User entity)
    {
        var user = _user.FirstOrDefault(user => user.Id == entity.Id);
        if (user is null)
            throw new ArgumentException("error");
        user.Username = entity.Username;
        user.PasswordHash = entity.PasswordHash;
        user.FullName = entity.FullName;
    }
}