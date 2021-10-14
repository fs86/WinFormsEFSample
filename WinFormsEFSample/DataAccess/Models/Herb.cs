using System.Collections.Generic;
using WinFormsEFSample.DataAccess.Models.Common;

namespace WinFormsEFSample.DataAccess.Models
{
    public class Herb : EntityBase
    {
        public string Name { get; set; }
        public virtual IEnumerable<Season> Seasons { get; set; }
    }
}
