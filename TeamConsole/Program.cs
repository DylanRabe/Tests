// See https://aka.ms/new-console-template for more information

using PlayerDomain.DataModel;

using PlayerDomain.classes;
using Microsoft.EntityFrameworkCore;

/*
using (PlayerContext context = new PlayerContext())
{
    context.Database.EnsureCreated();
}

GetClasses();
//AddPlayer();
RemovePlayer();
GetClasses();

/*
AddPlayerWithStats();
void AddPlayerWithStats()
    {
    var player = new Player { FirstName = "Mark", LastName = "Evans", Team = "In-nova" };
    player.StatsForPlayer.Add(new StatsType {});

    using var context = new PlayerContext();
    context.Player.Add(player); //ajoute le nouvel objet au player Dbset
    context.SaveChanges();
}

void GetPlayerWithStats()
{
    using var context = new PlayerContext();
    var player = context.Player.Include(x => x.StatsForPlayer).ToList();
    foreach (var StatsType in PlayerStats)
    {
        
    }
}
*/

//creer un nouvel player objet 
/*
void AddPlayer()
{
    var player = new Player { FirstName = "Dylan", LastName = "Richardson", Team = "In-nova" };
    using var context = new PlayerContext();
    context.Player.Add(player); //ajoute le nouvel objet au player Dbset
    context.SaveChanges();
}
*/

/*
void RemovePlayer()
{
    var player = new Player { FirstName = "Dylan", LastName = "Richardson", Team = "In-nova" };
    using var context = new PlayerContext();
    context.Player.Remove(player);
    context.SaveChanges();
}
void GetClasses()
{
    using var context = new PlayerContext();
    var Classes = context.Player.ToList();
    foreach (var Player in Classes)
    {
        Console.WriteLine(Player.FirstName + " " + Player.LastName + " " + Player.Team);
    }
}
*/