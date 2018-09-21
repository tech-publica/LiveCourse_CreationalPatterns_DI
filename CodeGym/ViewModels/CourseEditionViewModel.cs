using CodeGym.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.ViewModels
{
    public class CourseEditionViewModel
    {
        public long Id { get; set; }
        public long CourseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Cost { get; set; }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            var other = obj as CourseEditionViewModel;
            if (this.Id != other.Id)
                return false;
            if(this.StartDate != other.StartDate)
            {
                return false;
            }
            if (this.EndDate != other.EndDate)
            {
                return false;
            }
            if (this.Cost != other.Cost)
            {
                return false;
            }
            return true;

        }


        public override int GetHashCode()
        {
            return (int)Id + StartDate.GetHashCode() + EndDate.GetHashCode() + Cost.GetHashCode();
        }


    }


    

}
