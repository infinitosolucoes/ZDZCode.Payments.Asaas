﻿namespace ZDZCode.Payments.Asaas.DataListResponse
{
    public class DataResponseList
    {
        public string Customer { get; set; }
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Address { get; set; }
        public string AddressNumber { get; set; }
        public string Complement { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string CpfCnpj { get; set; }
        public string PersonType { get; set; }
        public bool Deleted { get; set; }
        public string AdditionalEmails { get; set; }
        public string ExternalReference { get; set; }
        public string NotificationDisabled { get; set; }
        public string Observations { get; set; }
    }
}
