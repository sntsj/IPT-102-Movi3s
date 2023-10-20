using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
            new MovieViewModel {
                Id = 575264,
                Title = "Mission: Impossible - Dead Reckoning Part One",
                Genre = "Action, and Thriller",
                Overview = "Ethan Hunt and his IMF team embark on their most dangerous mission yet: To track down a terrifying new weapon that threatens all of humanity before it falls into the wrong hands. With control of the future and the world's fate at stake and dark forces from Ethan's past closing in, a deadly race around the globe begins. Confronted by a mysterious, all-powerful enemy, Ethan must consider that nothing can matter more than his mission—not even the lives of those he cares about most.",
                Popularity = "1937.188",
                PosterPath = "https://www.themoviedb.org/t/p/w220_and_h330_face/NNxYkU70HPurnNCSiCjYAmacwm.jpg",
                ReleaseDate = "July 8, 2023",
                VoteAverage = "70"
            },
            new MovieViewModel {
                Id = 299054,
                Title = "Expend4bles",
                Genre = "Action, Adventure, and Thriller",
                Overview = "Armed with every weapon they can get their hands on and the skills to use them, The Expendables are the world’s last line of defense and the team that gets called when all other options are off the table. But new team members with new styles and tactics are going to give “new blood” a whole new meaning.",
                Popularity = "1489.424",
                PosterPath = "https://www.themoviedb.org/t/p/w220_and_h330_face/iwsMu0ehRPbtaSxqiaUDQB9qMWT.jpg",
                ReleaseDate = "September 15, 2023",
                VoteAverage = "60"
            },
            new MovieViewModel {
                Id = 926393,
                Title = "The Equalizer 3",
                Genre = "Action, Thriller, and Crime",
                Overview = "Robert McCall finds himself at home in Southern Italy but he discovers his friends are under the control of local crime bosses. As events turn deadly, McCall knows what he has to do: become his friends' protector by taking on the mafia.",
                Popularity = "1298.016",
                PosterPath = "https://www.themoviedb.org/t/p/w220_and_h330_face/b0Ej6fnXAP8fK75hlyi2jKqdhHz.jpg",
                ReleaseDate = "August 30, 2023",
                VoteAverage = "70"
            },
            new MovieViewModel {
                Id = 968051,
                Title = "The Nun II",
                Genre = "Horror, Mystery, and Thriller",
                Overview = "In 1956 France, a priest is violently murdered, and Sister Irene begins to investigate. She once again comes face-to-face with a powerful evil.",
                Popularity = "1168.675",
                PosterPath = "https://www.themoviedb.org/t/p/w220_and_h330_face/5gzzkR7y3hnY8AD1wXjCnVlHba5.jpg",
                ReleaseDate = "September 6, 2023",
                VoteAverage = "70"
            },
            new MovieViewModel {
                Id = 1008042,
                Title = "Talk to Me",
                Genre = "Horror, and Thriller",
                Overview = "When a group of friends discover how to conjure spirits using an embalmed hand, they become hooked on the new thrill, until one of them goes too far and unleashes terrifying supernatural forces.",
                Popularity = "814.198",
                PosterPath = "https://www.themoviedb.org/t/p/w220_and_h330_face/kdPMUMJzyYAc4roD52qavX0nLIC.jpg",
                ReleaseDate = "July 26, 2023",
                VoteAverage = "70"
            },
            new MovieViewModel {
                Id = 678512,
                Title = "Sound of Freedom",
                Genre = "Action, and Drama",
                Overview = "The story of Tim Ballard, a former US government agent, who quits his job in order to devote his life to rescuing children from global sex traffickers.",
                Popularity = "802.647",
                PosterPath = "https://www.themoviedb.org/t/p/w220_and_h330_face/qA5kPYZA7FkVvqcEfJRoOy4kpHg.jpg",
                ReleaseDate = "July 3, 2023",
                VoteAverage = "80"
            },
            new MovieViewModel {
                Id = 1151534,
                Title = "Nowhere",
                Genre = "Thriller, and Drama",
                Overview = "A young pregnant woman named Mia escapes from a country at war by hiding in a maritime container aboard a cargo ship. After a violent storm, Mia gives birth to the child while lost at sea, where she must fight to survive.",
                Popularity = "774.151",
                PosterPath = "https://www.themoviedb.org/t/p/w220_and_h330_face/uldNFFKNXNvwss0MIZErMSFkBJZ.jpg",
                ReleaseDate = "September 29, 2023",
                VoteAverage = "70"
            },
            new MovieViewModel {
                Id = 554600,
                Title = "Uri: The Surgical Strike",
                Genre = "Action, Drama, and War",
                Overview = "Following the roguish terrorist attacks at Uri Army Base camp in Kashmir, India takes the fight to the enemy, in its most successful covert operation till date with one and only one objective of avenging their fallen heroes.",
                Popularity = "745.931",
                PosterPath = "https://www.themoviedb.org/t/p/w220_and_h330_face/yNySAgpAnWmPpYinim9E0tUzJWG.jpg",
                ReleaseDate = "January 11, 2019",
                VoteAverage = "70"
            },
            new MovieViewModel {
                Id = 961268,
                Title = "Ballerina",
                Genre = "Action, Crime, and Thriller",
                Overview = "Grieving the loss of a best friend she couldn't protect, an ex-bodyguard sets out to fulfill her dear friend's last wish: sweet revenge.",
                Popularity = "654.626",
                PosterPath = "https://www.themoviedb.org/t/p/w220_and_h330_face/oE7xtGDqZnr7tFHfwb8oM9iRW6H.jpg",
                ReleaseDate = "October 5, 2023",
                VoteAverage = "60"
            },
            new MovieViewModel {
                Id = 615656,
                Title = "Meg 2: The Trench",
                Genre = "Action, Science Fiction, and Horror",
                Overview = "An exploratory dive into the deepest depths of the ocean of a daring research team spirals into chaos when a malevolent mining operation threatens their mission and forces them into a high-stakes battle for survival.",
                Popularity = "645.807",
                PosterPath = "https://www.themoviedb.org/t/p/w220_and_h330_face/4m1Au3YkjqsxF8iwQy0fPYSxE0h.jpg",
                ReleaseDate = "August 2, 2023",
                VoteAverage = "60"
            },
            new MovieViewModel {
                Id = 980489,
                Title = "Gran Turismo",
                Genre = "Adventure, Action, and Drama",
                Overview = "The ultimate wish-fulfillment tale of a teenage Gran Turismo player whose gaming skills won him a series of Nissan competitions to become an actual professional racecar driver.",
                Popularity = "640.879",
                PosterPath = "https://www.themoviedb.org/t/p/w220_and_h330_face/51tqzRtKMMZEYUpSYkrUE7v9ehm.jpg",
                ReleaseDate = "August 9, 2023",
                VoteAverage = "80"
            },
            new MovieViewModel {
                Id = 937249,
                Title = "57 Seconds",
                Genre = "Thriller, Science Fiction, and Action",
                Overview = "When a tech blogger lands an interview with a tech guru and stops an attack on him, he finds a mysterious ring that takes him back 57 seconds into the past.",
                Popularity = "621.631",
                PosterPath = "https://www.themoviedb.org/t/p/w220_and_h330_face/dfS5qHWFuXyZQnwYREwb7N4qU5p.jpg",
                ReleaseDate = "September 29, 2023",
                VoteAverage = "50"
            },
            new MovieViewModel {
                Id = 565770,
                Title = "Blue Beetle",
                Genre = "Action, Science Fiction, and Adventure",
                Overview = "Recent college grad Jaime Reyes returns home full of aspirations for his future, only to find that home is not quite as he left it. As he searches to find his purpose in the world, fate intervenes when Jaime unexpectedly finds himself in possession of an ancient relic of alien biotechnology: the Scarab.",
                Popularity = "591.014",
                PosterPath = "https://www.themoviedb.org/t/p/w220_and_h330_face/mXLOHHc1Zeuwsl4xYKjKh2280oL.jpg",
                ReleaseDate = "August 16, 2023",
                VoteAverage = "70"
            },
            new MovieViewModel {
                Id = 1034062,
                Title = "Mortal Kombat Legends: Cage Match",
                Genre = "Animation, Action, and Fantasy",
                Overview = "In 1980s Hollywood, action star Johnny Cage is looking to become an A-list actor. But when his costar, Jennifer, goes missing from set, Johnny finds himself thrust into a world filled with shadows, danger, and deceit. As he embarks on a bloody journey, Johnny quickly discovers the City of Angels has more than a few devils in its midst.",
                Popularity = "578.777",
                PosterPath = "https://www.themoviedb.org/t/p/w220_and_h330_face/1eKWqTHp4OgKdx1QX1O9LxKHr1M.jpg",
                ReleaseDate = "October 17, 2023",
                VoteAverage = "80"
            },
            new MovieViewModel {
                Id = 893723,
                Title = "PAW Patrol: The Mighty Movie",
                Genre = "Animation, Family, Action, and Science Fiction",
                Overview = "A magical meteor crash-lands in Adventure City, gives the PAW Patrol pups superpowers, and transforms them into The Mighty Pups. When the Patrol's archrival Humdinger breaks out of jail and teams up with mad scientist Victoria Vance to steal the powers for themselves, the Mighty Pups must save Adventure City and stop the supervillains before it's too late.",
                Popularity = "552.634",
                PosterPath = "https://www.themoviedb.org/t/p/w220_and_h330_face/aTvePCU7exLepwg5hWySjwxojQK.jpg",
                ReleaseDate = "September 21, 2023",
                VoteAverage = "70"
            }
        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

