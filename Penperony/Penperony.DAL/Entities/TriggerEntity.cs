namespace Penperony.DAL.Entities

{
    public class TriggerEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Value {  get; set; } = string.Empty ;
        public List<ProviderEntity> Providers { get; set; } = [];
        public List<ProductEntity> Products { get; set; } = [];
        public List<SellerEntity> Sellers { get; set; } = [];

    }
}
