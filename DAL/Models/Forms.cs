using System;
using System.ComponentModel.DataAnnotations;

namespace FormCreatorMVC.DAL.Models
{
    public class Forms
    {

        public string ID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String CreatedAt { get; set; }
        public String CreatedBy{ get; set; }
        public String CreatorName { get; set; }
        public String CreatorLastName { get; set; }
        public int CreatorAge { get; set; }
    }
}
