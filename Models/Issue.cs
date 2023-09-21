using POS.Enums;

namespace POS.Models;

public class Issue
{
    public int Id { get; set; }
    [required]
    public string Title { get; set; }
    [required]
    public string Description { get; set; }
    public Priority Priority { get; set; }
    public IssueType IssueType { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Completed { get; set; }
}