namespace Entity;

public class Product
{
    public string ProId { get; set; }
    public string ProName { get; set; }
    public string ProPrice { get; set; }
    public string ProQuantity { get; set; }
    public DateTime ProDate { get; set; }



    public override string ToString()
    {
        return $"{{{nameof(ProId)}={ProId}, {nameof(ProName)}={ProName}, {nameof(ProPrice)}={ProPrice}, {nameof(ProQuantity)}={ProQuantity}, {nameof(ProDate)}={ProDate.ToString()}}}";
    }
}