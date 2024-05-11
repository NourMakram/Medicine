namespace Medicine.Dtos
{
    public class BookingSender
    {
        public string patientName { set; get; }
        public string doctorName { set; get; }
        
        public string day { set ; get; }
        public TimeOnly to { set; get; }
        public TimeOnly from { set; get; }
    }
}
