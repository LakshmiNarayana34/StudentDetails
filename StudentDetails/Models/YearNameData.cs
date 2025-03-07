using System.ComponentModel.DataAnnotations;

namespace StudentDetails.Models
{
    public class YearNameData
    {
        [Key]
        public int StudentYearId { get; set; }
        public string YearName { get; set; }
    }
}
