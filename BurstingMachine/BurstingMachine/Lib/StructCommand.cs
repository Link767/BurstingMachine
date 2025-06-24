using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace BurstingMachine.Lib
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ProgHead20
    {
        public byte Marker;         // PRG_FLAG_20 = 20
        public DevCmdType CmdType;
        public ushort Length;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ShortCommand
    {
        public ProgHead20 Head;
        public byte Num;
        public byte Bcc;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MsrStatus
    {
        public GenStatus Status;
        public ClampState Clamp;
        public ushort CellRaw;      // TCellData assumed as ushort
        public short CurCoord;      // TCoordinate assumed as short
        public ushort MaxDetect;
        public ushort Spare;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct StatusReport
    {
        public ProgHead20 Head;
        public MsrStatus Status;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Spare;
        public byte Bcc;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ConfigStruct
    {
        public byte SamplePeriod;
        public byte CellType;
        public byte SpeedMeasure;       // TPercent assumed byte
        public byte SpeedMove;          // TPercent assumed byte
        public ushort TenzoCorrection;
        public ushort Signature;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ConfigOut
    {
        public ProgHead20 Head;
        public ConfigStruct Config;
        public byte Spare;
        public byte Bcc;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ResultQuery
    {
        public ProgHead20 Head;
        public ushort Offset;
        public ushort Quant;
        public byte Spare;
        public byte Bcc;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ResultCap
    {
        public ProgHead20 Head;
        public ushort Offset;
        public ushort MaxCount;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ResultData
    {
        public ResultCap Cap;
        public byte Spare;
        public byte Bcc;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RecElement
    {
        public short Distance;       // TCoordinate
        public ushort Cell;          // TCellData
    }
}
