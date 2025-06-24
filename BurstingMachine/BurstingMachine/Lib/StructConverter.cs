using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace BurstingMachine.Lib
{
    public static class StructConverter
    {
        // Преобразует структуру в byte[]
        public static byte[] ToBytes<T>(T data) where T : struct
        {
            int size = Marshal.SizeOf<T>();
            byte[] arr = new byte[size];
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.StructureToPtr(data, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);

            return arr;
        }

        // Преобразует byte[] в структуру
        public static T FromBytes<T>(byte[] data) where T : struct
        {
            int size = Marshal.SizeOf<T>();
            if (data.Length < size)
                throw new ArgumentException("Недостаточно данных для структуры");

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.Copy(data, 0, ptr, size);
            T obj = Marshal.PtrToStructure<T>(ptr);
            Marshal.FreeHGlobal(ptr);

            return obj;
        }
    }
}
