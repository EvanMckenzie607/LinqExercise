using System.Linq;
using PracticeLinq;


var videoGames = new List<>();

var gameOne = new VideoGames
{
    Name = "God Of War",
    Rating = "M",
    Price = 69.99
};
var gameTwo = new VideoGames { Name = "Horizon Forbidden West", Rating = "M", Price = 59.99 };
var gameThree = new VideoGames
{
    Name = "Saints Row",
    Rating = "M",
    Price = 44.99
};

videoGames.Add(gameOne);