using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Domain
{
    public class Student : BaseClass
    {
        [Key] // primary key that will be reflected in the database visual || [Key] public int StudentId { get; set; }
        public int StudentId { get; set; }
        
        public string StudentName { get; set; } 

        public string? StudentEmail { get; set; } // "?" makes the variable nullable

        [ForeignKey("ProgramID")] // a primary key that's from a different class || [ForeignKey("ProgramID")] public int ProgramId { get; set; }
        public int ProgramId { get; set; }
        public virtual Programs Programs { get; set; }
    }
}
