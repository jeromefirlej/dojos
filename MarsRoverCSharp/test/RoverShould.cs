using Xunit;

namespace MarsRoverCSharp.Test
{
    public class RoverShould
    {
        private readonly Rover rover;
        public RoverShould()
        {
            rover = new Rover();
        }

        [Fact]
        public void Return00N_WhenReceiveStringEmpty()
        {
            var position = rover.Move(string.Empty);
            Assert.Equal("0:0:N", position);
        }

        [Fact]
        public void Return01N_WhenReceiveF()
        {
            var position = rover.Move("F");
            Assert.Equal("0:1:N", position);
        }

        [Fact]
        public void Return02N_WhenReceiveFF()
        {
            var position = rover.Move("FF");
            Assert.Equal("0:2:N", position);
        }

        [Fact]
        public void Return03N_WhenReceiveFFF()
        {
            var position = rover.Move("FFF");
            Assert.Equal("0:3:N", position);
        }

        [Fact]
        public void Return00W_WhenReceiveL()
        {
            var position = rover.Move("L");
            Assert.Equal("0:0:W", position);
        }

        [Fact]
        public void Return00S_WhenReceiveLL()
        {
            var position = rover.Move("LL");
            Assert.Equal("0:0:S", position);
        }

        [Fact]
        public void Return00E_WhenReceiveLLL()
        {
            var position = rover.Move("LLL");
            Assert.Equal("0:0:E", position);
        }

        [Fact]
        public void Return00N_WhenReceiveLLLL()
        {
            var position = rover.Move("LLLL");
            Assert.Equal("0:0:N", position);
        }

        [Fact]
        public void Return00E_WhenReceiveR()
        {
            var position = rover.Move("R");
            Assert.Equal("0:0:E", position);
        }

        [Fact]
        public void Return00S_WhenReceiveRR()
        {
            var position = rover.Move("RR");
            Assert.Equal("0:0:S", position);
        }

        [Fact]
        public void Return00W_WhenReceiveRRR()
        {
            var position = rover.Move("RRR");
            Assert.Equal("0:0:W", position);
        }

        [Fact]
        public void Return00N_WhenReceiveRRRR()
        {
            var position = rover.Move("RRRR");
            Assert.Equal("0:0:N", position);
        }

        [Fact]
        public void Return10E_WhenReceiveRF()
        {
            var position = rover.Move("RF");
            Assert.Equal("1:0:E", position);
        }

        [Fact]
        public void Return00E_WhenReceiveRFFFFFFFFFF()
        {
            var position = rover.Move("RFFFFFFFFFF");
            Assert.Equal("0:0:E", position);
        }

        [Fact]
        public void Return09S_WhenReceiveRRF()
        {
            var position = rover.Move("RRF");
            Assert.Equal("0:9:S", position);
        }

        [Fact]
        public void Return08S_WhenReceiveRRFF()
        {
            var position = rover.Move("RRFF");
            Assert.Equal("0:8:S", position);
        }

        [Fact]
        public void Return90S_WhenReceiveRRRF()
        {
            var position = rover.Move("RRRF");
            Assert.Equal("9:0:W", position);
        }

        [Fact]
        public void Return80S_WhenReceiveRRRFF()
        {
            var position = rover.Move("RRRFF");
            Assert.Equal("8:0:W", position);
        }

        [Fact]
        public void Return00N_WhenReceiveFFFFFFFFFF()
        {
            var position = rover.Move("FFFFFFFFFF");
            Assert.Equal("0:0:N", position);
        }
    }
}
