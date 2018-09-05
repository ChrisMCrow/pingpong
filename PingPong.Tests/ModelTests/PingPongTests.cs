using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void PingPongNumbers_ReturnUserInput_true()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual("4", testPingPong.IsPingPong("4"));
    }
    [TestMethod]
    public void PingPongNumbers_PingIsDivisibleBy3_true()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual("Ping", testPingPong.IsPingPong("3"));
    }
    [TestMethod]
    public void PingPongNumbers_PongIsDivisibleBy5_true()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual("Pong", testPingPong.IsPingPong("5"));
    }
    [TestMethod]
    public void PingPongNumbers_PingPongIsDivisbleBy3And5_true()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual("Ping-Pong", testPingPong.IsPingPong("15"));
    }
    // [TestMethod]
    // public void PingPongNumbers_ReturnsRange_true()
    // {
    //   PingPongGenerator testPingPong = new PingPongGenerator();
    //   Assert.AreEqual({"Pong", "4", "Ping", "2", "1"}, testPingPong.IsPingPong("5") )
    // }
  }
}
