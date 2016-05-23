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

        public virtual string PrintNode(int indent)
        {
            var sb = new StringBuilder();
            sb.AppendLine(new string(' ', indent) + $"itemTitle: {itemTitle}");
            sb.AppendLine(new string(' ', indent) + $"itemTotal: {itemTotal}");
            sb.AppendLine(new string(' ', indent) + $"itemBase: {itemBase}");
            sb.AppendLine(new string(' ', indent) + $"itemOffset: {itemOffset}");
            sb.AppendLine(new string(' ', indent) + $"itemPath: {itemPath}");
            return sb.ToString();
        }

    }

    public class CalibrationGroup : CalibrationItem
    {
        public string groupTitle { get; set; }
        internal List<CalibrationItem> myItems = new List<CalibrationItem>();
        public override string PrintNode(int indent)
        {
            var sb = new StringBuilder();
            sb.AppendLine(new string(' ', indent) + $"groupTitle: {groupTitle}");
            sb.Append(base.PrintNode(indent));
            foreach (var child in myItems)
            {
                sb.Append(child.PrintNode(indent + 2));
            }
            return sb.ToString();
        }
    }

    public class CalibrationModel
    {
        List<CalibrationGroup> myGroups = new List<CalibrationGroup>();
    }
}
