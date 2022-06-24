using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Careo_Back.Models
{
    public class FeedBack
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PersonStatus { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public bool IsDeleted { get; set; }
    }
}
