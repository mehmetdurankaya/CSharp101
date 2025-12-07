using Proje2.Enums;


namespace Proje2.Entities
{
public class Card
{
public string Title { get; set; } = string.Empty;
public string Content { get; set; } = string.Empty;
public TeamMember? Assigned { get; set; }
public SizeType Size { get; set; }
}
}
