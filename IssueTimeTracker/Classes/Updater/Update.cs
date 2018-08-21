using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker
{
    public class Update
    {
        public string Version { get; set; }
        public string ReleaseDate { get; set; }
        public string ReleaseNotes { get; set; }
        public bool RequiredUpdate { get; set; }
        public bool VerifyUpdate { get; set; }
        public bool Skip { get; set; }
        public List<UpdateData> UpdateData = new List<UpdateData>();
        public List<DownloadFile> Files = new List<DownloadFile>();
    }
}
