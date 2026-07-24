public class Customer
{
    //member variables
    private string _customerName;
    private Address _customerAddress;

    //Functions/methods

    //getters and setters
    public string GetCustomerName()
    {
        return _customerName;
    }
    public void SetCustomerName(string newName)
    {
        _customerName = newName;
    }

    public Address GetCustomerAddress()
    {
        return _customerAddress;
    }
    public void SetCustomerAddress(Address newAddress)
    {
        _customerAddress = newAddress;
    }

    public bool IsInUSA()
    {
        Address address = new Address();
        bool inUSA = address.IsInUSA();
        return inUSA;
    }


}