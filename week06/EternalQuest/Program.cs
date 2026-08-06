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