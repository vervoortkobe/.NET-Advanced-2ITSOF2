namespace Zolando.OrderSystem.MVCApp.Models
{
    public class ErrorDeleteViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
