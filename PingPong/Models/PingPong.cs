using System;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPongGenerator
  {
    public string IsPingPong(string userInput)
    {
      int intUserInput = int.Parse(userInput);
      if (intUserInput % 3 == 0 && intUserInput % 5 == 0)
      {
        return "Ping-Pong";
      }
      else if (intUserInput % 5 == 0)
      {
        return "Pong";
      }
      else if (intUserInput % 3 == 0)
      {
        return "Ping";
      }
      else
      {
        return userInput;
      }
    }
  }
}
