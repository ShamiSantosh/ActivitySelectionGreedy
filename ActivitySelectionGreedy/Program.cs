using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitySelectionGreedy
{
    public class Activity
    {
        public string Name { get; set; }
        public int StartDate{ get; set; }
        public int EndDate { get; set; }
        public int Duration { get; set; }

        public Activity(string Name, int StartDate, int EndDate)
        {
            this.Name = Name;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Duration = EndDate - StartDate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Activity[] MyActivity = new Activity[] {
                new Activity("a",10, 18),
                new Activity("b", 5, 15),
                new Activity("c", 14, 19),
                new Activity("d", 3, 10),
            };

            FindOptimalScheduling(MyActivity);
            Console.ReadKey();
        }

        private static void FindOptimalScheduling(Activity[] myActivity)
        {
            myActivity= myActivity.OrderBy(d => d.StartDate).ToArray();

            Console.Write("Activities are scheduled in this order: "+myActivity[0].Name+" ");

            int k = 0;
            for (int i = 1; i < myActivity.Length; i++)
            {
                if(myActivity[i].StartDate >= myActivity[k].EndDate)
                {
                    Console.Write(myActivity[i].Name + " ");
                    k++;
                }
            }

        }
    }
}
