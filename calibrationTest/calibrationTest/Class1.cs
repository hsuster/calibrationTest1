using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calibrationTest
{
    public class CalibrationItem
    {
        internal string itemTitle { get; set; }
        internal string itemTotal { get; set; }
        internal string itemBase { get; set; }
        internal string itemOffset { get; set; }
        internal string itemPath { get; set; }
    }

    public class CalibrationGroup : CalibrationItem
    {
        public string groupTitle { get; set; }
        internal List<CalibrationItem> myItems = new List<CalibrationItem>();
    }

    public class CalibrationModel
    {
        List<CalibrationGroup> myGroups = new List<CalibrationGroup>();
    }
}
