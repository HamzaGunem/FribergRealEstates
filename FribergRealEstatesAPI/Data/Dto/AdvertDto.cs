namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth: Hamza
    public class AdvertDto
    {
        public int Id { get; set; }
        public bool Sold { get; set; }
        public double CurrentPrice { get; set; }
        public DateTime Updated {  get; set; }

        public RealtorSummaryDto Realtor {  get; set; }
        public ResidenceSummaryDto Residence { get; set; }
    }
}
