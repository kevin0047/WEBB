using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using WEBB.Data;
using WEBB.Models;
using WEBB.Pages;

namespace WEBB.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string SubSubCategory { get; set; }
        public string ShortContent
        {
            get
            {
                if (Content.Length <= 30)
                    return Content;
                return Content.Substring(0, 30) + "...";
            }
        }
        public string MiddleContent
        {
            get
            {
                if (Content.Length <= 200)
                    return Content;
                return Content.Substring(0, 200) + "...";
            }
        }
        public string ShortTitle
        {
            get
            {
                if (Title.Length <= 30)
                    return Title;
                return Title.Substring(0, 30) + "...";
            }
        }
    }
}









