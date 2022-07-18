using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4__Abstract_classes_and_Interfaces_
{
    class Program
    {
        static void Main(string[] args)
        {

            // TASK 1

            //abstracthandler abhandler = new xmlhandler();
            //abhandler.open();
            //abhandler.create();
            //abhandler.change();
            //abhandler.save();

            //console.writeline();

            //abhandler = new txthandler();
            //abhandler.open();
            //abhandler.create();
            //abhandler.change();
            //abhandler.save();

            //console.writeline();

            //abhandler = new dochandler();
            //abhandler.open();
            //abhandler.create();
            //abhandler.change();
            //abhandler.save();

            // TASK 2 

            IPlayable playable = new Player();
            playable.Play();
            playable.Pause();
            playable.Stop();

            IRecordable recordable = new Player();
            recordable.Record();
            recordable.Pause();
            recordable.Stop();
        }
    }
}
