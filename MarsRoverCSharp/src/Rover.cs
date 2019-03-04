using System.Linq;

namespace MarsRoverCSharp
{
    public class Rover
    {
        private const char Left = 'L';
        private const char Right = 'R';
        private const char Forward = 'F';
        private const string North = "N";
        private const string West = "W";
        private const string South = "S";
        private const string East = "E";
        private const int minimumValue = 0;
        private const int maximumValue = 9;

        private int abscisse = 0;
        private int ordonnnee = 0;
        private string orientation = North;

        public string Move(string directions)
        {
            directions
                .ToList()
                .ForEach(ExecuteDirection);
                                    
            return $"{abscisse}:{ordonnnee}:{orientation}";
        }

        private void ExecuteDirection(char direction)
        {
            switch (direction)
            {
                case Right:
                    GoRight();
                    break;
                case Left:
                    GoLeft();
                    break;
                case Forward:
                    GoForward();
                    break;
            }
        }

        private void GoForward()
        {
            switch (orientation)
            {
                case West:
                    abscisse = DontExitFromBoard(--abscisse);
                    break;
                case South:
                    ordonnnee = DontExitFromBoard(--ordonnnee);
                    break;
                case North:
                    ordonnnee = DontExitFromBoard(++ordonnnee);
                    break;
                case East:
                    abscisse = DontExitFromBoard(++abscisse);
                    break;
            }
        }

        private int DontExitFromBoard(int position)
        {
            if (position > maximumValue)
                return minimumValue;
            if (position < minimumValue)
                return maximumValue;
            return position;
        }

        private void GoLeft()
        {
            switch (orientation)
            {
                case West:
                    orientation = South;
                    break;
                case South:
                    orientation = East;
                    break;
                case North:
                    orientation = West;
                    break;
                case East:
                    orientation = North;
                    break;
            }
        }

        private void GoRight()
        {
            switch (orientation)
            {
                case East:
                    orientation = South;
                    break;
                case South:
                    orientation = West;
                    break;
                case North:
                    orientation = East;
                    break;
                case West:
                    orientation = North;
                    break;
            }
        }
    }
}
