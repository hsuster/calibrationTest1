using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calibrationTest2
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

            Console.WriteLine(calibrationGroup1.groupTitle);
            Console.WriteLine(calibrationGroup1.itemBase);
            Console.WriteLine(calibrationGroup2.groupTitle);
            Console.WriteLine(calibrationGroup2.itemBase);
            Console.WriteLine(calibrationGroup3.groupTitle);
            Console.WriteLine(calibrationGroup3.itemBase);

        }
    }
}
