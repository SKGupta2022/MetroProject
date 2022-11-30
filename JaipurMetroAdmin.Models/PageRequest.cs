using System;
using System.Collections.Generic;
using System.Text;

namespace JaipurMetroAdmin.Models
{
    public class PageRequest
    {
        public int PageId { get; set; }
        public int ModuleId { get; set; }
        public string PageNm { get; set; }
        public string PageDesc { get; set; }
    }


    public class PageResponse
    {
        public int PageId { get; set; }
        public int ModuleId { get; set; }
        public string PageNm { get; set; }
        public string PageDesc { get; set; }
        public string ModuleNm { get; set; }
    }
}
