using System;
using System.Collections.Generic;
using FormCreatorMVC.DAL.Models;

namespace FormCreatorMVC.Models
{
    public class AdminViewModel
    {
        public IEnumerable<Forms> Forms { get; set; }
    }
}
