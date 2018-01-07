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
    
    public partial class Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Article()
        {
            this.ArticleQAs = new HashSet<ArticleQA>();
            this.Orders = new HashSet<Order>();
            this.StockMovements = new HashSet<StockMovement>();
            this.SaleItems = new HashSet<SaleItem>();
            this.PossibleEANs = new HashSet<PossibleEAN>();
            this.ArticleVehicleAssignments = new HashSet<ArticleVehicleAssignment>();
            this.SubArticles = new HashSet<Article>();
            this.ArticleSearches = new HashSet<ArticleSearch>();
        }
    
        public int Id { get; set; }
        public int MaterialGroupsId { get; set; }
        public string ArticleNumber { get; set; }
        public string NameIntern { get; set; }
        public string NameGerman { get; set; }
        public string NameEnglish { get; set; }
        public string DescriptionGerman { get; set; }
        public string DescriptionEnglish { get; set; }
        public string PictureName1 { get; set; }
        public string PictureName2 { get; set; }
        public string PictureName3 { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Weight { get; set; }
        public decimal SellingPriceWholesaleGross { get; set; }
        public int SupplierId { get; set; }
        public string SupplierArticleNumber { get; set; }
        public decimal SellingPriceGross { get; set; }
        public int Unit { get; set; }
        public bool MustSyncStockAmount { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public int SyncTotal { get; set; }
        public int SyncEbayAvailiable { get; set; }
        public int SyncEbayActive { get; set; }
        public int SyncEbayTemplate { get; set; }
        public int SyncMagento { get; set; }
        public string SyncTechnicalInfo { get; set; }
        public bool IsInEbay { get; set; }
        public bool IsInMagento { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public string Tags { get; set; }
        public decimal PurchasePrice { get; set; }
        public Nullable<System.Guid> Picture1Guid { get; set; }
        public Nullable<System.Guid> Picture2Guid { get; set; }
        public Nullable<System.Guid> Picture3Guid { get; set; }
        public string EAN { get; set; }
        public string EbayArticleNumber { get; set; }
        public Nullable<int> MasterArticleId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticleQA> ArticleQAs { get; set; }
        public virtual MaterialGroup MaterialGroup { get; set; }
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockMovement> StockMovements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleItem> SaleItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PossibleEAN> PossibleEANs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticleVehicleAssignment> ArticleVehicleAssignments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Article> SubArticles { get; set; }
        public virtual Article MasterArticle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticleSearch> ArticleSearches { get; set; }
    }
}