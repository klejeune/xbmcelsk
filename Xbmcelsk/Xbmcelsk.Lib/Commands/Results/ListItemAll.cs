using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbmcelsk.Lib.Commands.Results {
    public class ListItemAll : ListItemBase {
        public string Channel { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int ChannelNumber { get; set; }
    }
}
