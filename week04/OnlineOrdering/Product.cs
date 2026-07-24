public class Product
{
    //member variables
    private string _productName;
    private int _productID;
    private float _productPricePerUnit;
    private int _productQuantity;

    //functions/methods
    public float TotalProductPrice()
    {
        float totalPrice = _productPricePerUnit * _productQuantity;
        return totalPrice;
    }
    
    //getters and setters
    public void SetProductName(string newProductName)
    {
        _productName = newProductName;
    }
    public void SetProductID(int newProductID)
    {
        _productID = newProductID;
    }
    public void SetProductPricePerUnit(float newProductPricePerUnit)
    {
        _productPricePerUnit = newProductPricePerUnit;
    }
    public void SetProductQuantity(int newProductQuantity)
    {
        _productQuantity = newProductQuantity;
    }

}