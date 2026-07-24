using System;

class Program
{
    static void Main(string[] args)
    {        
        //Order One
        Order order1 = new Order();
        Address address1 = new Address();
        address1.SetStreet("123 Street");
        address1.SetCity("Cityville");
        address1.SetStateProvince("ST");
        address1.SetCountry("Canada");

        Customer customer1 = new Customer();
        customer1.SetCustomerName("John Doe");
        customer1.SetCustomerAddress(address1);
        order1.AddCustomer(customer1);

        Product product1 = new Product();
        product1.SetProductName("Apple");
        product1.SetProductID(123);
        product1.SetProductPricePerUnit(2.99f);
        product1.SetProductQuantity(4);
        order1.AddProduct(product1);

        Product product2 = new Product();
        product2.SetProductName("Banana");
        product2.SetProductID(456);
        product2.SetProductPricePerUnit(5.55f);
        product2.SetProductQuantity(2);
        order1.AddProduct(product2);

        order1.ShippingLabel(address1.CompleteAddress());
        order1.PackingLabel();
        order1.Receipt(address1.CompleteAddress());
        
        //Order Two
        Order order2 = new Order();
        Address address2 = new Address();
        address2.SetStreet("Bat Cave");
        address2.SetCity("Gotham");
        address2.SetStateProvince("NJ");
        address2.SetCountry("USA");

        Customer customer2 = new Customer();
        customer2.SetCustomerName("Batman");
        customer2.SetCustomerAddress(address2);
        order2.AddCustomer(customer2);

        Product product3 = new Product();
        product3.SetProductName("Batarang");
        product3.SetProductID(001);
        product3.SetProductPricePerUnit(29.99f);
        product3.SetProductQuantity(15);
        order2.AddProduct(product3);

        Product product4 = new Product();
        product4.SetProductName("Grappling Hook");
        product4.SetProductID(02654);
        product4.SetProductPricePerUnit(87.87f);
        product4.SetProductQuantity(4);
        order2.AddProduct(product4);

        Product product5 = new Product();
        product5.SetProductName("Bat Shark Repelent Spray");
        product5.SetProductID(3167230);
        product5.SetProductPricePerUnit(1993.50f);
        product5.SetProductQuantity(1);
        order2.AddProduct(product5);

        order2.ShippingLabel(address2.CompleteAddress());
        order2.PackingLabel();
        order2.Receipt(address2.CompleteAddress());
    }
}