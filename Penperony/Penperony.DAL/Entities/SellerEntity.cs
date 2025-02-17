namespace Penperony.DAL.Entities
{
    public class SellerEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<TriggerEntity> Triggers = [];
    }
}
