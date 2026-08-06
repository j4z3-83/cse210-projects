//I implemented a leveling system that tracks you points and levels you up every 1000 points. the Threshold is saved a a variable making it easy to change the amount of points needed.

using System;
using System.Net.Quic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();
        gm.Start();        
    }
}