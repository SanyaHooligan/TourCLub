using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TourClub.Models
{
    public enum Razdel
    {
        Собрания,
        Школа,
        ПВД,
        Походы,
        Тренировки,
        Соревнования,
        [Display(Name = "Новости сайта")]
        Новости_сайта,
        [Display(Name = "Все остальное")]
        Все_остальное
    }
    public class News
    {
        public Int32 NewsID { get; set; }
        public String Header { get; set; }
        public String Body { get; set; }
        public Account Author { get; set; }
        public List<HttpPostedFileBase> Images { get; set; }
        public DateTime Date { get { return DateTime.Now; } }
        public Razdel Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}