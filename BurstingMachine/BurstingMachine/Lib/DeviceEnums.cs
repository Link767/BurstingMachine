using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurstingMachine.Lib
{
    public enum ClampState : byte
    {
        Stop = 0,
        Up = 1,
        Down = 2
    }

    public enum DevCmdType : byte
    {
        Check = 0,
        Stop = 1,
        StartMeasurement = 2,
        GetResult = 3,
        GoToUp = 4,
        GoToDown = 5,
        Home = 6,
        SetHome = 7,
        GetConfig = 8,
        WriteConfig = 9
    }

    public enum GenStatus : byte
    {
        Standby = 0,
        Measure = 1,
        Error = 2
    }

}
