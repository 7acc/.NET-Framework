using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndeDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Gubbe gubbe = new Gubbe { Stats = "Massa stats" };
            LevelUpClass Leveler = new LevelUpClass();
            QuestClass QS = new QuestClass();
            StatsClass SC = new StatsClass();

            Leveler.GubbeLeveledUp += QS.OnLevelUp;
            Leveler.GubbeLeveledUp += SC.OnLevelUp;

            Console.WriteLine("Gubbe stats:" + gubbe.Stats);
            Leveler.LevelUp(gubbe);
            Console.WriteLine("Gubbe stats:" + gubbe.Stats);
            Console.ReadKey();

            
        }


    }
    //-------------------------------------------------------------------------------
    public class LevelUpClass
    {
        //public delegate void GubbeLeveledUpEventHandler(object source, GubbeEventArgs args);
        //eventhandler
        //eventhandler<TeventArgs>
        public event EventHandler<GubbeEventArgs> GubbeLeveledUp;
        public void LevelUp(Gubbe gubbe)
        {
            //LevelUp logic 
            //..
            Console.WriteLine("Your Gubbe Leveled Up");
            Thread.Sleep(1001);

            OnLevelUp(gubbe);
        }

        protected virtual void OnLevelUp(Gubbe gubbe)
        {
            if (GubbeLeveledUp != null)
                GubbeLeveledUp(gubbe, new GubbeEventArgs() {Gubbe = gubbe});
        }
    }
    //------------------------------------------------------------------------------
    public class Gubbe
    {
        public string Stats { get; set; }
    }
    //------------------------------------------------------------------------------

    public class GubbeEventArgs : EventArgs
    {
        public Gubbe Gubbe { get; set; }
    }
    //------------------------------------------------------------------------------

    public class QuestClass
    {
        public void OnLevelUp(object source,GubbeEventArgs e)
        {
            Console.WriteLine("You have a new quest!" + e.Gubbe.Stats);
        }
    }

    public class StatsClass
    {
        public void OnLevelUp(object source, GubbeEventArgs e)
        {
            Console.WriteLine("Your stats has been raised" + e.Gubbe.Stats);
           RaiseStats((Gubbe)source);
        }

        public void RaiseStats(Gubbe gubbe)
        {
            gubbe.Stats = "MORE MASSA STATS";
        }
    }

}

