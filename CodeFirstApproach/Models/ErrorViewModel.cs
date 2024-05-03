using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproach.Models;

public class ErrorViewModel
{
    [Key]
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}

