namespace AdvancedAttribute2.ValidateExtend
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10, 5)]
        public string StudentName { get; set; }
        [Required]
        [Long(11)]
        public long PhoneNumber { get; set; }
    }
}
