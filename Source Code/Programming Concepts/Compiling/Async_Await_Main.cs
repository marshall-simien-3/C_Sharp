using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks; // Used for implementing async tasks.
using Training_C_Sharp.Classes.Programming_Concepts.Compiling;

namespace Training_C_Sharp
{
    class  Async_Await_Main
    {
        /// <summary>
        /// Synchronous vs. Asynchronous golfing routine.
        /// ***See Async_Await.cs for definition / explanation.***
        /// </summary>
        /// <param name="args"></param>
        static async Task Main(string[] args)
        {
            Golfing CallingClass = new Golfing();

            /* Synchronous code (blocking). Each task is started and awaited sequentially.
            Total execution time: (5 sec + 2 sec + 6 sec) ≈ 13 sec */
            DateTime timeStart = DateTime.Now; // Establish start time for timer.
            Console.WriteLine("Synchronous Code:");

            // Start then await each task individually.
            Task oneSync = CallingClass.Approaching_Tee("Marshall");
            await oneSync;
            Console.WriteLine($"{CallingClass.playerName} has walked up to the tee.");

            Task twoSync = CallingClass.Stance();
            await twoSync;
            Console.WriteLine($"{CallingClass.playerName} has a good stance.");

            Task threeSync = CallingClass.Swing();
            await threeSync;
            Console.WriteLine($"{CallingClass.playerName} has hit the golf ball.");

            DateTime timeFinish = DateTime.Now; // Establish finish time for timer.
            Console.WriteLine("Completion Timer: " + (timeFinish - timeStart).ToString());

            Console.WriteLine("\r\n");


            Task.Delay(2000).Wait(); // Wait 2 sec in between codes.


            /*Asynchronous code (non-blocking). All 3 tasks are first started, allowing their processes to begin processing in multi-threads.
            Then all 3 tasks are awaited. By that time the first of the 3 tasks is finished being awaited, most of the tasks are near completion.
            Total execution time: Largest of (5 sec, 2 sec, 6 sec) ≈ 6 sec */
            timeStart = DateTime.Now; 
            Console.WriteLine("Asynchronous Code:");

            // Begin calling all 3 tasks.
            Task oneAsync = CallingClass.Approaching_Tee("Marshall");
            Task twoAsync = CallingClass.Stance();
            Task threeAsync = CallingClass.Swing();

            // Begin Awaiting each task.
            await oneAsync;
            Console.WriteLine($"{CallingClass.playerName} has walked up to the tee."); //5 sec - First awaited task, done after 5 sec

            await twoAsync;
            Console.WriteLine($"{CallingClass.playerName} has a good stance."); // 2 sec - Finished before oneAsync finished awaiting.

            await threeAsync;
            Console.WriteLine($"{CallingClass.playerName} has hit the golf ball."); // 6 sec - Only executes one second after oneAsync finished being awaited (6 sec - 5 sec) = 1 sec.

            timeFinish = DateTime.Now;
            Console.WriteLine("Completion Timer: " + (timeFinish - timeStart).ToString());

            Console.ReadLine();
        }
    }
}
