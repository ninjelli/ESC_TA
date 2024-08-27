namespace ESC_TA.DTO;

public class LocationDTO
{
    public string StreetAddress { get; set; }

    public string PostalCode { get; set; }

    public string City { get; set; }

    public string StateProvince { get; set; }

    public CountryDTO? Country { get; set; }
}