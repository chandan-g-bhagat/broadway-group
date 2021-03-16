//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Broadway.Desktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Organization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organization()
        {
            this.AspNetUsers = new HashSet<AspNetUser>();
        }
    
        public System.Guid Id { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationBillingAddress { get; set; }
        public string OrgEmail { get; set; }
        public string OrgPhone { get; set; }
        public string OrgWebsite { get; set; }
        public string OrgContactPerson { get; set; }
        public int DbType { get; set; }
        public string DbConnectionString { get; set; }
        public int ActivationStats { get; set; }
        public int TotalUserLicense { get; set; }
        public int LicenseType { get; set; }
        public System.DateTime DateOfExpiry { get; set; }
        public string OrgCode { get; set; }
        public int DbStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
