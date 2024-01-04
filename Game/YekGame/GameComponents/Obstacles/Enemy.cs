//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

using Timer = System.Windows.Forms.Timer;

namespace YekGame.GameComponents.Obstacles
{
    public class Enemy : Obstacle
    {
        public static List<List<int>> locations = new List<List<int>>();

        public Enemy() : base(Image.FromFile("Assets\\enemy_paving.png"))
        {
        }

        public override List<(int, int)> DetermineObstacleLocations()
        {
            var tupleLocations = new List<(int, int)>();

            Random rnd = new Random();
            var x = 10;
            var y = rnd.Next(0, 3);

            locations.Add([x, y]);

            foreach (var location in locations)
            {
                var tupleLocation = (location[0], location[1]);
                tupleLocations.Add(tupleLocation);
            }

            return tupleLocations;
        }

        public override List<(int, int)> RefreshLocations()
        {
            var tupleLocations = new List<(int, int)>();

            foreach (var location in locations)
            {
                location[0] -= 1;

                var tupleLocation = (location[0], location[1]);
                tupleLocations.Add(tupleLocation);
            }

            return tupleLocations;
        }
    }
}
