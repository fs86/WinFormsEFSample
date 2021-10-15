using System;
using WinFormsEFSample.DataAccess.Models.Common;

namespace WinFormsEFSample.DataAccess.Models
{
    public class Season : EntityBase
    {
        public string From { get; set; }
        public string To { get; set; }
        public Guid HerbId { get; set; }
        public virtual Herb Herb { get; set; }
    }
}
