using System.IO.Pipelines;

public class Address
{
    //Member variables
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    //functions/methods
    public bool IsInUSA()
    {
        bool result = false;
        if (_country.Contains("USA"))
        {
            result = true;
        }
        return result;
    }

    public string CompleteAddress()
    {
        string completeAddress = ($"{_street}\n{_city}\n{_stateProvince}\n{_country}");
        return completeAddress;
    }

    //getters and setters
    public void SetStreet(string newStreet)
    {
        _street = newStreet;
    }
    public void SetCity(string newCity)
    {
        _city = newCity;
    }
    public void SetStateProvince(string newStateProvince)
    {
        _stateProvince = newStateProvince;
    }
    public void SetCountry(string newCountry)
    {
        _country = newCountry;
    }
}