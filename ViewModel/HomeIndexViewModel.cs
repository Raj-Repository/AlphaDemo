using AlphaDemo.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaDemo.ViewModel
{
    public class HomeIndexViewModel
    {
        public List<SampleData> SampleData { get; set; }
        public string PageTitle { get; set; }
    }
}
