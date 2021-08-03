using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks; // Used for implementing async tasks.

namespace Training_C_Sharp.Classes.Programming_Concepts.Compiling
{
    /// <summary>
    /// Using "async" keyword allows the task to run in non-blocking(multi-thread) format. This can increase flexibility of execution.
    /// The "await" keyword is used for a task within the async function to state that that specific await task has to finish completely before the
    /// program will continue with the proceeding code line.
    /// 
    /// Example: async Task Approaching_Tee will be able to run as a multi-threaded (parallel) task. Task.Delay will need to completely finish running before
    /// the compiler moves to the next line of code due to Task.Delay being awaited. If it was not awaited, the compiler would just move on to the next line of code while the tasks was
    /// in the process of running.
    /// </summary>
    public class Golfing
    {
        public string playerName { get; set; }

        /// <summary>
        /// Function for approaching tee box.
        /// </summary>
        public async Task Approaching_Tee(string playerName)
        {
            this.playerName = playerName;
            Console.WriteLine($"{this.playerName} is walking up to the tee...");
            await Task.Delay(5000); // 5 sec to complete
            //Console.WriteLine($"{this.playerName} has walked up to the tee.");
        }


        /// <summary>
        /// Stance function for getting stance ready.
        /// </summary>
        public async Task Stance()
        {
            Console.WriteLine($"{this.playerName} is getting his/her stance ready...");
            await Task.Delay(2000); // 2 sec to complete
            //Console.WriteLine($"{this.playerName} has a good stance.");
        }


        /// <summary>
        /// Swing function for hitting the golf ball.
        /// </summary>
        public async Task Swing()
        {
            Console.WriteLine($"{this.playerName} is swinging the club...");
            await Task.Delay(6000); // 6 sec to compplete
            //Console.WriteLine($"{this.playerName} has hit the golf ball.");
        }

    }
}
