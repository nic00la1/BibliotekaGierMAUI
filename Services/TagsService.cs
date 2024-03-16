namespace BibliotekaGierMAUI.Services
{
    public class TagsService : ITagsService
    {
        public ICollection<string> GetTags()
        {
            return new List<string>
            {
                "#RPG",
                "#Action",
                "#Adventure",
                "#Open_World",
                "#First_Person",
                "#Third_Person",
                "#Shooter",
                "#Survival",
                "#Horror",
                "#Fantasy",
                "#Sci-Fi",
            };
        }
    }
}
