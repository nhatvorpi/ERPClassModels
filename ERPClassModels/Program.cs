public class SaleOrder
{
    public int OrderID { get; set; }
    public string CustomerID { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public int OrderStatus { get; set; }
    public DateTime Deadline { get; set; }
    public List<FinishedGood> FinishedGood { get; set; }

    // Other proterties and methods related to Sale Order
}

public class FinishedGood
{
    public int GoodID { get; set; }
    public int Status { get; set; }
    public DateTime CreatedDate { get;set; }

    public DateTime DeadLine { get; set; }
    public bool IsBulk { get; set; }
    public int Quality { get; set; }

    public List<BatchRecord> BatchRecords { get; set; }

    // Other proterties and methods related to Finished Good
}

public class BatchRecord
{
    public int RecordID { get; set; }
    public int Size { get; set; }
    public int Status { get; set; }
    public List<RawMaterial> RawMaterials { get; set; }

    // Other properties and methods related to Batch Record
}

public class RawMaterial
{
    public int MaterialID { get; set; } 
    public string Name { get; set; }
    public DateTime PurchasedDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public int QualityLevel { get; set; }
    public int Quantity { get; set; }

    public List<WarehouseLot> WarehouseLots { get; set; }

    // Other properties and methods related to Raw Material
}

public class WarehouseLot
{
    public int LodID { get; set;}

    //Other properties and methods related to Warehouse Lot
}
