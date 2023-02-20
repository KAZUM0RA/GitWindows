using VpuDotnet.Entities;
using VpuDotnet.Contexts;
using System.Text.Json;

// var user = new User {
//     Username = "banderveloper",
//     PasswordHash = " qwerty",
//     FullName = "Sanya  "
// };
// Console.WriteLine(JsonSerializer.Serialize(user));
//------------------------------
// var context = new UserContext();
// context.Create(new User
// {
//     Username = "Kazumora",
//     PasswordHash = " qwerty",
//     FullName = "Sania ",
// });
// context.Create(new User
// {
//     Username = "sdfsf",
//     PasswordHash = " qwerty",
//     FullName = "Kloly ",
// });
// context.Save();
// ------------------------
var context = new CarContext();
context.Create(new Car
{
    markName = "Ford",
    model = "Cadette",
    year = 1984,
});
context.Create(new Car
{
    markName = "Opel",
    model = "Astra",
    year = 2013,
});
context.Create(new Car
{
    markName = "Jeep",
    model = "Classic",
    year = 2001,
});
context.Create(new Car
{
    markName = "Fiat",
    model = "Doblo",
    year = 2009,
});


context.Save();