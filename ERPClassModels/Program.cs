public class SaleOrder
{
    public int OrderID { get; set; }
    public string CustomerID { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public int OrderStatus { get; set; }
    public DateTime Deadline { get; set; }
    public List<FinishedGood> FinishedGood { get; set; }
}

public class FinishedGood : SaleOrder
{
    public int GoodID { get; set; }
    public int Status { get; set; }
    public DateTime CreatedDate { get;set; }
    public DateTime DeadLine { get; set; }
    public bool IsBulk { get; set; }
    public int Quality { get; set; }

    public List<BatchRecord> BatchRecords { get; set; }
}

public class BatchRecord : FinishedGood
{
    public int RecordID { get; set; }
    public int Size { get; set; }
    public int Status { get; set; }
    public List<RawMaterial> RawMaterials { get; set; }
}

public class RawMaterial : BatchRecord
{
    public int MaterialID { get; set; } 
    public string Name { get; set; }
    public DateTime PurchasedDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public int QualityLevel { get; set; }
    public int Quantity { get; set; }

    public List<WarehouseLot> WarehouseLots { get; set; }
}

public class WarehouseLot : RawMaterial
{
    public int LodID { get; set;}
}
