using BurstingMachine.Win;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurstingMachine.Classes
{
    class MBClass
    {
        
        public static void Inf(string mess)
        {
            MessageInf messageInf = new MessageInf(mess);
            messageInf.Show();
        }
        public static void Err(string mess)
        {
            MessageErr messageErr = new MessageErr(mess);
            messageErr.Show();
        }
        public static void War(string mess)
        {
            MessageWar messageWar = new MessageWar(mess); 
            messageWar.Show();
        }
    }
}
