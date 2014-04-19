using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbmcelsk.Lib.Commands.Results {
    public class ListItemBase : AudioDetailsMedia {
        public int Id { get; set; }
        public ListItemType Type { get; set; }
    }
}
