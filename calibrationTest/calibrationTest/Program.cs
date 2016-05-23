using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calibrationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CalibrationGroup calibrationGroup1 = new CalibrationGroup();
            calibrationGroup1.groupTitle = "group1";
            calibrationGroup1.itemTitle = "myItemTitle1";
            calibrationGroup1.itemTotal = "myItemTotal1";
            calibrationGroup1.itemBase = "myItemBase1";

            CalibrationGroup calibrationGroup2 = new CalibrationGroup();
            calibrationGroup2.groupTitle = "group2";
            calibrationGroup2.itemTitle = "myItemTitle2";
            calibrationGroup2.itemTotal = "myItemTotal2";
            calibrationGroup2.itemBase = "myItemBase2";

            CalibrationGroup calibrationGroup3 = new CalibrationGroup();
            calibrationGroup3.groupTitle = "group3";
            calibrationGroup3.itemTitle = "myItemTitle3";
            calibrationGroup3.itemTotal = "myItemTotal3";
            calibrationGroup3.itemBase = "myItemBase3";

            //Console.WriteLine(calibrationGroup1.groupTitle);
            //Console.WriteLine(calibrationGroup1.itemBase);
            //Console.WriteLine(calibrationGroup2.groupTitle);
            //Console.WriteLine(calibrationGroup2.itemBase);
            //Console.WriteLine(calibrationGroup3.groupTitle);
            //Console.WriteLine(calibrationGroup3.itemBase);

            var child1 = new CalibrationGroup { itemTitle = "Hello from first (1) child", itemBase = "child1's base" };

            var grandChild1 = new CalibrationItem { itemTitle = "Hello from grand child!!!" };

            child1.myItems.Add(grandChild1);

            var child2 = new CalibrationItem { itemTitle = "Hello from second (2) child", itemBase = "child2's base" };
            calibrationGroup1.myItems.Add(child1);
            calibrationGroup1.myItems.Add(child2);

            Console.WriteLine(calibrationGroup1.PrintNode(0));

            Console.ReadKey();

        }
    }
}
