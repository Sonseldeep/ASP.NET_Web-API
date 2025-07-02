using System;
using System.Net.Sockets;

namespace WEBapi.Controllers.Models;

public static class UsersRepository
{
    public static List<UserData> Users { get; set; } = new()
{
    new() {
        Id = 1,
        Name = "Sandeep Shrestha",
        Email = "sandeep@example.com",
        Address="Kathmandu, Nepal",
    },
    new() {
        Id = 2,
        Name = "Ram Shrestha",
        Email = "sandeep@example.com",
        Address="Kathmandu, Nepal",
    },
    new() {
        Id = 3,
        Name = "Pawan Thapa",
        Email = "sandeep@example.com",
        Address="Kathmandu, Nepal",
    },
    new() {
        Id = 4,
        Name = "Hari Krishna",
        Email = "sandeep@example.com",
        Address="Kathmandu, Nepal",
    },

};

}
