namespace ShowroomManagementAPI.DTOs
{
    public class ResponseDTO
    {
        public int StatticCode { get; set; }
        public string WrrorMassage { get; set; }
        public dynamic Response { get; set; }
        public string ErrorMassage { get; internal set; }
    }
}
