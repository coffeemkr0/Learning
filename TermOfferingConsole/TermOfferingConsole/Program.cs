using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermOfferingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Course("EE433", "Engineering	Software	Solutions", 3.0f);
            Course c2 = new Course("EE011", "Coop/Internship	in	EE", 0.0f);
            Course c3 = new Course("EE533", "Engineering	Software	Solutions", 3.0f);
            Course c4 = new Course("EE538", "Intermediate	Microprocessors", 3.0f);

            Instructor i1 = new Instructor("David	G	Green", "DGreen", "BEC256A");
            Instructor i2 = new Instructor("Gregg	L.	Vaughn", "gvaughn", "BEC265D");

            Room r1 = new Room()
            {
                RoomNumber = "BEC267"
            };
            Room r2 = new Room()
            {
                RoomNumber = "BEC158"
            };


            TimeSlot t1 = TimeSlot.TimeSlot_2A;
            TimeSlot t2 = TimeSlot.TimeSlot_2C;

            Offering o1 = new Offering(c1, i1, r1, t1);
            Offering o2 = new Offering(c2, i2, r2, t1);
            Offering o3 = new Offering(c2, i1, r2, t2);
            //	Issue
            Offering o4 = new Offering(c2, i1, r2, t1);

            TermOffering termOffering = new TermOffering("Fall", 2016);
            termOffering.CourseOfferings.Add(o1);
            termOffering.CourseOfferings.Add(o2);
            termOffering.CourseOfferings.Add(o3);

            PrintLogger pl = new PrintLogger();
            termOffering.Checkers.Add(new InstructorChecker());

            Console.WriteLine("First	test:	");
            Console.WriteLine(termOffering.Check(pl) ? "Valid	Schedule" : "Invalid	Schedule	--	see	above.");

            //	add	a	problem	item
            termOffering.CourseOfferings.Add(o4);
            Console.WriteLine("Second	test:	");
            Console.WriteLine(termOffering.Check(pl) ? "Valid	Schedule" : "Invalid	Schedule	--	see	above.");

            Console.ReadLine();
        }
    }
}
