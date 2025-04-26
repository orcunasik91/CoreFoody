namespace CoreFoody.EntityLayer.Concrete;
public class Article
{
    public int ArticleId { get; set; }
    public string Title { get; set; }
    public string AuthorName { get; set; }
    public string CoverImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
}