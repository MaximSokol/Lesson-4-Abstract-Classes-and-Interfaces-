using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4__Abstract_classes_and_Interfaces_
{
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("The play mode is active!");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("IPlayable.Pause();");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("IPlayable.Stop();");
        }

        public void Record()
        {
            Console.WriteLine("The record mode is active!");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("IRecordable.Pause();");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("IRecordable.Stop();");
        }
    }
}
