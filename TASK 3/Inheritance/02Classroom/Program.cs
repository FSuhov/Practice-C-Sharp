using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Создать класс, представляющий учебный класс ClassRoom.
Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().
Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.
*/

namespace _02Classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom1 = new ClassRoom(new GoodPupil(), new ExcellentPupil(), new BadPupil(), new ExcellentPupil());
            classRoom1.ClassRoomInfo();
            ClassRoom classRoom2 = new ClassRoom(new GoodPupil(), new BadPupil());
            classRoom2.ClassRoomInfo();
        }
    }

    class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];

        public ClassRoom(params Pupil[] _pupils)
        {
            int numberOfPupils = _pupils.Length;
            for(int i = 0; i < numberOfPupils; i++)
            {
                if (_pupils[i] != null)
                {
                    pupils[i] = _pupils[i];
                }
            }
        }

        public void ClassRoomInfo()
        {
            Console.WriteLine(Utils.delimiter1);
            Console.WriteLine(this.GetType());
            for(int i = 0; i < 4; i++)
            {
                if (pupils[i] != null)
                {
                    pupils[i].PupilInfo();
                }
            }
        }
    }

    class Pupil
    {
        public virtual void Study() { Console.WriteLine("I can study..."); }
        public virtual void Read() { Console.WriteLine("I can read..."); }
        public virtual void Write() { Console.WriteLine("I can wite..."); }
        public virtual void Relax() { Console.WriteLine("I can relax..."); }
        public void PupilInfo()
        {
            Console.WriteLine(Utils.delimiter2);
            Console.WriteLine("\t" + this.GetType());
            Study();
            Read();
            Write();
            Relax();
        }
    }

    class ExcellentPupil : Pupil
    {
        public override void Study() { Console.WriteLine("\tI study at score 11"); }
        public override void Read() { Console.WriteLine("\tI read at score 11"); }
        public override void Write() { Console.WriteLine("\tI write at score 11."); }
        public override void Relax() { Console.WriteLine("\tI relax at score 1."); }
    }

    class GoodPupil : Pupil
    {
        public override void Study() { Console.WriteLine("\tI study at score 8"); }
        public override void Read() { Console.WriteLine("\tI read at score 8"); }
        public override void Write() { Console.WriteLine("\tI write at score 8."); }
        public override void Relax() { Console.WriteLine("\tI relax at score 8."); }
    }

    class BadPupil : Pupil
    {
        public override void Study() { Console.WriteLine("\tI study at score 3"); }
        public override void Read() { Console.WriteLine("\tI read at score 3"); }
        public override void Write() { Console.WriteLine("\tI wite at score 3."); }
        public override void Relax() { Console.WriteLine("\tI relax at score 12."); }
    }

    static class Utils
    {
        public const string delimiter1 = "+===========================+";
        public const string delimiter2 = "|----------------------------|";
    }

}
