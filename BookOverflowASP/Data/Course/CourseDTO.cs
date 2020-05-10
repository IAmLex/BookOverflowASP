using System;
using BookOverflowASP.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookOverflowASP.Data
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }

        public CourseDTO() { }

        public CourseDTO (CourseModel courseModel)
        {
            this.Id = courseModel.Id;
            this.Name = courseModel.Name;
        }

    }
}
