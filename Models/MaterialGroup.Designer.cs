//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESolutions.Shopper.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaterialGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaterialGroup()
        {
            this.Articles = new HashSet<Article>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string EbayAuctionHtmlTemplate { get; set; }
        public string IntroductionGerman { get; set; }
        public string IntroductionEnglish { get; set; }
        public string DescriptionGerman { get; set; }
        public string DescriptionEnglish { get; set; }
        public string AdditionalDescriptionGerman { get; set; }
        public string AdditionalDescriptionEnglish { get; set; }
        public Nullable<int> MagentoCategoryId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Article> Articles { get; set; }
    }
}
