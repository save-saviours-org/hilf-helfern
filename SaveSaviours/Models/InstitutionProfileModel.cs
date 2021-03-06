namespace SaveSaviours.Models {
    using System;

    public class InstitutionProfileModel {
        public string Name { get; set; } = String.Empty;
        public string ContactName { get; set; } = String.Empty;
        public string PrimaryPhoneNumber { get; set; } = String.Empty;
        public string? SecondaryPhoneNumber { get; set; }
        public string ZipCode { get; set; } = String.Empty;
        public bool Vetted { get; set; }
    }
}
