using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourClub.Models
{
    public class Comment
    {
        public Int32 CommentID { get; set; }
        public Int32 NewsID { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Body { get; set; }
    }
}