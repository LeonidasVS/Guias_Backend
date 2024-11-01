namespace Backend.DTO
{
    public interface IPostService
    {
        public Task<IEnumerable<PostDTO>> get();
    }
}
