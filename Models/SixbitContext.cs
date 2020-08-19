using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlueFox.Models
{
    public partial class SixbitContext : DbContext
    {
        public SixbitContext()
        {
        }

        public SixbitContext(DbContextOptions<SixbitContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityLog> ActivityLog { get; set; }
        public virtual DbSet<AdCampaignsEbay> AdCampaignsEbay { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<AdsEbay> AdsEbay { get; set; }
        public virtual DbSet<AllocationPlans> AllocationPlans { get; set; }
        public virtual DbSet<BackgroundTaskList> BackgroundTaskList { get; set; }
        public virtual DbSet<BackgroundTaskLog> BackgroundTaskLog { get; set; }
        public virtual DbSet<BackgroundTaskPermissions> BackgroundTaskPermissions { get; set; }
        public virtual DbSet<BatchChangeDefinitions> BatchChangeDefinitions { get; set; }
        public virtual DbSet<BillChargesEtsy> BillChargesEtsy { get; set; }
        public virtual DbSet<Bins> Bins { get; set; }
        public virtual DbSet<BusinessProfile> BusinessProfile { get; set; }
        public virtual DbSet<BuyerMessages> BuyerMessages { get; set; }
        public virtual DbSet<Buyers> Buyers { get; set; }
        public virtual DbSet<CategoriesAmazon> CategoriesAmazon { get; set; }
        public virtual DbSet<CategoriesAmazonSpecifics> CategoriesAmazonSpecifics { get; set; }
        public virtual DbSet<CategoriesAmazonSpecificsValues> CategoriesAmazonSpecificsValues { get; set; }
        public virtual DbSet<CategoriesBidStart> CategoriesBidStart { get; set; }
        public virtual DbSet<CategoriesEbay> CategoriesEbay { get; set; }
        public virtual DbSet<CategoriesMercado> CategoriesMercado { get; set; }
        public virtual DbSet<CategoryFavoritesBidStart> CategoryFavoritesBidStart { get; set; }
        public virtual DbSet<CategoryFavoritesEbay> CategoryFavoritesEbay { get; set; }
        public virtual DbSet<CategoryFavoritesMercado> CategoryFavoritesMercado { get; set; }
        public virtual DbSet<ChangeDetails> ChangeDetails { get; set; }
        public virtual DbSet<ChangeRequests> ChangeRequests { get; set; }
        public virtual DbSet<Changes> Changes { get; set; }
        public virtual DbSet<Charities> Charities { get; set; }
        public virtual DbSet<Claims> Claims { get; set; }
        public virtual DbSet<CollectionsShopify> CollectionsShopify { get; set; }
        public virtual DbSet<CollectsShopify> CollectsShopify { get; set; }
        public virtual DbSet<CompatibilitySets> CompatibilitySets { get; set; }
        public virtual DbSet<ConditionsEbay> ConditionsEbay { get; set; }
        public virtual DbSet<ConsignmentPlans> ConsignmentPlans { get; set; }
        public virtual DbSet<ContactAccounts> ContactAccounts { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<CreditCards> CreditCards { get; set; }
        public virtual DbSet<DescriptionWrappers> DescriptionWrappers { get; set; }
        public virtual DbSet<Descriptions> Descriptions { get; set; }
        public virtual DbSet<DetailsEbay> DetailsEbay { get; set; }
        public virtual DbSet<Dsrs> Dsrs { get; set; }
        public virtual DbSet<DurationSetsEbay> DurationSetsEbay { get; set; }
        public virtual DbSet<EBayBusinessPolicies> EBayBusinessPolicies { get; set; }
        public virtual DbSet<EmailTemplates> EmailTemplates { get; set; }
        public virtual DbSet<Feedbacks> Feedbacks { get; set; }
        public virtual DbSet<Feeds> Feeds { get; set; }
        public virtual DbSet<GridLayouts> GridLayouts { get; set; }
        public virtual DbSet<ImageEditorMacros> ImageEditorMacros { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InventoryFeeds> InventoryFeeds { get; set; }
        public virtual DbSet<ItemPromotionsEbay> ItemPromotionsEbay { get; set; }
        public virtual DbSet<ItemSpecificsEbay> ItemSpecificsEbay { get; set; }
        public virtual DbSet<ItemSpecificsMercado> ItemSpecificsMercado { get; set; }
        public virtual DbSet<ItemStatuses> ItemStatuses { get; set; }
        public virtual DbSet<ItemTemplates> ItemTemplates { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<ItemsAmazon> ItemsAmazon { get; set; }
        public virtual DbSet<ItemsBidstart> ItemsBidstart { get; set; }
        public virtual DbSet<ItemsEbay> ItemsEbay { get; set; }
        public virtual DbSet<ItemsEtsy> ItemsEtsy { get; set; }
        public virtual DbSet<ItemsMercado> ItemsMercado { get; set; }
        public virtual DbSet<ItemsShopify> ItemsShopify { get; set; }
        public virtual DbSet<ItemsUploadLists> ItemsUploadLists { get; set; }
        public virtual DbSet<LabelDefinitions> LabelDefinitions { get; set; }
        public virtual DbSet<ListingStatuses> ListingStatuses { get; set; }
        public virtual DbSet<ListingUpgradeTemplates> ListingUpgradeTemplates { get; set; }
        public virtual DbSet<Listings> Listings { get; set; }
        public virtual DbSet<ListingsBidstart> ListingsBidstart { get; set; }
        public virtual DbSet<ListingsEbay> ListingsEbay { get; set; }
        public virtual DbSet<ListingsMercado> ListingsMercado { get; set; }
        public virtual DbSet<LocationKeyLink> LocationKeyLink { get; set; }
        public virtual DbSet<LocationsShopify> LocationsShopify { get; set; }
        public virtual DbSet<Machines> Machines { get; set; }
        public virtual DbSet<Manifests> Manifests { get; set; }
        public virtual DbSet<MaterialTemplates> MaterialTemplates { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<OffersEtsy> OffersEtsy { get; set; }
        public virtual DbSet<OrderStatuses> OrderStatuses { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersFeeds> OrdersFeeds { get; set; }
        public virtual DbSet<OriginTemplates> OriginTemplates { get; set; }
        public virtual DbSet<PaymentServiceAccounts> PaymentServiceAccounts { get; set; }
        public virtual DbSet<PaymentTemplates> PaymentTemplates { get; set; }
        public virtual DbSet<PictureHosts> PictureHosts { get; set; }
        public virtual DbSet<Pictures> Pictures { get; set; }
        public virtual DbSet<PostageImages> PostageImages { get; set; }
        public virtual DbSet<ProductFinders> ProductFinders { get; set; }
        public virtual DbSet<PromotionsListings> PromotionsListings { get; set; }
        public virtual DbSet<PurchaseOrderDetails> PurchaseOrderDetails { get; set; }
        public virtual DbSet<PurchaseOrders> PurchaseOrders { get; set; }
        public virtual DbSet<Purchases> Purchases { get; set; }
        public virtual DbSet<RateTablesEbay> RateTablesEbay { get; set; }
        public virtual DbSet<ReallocateReference> ReallocateReference { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<ReportsAmazon> ReportsAmazon { get; set; }
        public virtual DbSet<RepricingPlans> RepricingPlans { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<SalesPurchases> SalesPurchases { get; set; }
        public virtual DbSet<SalesTax> SalesTax { get; set; }
        public virtual DbSet<SellerAccountsAmazon> SellerAccountsAmazon { get; set; }
        public virtual DbSet<SellerAccountsBidStart> SellerAccountsBidStart { get; set; }
        public virtual DbSet<SellerAccountsEtsy> SellerAccountsEtsy { get; set; }
        public virtual DbSet<SellerAccountsMercado> SellerAccountsMercado { get; set; }
        public virtual DbSet<SellerAccountsShopify> SellerAccountsShopify { get; set; }
        public virtual DbSet<SellerAccountseBay> SellerAccountseBay { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<Shipments> Shipments { get; set; }
        public virtual DbSet<ShippingDiscountProfile> ShippingDiscountProfile { get; set; }
        public virtual DbSet<ShippingServices> ShippingServices { get; set; }
        public virtual DbSet<ShippingTemplateUpgradesEtsy> ShippingTemplateUpgradesEtsy { get; set; }
        public virtual DbSet<ShippingTemplates> ShippingTemplates { get; set; }
        public virtual DbSet<ShippingTemplatesAmazon> ShippingTemplatesAmazon { get; set; }
        public virtual DbSet<ShippingTemplatesEtsy> ShippingTemplatesEtsy { get; set; }
        public virtual DbSet<ShopSectionsEtsy> ShopSectionsEtsy { get; set; }
        public virtual DbSet<Sites> Sites { get; set; }
        public virtual DbSet<Snippets> Snippets { get; set; }
        public virtual DbSet<StoreCategoriesEbay> StoreCategoriesEbay { get; set; }
        public virtual DbSet<StoreCategoryFavoritesEbay> StoreCategoryFavoritesEbay { get; set; }
        public virtual DbSet<SubStatuses> SubStatuses { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<TagTemplates> TagTemplates { get; set; }
        public virtual DbSet<TagTemplatesShopify> TagTemplatesShopify { get; set; }
        public virtual DbSet<TaxonomyEtsy> TaxonomyEtsy { get; set; }
        public virtual DbSet<ThemesEbay> ThemesEbay { get; set; }
        public virtual DbSet<Tt19c29d5e8ba04371be257cf896dac097> Tt19c29d5e8ba04371be257cf896dac097 { get; set; }
        public virtual DbSet<Tt5e940379542c493b9a55251a370a8b95> Tt5e940379542c493b9a55251a370a8b95 { get; set; }
        public virtual DbSet<Ttc6a9ba97b81d47eb8e5fee5b5605ae8e> Ttc6a9ba97b81d47eb8e5fee5b5605ae8e { get; set; }
        public virtual DbSet<UploadLists> UploadLists { get; set; }
        public virtual DbSet<UserLogins> UserLogins { get; set; }
        public virtual DbSet<VariationSets> VariationSets { get; set; }
        public virtual DbSet<Views> Views { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MAIN-STATION\\SIXBITDBSERVER;Database=Sixbit;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.HasIndex(e => e.LogTime);

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.LogTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdCampaignsEbay>(entity =>
            {
                entity.HasKey(e => e.CampaignId);

                entity.Property(e => e.CampaignId)
                    .HasColumnName("CampaignID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignName).HasMaxLength(80);

                entity.Property(e => e.SellerAccountEbayId).HasColumnName("SellerAccountEbayID");

                entity.HasOne(d => d.SellerAccountEbay)
                    .WithMany(p => p.AdCampaignsEbay)
                    .HasForeignKey(d => d.SellerAccountEbayId)
                    .HasConstraintName("FK_AdCampaignsEbay_SellerAccountseBay");
            });

            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.HasIndex(e => e.EBayAddressId);

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressLine1).HasMaxLength(255);

                entity.Property(e => e.AddressLine2).HasMaxLength(255);

                entity.Property(e => e.AddressLine3).HasMaxLength(255);

                entity.Property(e => e.BuyerId).HasColumnName("BuyerID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CityId)
                    .HasColumnName("CityID")
                    .HasMaxLength(20);

                entity.Property(e => e.Company).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasMaxLength(4);

                entity.Property(e => e.EBayAddressId)
                    .HasColumnName("eBayAddressID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Initial).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MercadoAddressId)
                    .HasColumnName("MercadoAddressID")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.ReferenceId)
                    .HasColumnName("ReferenceID")
                    .HasMaxLength(30);

                entity.Property(e => e.ShopifyAddressId).HasColumnName("ShopifyAddressID");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.StateId)
                    .HasColumnName("StateID")
                    .HasMaxLength(6);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<AdsEbay>(entity =>
            {
                entity.HasKey(e => e.AdId);

                entity.Property(e => e.AdId)
                    .HasColumnName("AdID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.AdsEbay)
                    .HasForeignKey(d => d.CampaignId)
                    .HasConstraintName("FK_AdsEbay_AdCampaignsEbay");
            });

            modelBuilder.Entity<AllocationPlans>(entity =>
            {
                entity.HasKey(e => e.AllocationPlanId)
                    .HasName("PK_AllocationPlan");

                entity.Property(e => e.AllocationPlanId).HasColumnName("AllocationPlanID");

                entity.Property(e => e.AutoFptype).HasColumnName("AutoFPType");

                entity.Property(e => e.ConstantFpqty)
                    .HasColumnName("ConstantFPQty")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DecliningFpamount)
                    .HasColumnName("DecliningFPAmount")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DecliningFptype).HasColumnName("DecliningFPType");

                entity.Property(e => e.Fpfloor)
                    .HasColumnName("FPFloor")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAutoFp).HasColumnName("IsAutoFP");

                entity.Property(e => e.IsDecliningFp).HasColumnName("IsDecliningFP");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");
            });

            modelBuilder.Entity<BackgroundTaskList>(entity =>
            {
                entity.HasKey(e => e.TaskName);

                entity.Property(e => e.TaskName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FixedTime).HasColumnType("datetime");

                entity.Property(e => e.TaskComputer)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BackgroundTaskLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.HasIndex(e => e.TaskName);

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.CompTime).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExecTime).HasColumnType("datetime");

                entity.Property(e => e.StartedTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TaskNameNavigation)
                    .WithMany(p => p.BackgroundTaskLog)
                    .HasForeignKey(d => d.TaskName)
                    .HasConstraintName("FK_BackgroundTaskLog_BackgroundTaskList");
            });

            modelBuilder.Entity<BackgroundTaskPermissions>(entity =>
            {
                entity.HasKey(e => e.ComputerName);

                entity.Property(e => e.ComputerName).HasMaxLength(150);
            });

            modelBuilder.Entity<BatchChangeDefinitions>(entity =>
            {
                entity.HasKey(e => e.BatchChangeDefinitionId);

                entity.Property(e => e.BatchChangeDefinitionId).HasColumnName("BatchChangeDefinitionID");

                entity.Property(e => e.Definition)
                    .IsRequired()
                    .HasColumnType("xml");

                entity.Property(e => e.ItemSpecificsXml)
                    .HasColumnName("ItemSpecificsXML")
                    .HasColumnType("xml")
                    .HasDefaultValueSql("('<ISChanges></ISChanges>')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");
            });

            modelBuilder.Entity<BillChargesEtsy>(entity =>
            {
                entity.HasKey(e => e.BillChargeId);

                entity.Property(e => e.BillChargeId)
                    .HasColumnName("BillChargeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CurrencyCode).HasMaxLength(5);

                entity.Property(e => e.SellerAccountsEtsyId).HasColumnName("SellerAccountsEtsyID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.SellerAccountsEtsy)
                    .WithMany(p => p.BillChargesEtsy)
                    .HasForeignKey(d => d.SellerAccountsEtsyId)
                    .HasConstraintName("FK_BillChargesEtsy_SellerAccountsEtsy");
            });

            modelBuilder.Entity<Bins>(entity =>
            {
                entity.HasKey(e => e.BinId)
                    .HasName("PK__Bins__4BFF5A4E800224C8");

                entity.Property(e => e.BinId).HasColumnName("BinID");

                entity.Property(e => e.BinName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<BusinessProfile>(entity =>
            {
                entity.HasIndex(e => e.ContactAccountId);

                entity.HasIndex(e => e.OriginTemplateId);

                entity.HasIndex(e => e.PictureHostId);

                entity.Property(e => e.BusinessProfileId).HasColumnName("BusinessProfileID");

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAccountId).HasColumnName("ContactAccountID");

                entity.Property(e => e.ContactAccountMappings)
                    .IsRequired()
                    .HasColumnType("xml")
                    .HasDefaultValueSql("('<ContactAccountMappings/>')");

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.OriginTemplateId).HasColumnName("OriginTemplateID");

                entity.Property(e => e.PackingListMsg)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PackingListMsg2)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.PictureHostId)
                    .HasColumnName("PictureHostID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SellerAccountsAmazonId).HasColumnName("SellerAccountsAmazonID");

                entity.Property(e => e.SellerAccountsBidStartId).HasColumnName("SellerAccountsBidStartID");

                entity.Property(e => e.SellerAccountsEtsyId).HasColumnName("SellerAccountsEtsyID");

                entity.Property(e => e.SellerAccountsMercadoId).HasColumnName("SellerAccountsMercadoID");

                entity.Property(e => e.SellerAccountsShopifyId).HasColumnName("SellerAccountsShopifyID");

                entity.Property(e => e.SellerAccountseBayId).HasColumnName("SellerAccountseBayID");

                entity.HasOne(d => d.ContactAccount)
                    .WithMany(p => p.BusinessProfile)
                    .HasForeignKey(d => d.ContactAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessProfile_ContactAccounts");

                entity.HasOne(d => d.OriginTemplate)
                    .WithMany(p => p.BusinessProfile)
                    .HasForeignKey(d => d.OriginTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessProfile_OriginTemplates");

                entity.HasOne(d => d.PictureHost)
                    .WithMany(p => p.BusinessProfile)
                    .HasForeignKey(d => d.PictureHostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessProfile_PictureHosts");

                entity.HasOne(d => d.SellerAccountsAmazon)
                    .WithMany(p => p.BusinessProfile)
                    .HasForeignKey(d => d.SellerAccountsAmazonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessProfile_SellerAccountsAmazon");

                entity.HasOne(d => d.SellerAccountsBidStart)
                    .WithMany(p => p.BusinessProfile)
                    .HasForeignKey(d => d.SellerAccountsBidStartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessProfile_SellerAccountsBidStart");

                entity.HasOne(d => d.SellerAccountsEtsy)
                    .WithMany(p => p.BusinessProfile)
                    .HasForeignKey(d => d.SellerAccountsEtsyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessProfile_SellerAccountsEtsy");

                entity.HasOne(d => d.SellerAccountsMercado)
                    .WithMany(p => p.BusinessProfile)
                    .HasForeignKey(d => d.SellerAccountsMercadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessProfile_SellerAccountsMercado");

                entity.HasOne(d => d.SellerAccountsShopify)
                    .WithMany(p => p.BusinessProfile)
                    .HasForeignKey(d => d.SellerAccountsShopifyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessProfile_SellerAccountsShopify");

                entity.HasOne(d => d.SellerAccountseBay)
                    .WithMany(p => p.BusinessProfile)
                    .HasForeignKey(d => d.SellerAccountseBayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessProfile_SellerAccountseBay");
            });

            modelBuilder.Entity<BuyerMessages>(entity =>
            {
                entity.HasKey(e => e.BuyerMessageId);

                entity.Property(e => e.BuyerMessageId).HasColumnName("BuyerMessageID");

                entity.Property(e => e.ECommerceId)
                    .HasColumnName("eCommerceID")
                    .HasMaxLength(50);

                entity.Property(e => e.FromBuyer).HasMaxLength(50);

                entity.Property(e => e.MessageId)
                    .HasColumnName("MessageID")
                    .HasMaxLength(50);

                entity.Property(e => e.SellerAccount).HasMaxLength(255);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.Subject).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.UserIdnumber)
                    .HasColumnName("UserIDNumber")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Buyers>(entity =>
            {
                entity.HasKey(e => e.BuyerId);

                entity.Property(e => e.BuyerId).HasColumnName("BuyerID");

                entity.Property(e => e.AmazonUserId)
                    .HasColumnName("AmazonUserID")
                    .HasMaxLength(100);

                entity.Property(e => e.BidstartUserId)
                    .HasColumnName("BidstartUserID")
                    .HasMaxLength(100);

                entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddressID");

                entity.Property(e => e.Company).HasMaxLength(255);

                entity.Property(e => e.DateLastModified).HasColumnType("datetime");

                entity.Property(e => e.EBayUserid)
                    .HasColumnName("eBayUserid")
                    .HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.EtsyUserId)
                    .HasColumnName("EtsyUserID")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Initial).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MercadoUserId)
                    .HasColumnName("MercadoUserID")
                    .HasMaxLength(100);

                entity.Property(e => e.MercadoUserIdint).HasColumnName("MercadoUserIDInt");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix).HasMaxLength(50);

                entity.Property(e => e.SalesTaxId)
                    .HasColumnName("SalesTaxID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddressID");

                entity.Property(e => e.ShopifyBuyerId).HasColumnName("ShopifyBuyerID");

                entity.Property(e => e.Suffix).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.WebAddress).HasMaxLength(255);
            });

            modelBuilder.Entity<CategoriesAmazon>(entity =>
            {
                entity.HasIndex(e => e.CategoryId);

                entity.Property(e => e.CategoriesAmazonId).HasColumnName("CategoriesAmazonID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Parent).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Path).HasMaxLength(255);

                entity.Property(e => e.Refinements).HasColumnType("xml");
            });

            modelBuilder.Entity<CategoriesAmazonSpecifics>(entity =>
            {
                entity.HasKey(e => e.SpecificId);

                entity.Property(e => e.SpecificId).HasColumnName("SpecificID");

                entity.Property(e => e.CategoriesAmazonId).HasColumnName("CategoriesAmazonID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.CategoriesAmazon)
                    .WithMany(p => p.CategoriesAmazonSpecifics)
                    .HasForeignKey(d => d.CategoriesAmazonId)
                    .HasConstraintName("FK_CategoriesAmazonSpecifics_CategoriesAmazon");
            });

            modelBuilder.Entity<CategoriesAmazonSpecificsValues>(entity =>
            {
                entity.HasKey(e => new { e.SpecificId, e.Value });

                entity.Property(e => e.SpecificId).HasColumnName("SpecificID");

                entity.Property(e => e.Value).HasMaxLength(50);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.HasOne(d => d.Specific)
                    .WithMany(p => p.CategoriesAmazonSpecificsValues)
                    .HasForeignKey(d => d.SpecificId)
                    .HasConstraintName("FK_CategoriesAmazonSpecificsValues_CategoriesAmazonSpecifics");
            });

            modelBuilder.Entity<CategoriesBidStart>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_BidStartCategories");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryLevel).HasDefaultValueSql("((1))");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryParentId).HasColumnName("CategoryParentID");

                entity.Property(e => e.Level).HasComputedColumnSql("([Node].[GetLevel]())");
            });

            modelBuilder.Entity<CategoriesEbay>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_eBayUSCategories");

                entity.HasIndex(e => e.CategoryParentId);

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryFeatures).HasColumnType("xml");

                entity.Property(e => e.CategoryLevel).HasDefaultValueSql("((1))");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryParentId).HasColumnName("CategoryParentID");

                entity.Property(e => e.CustomIs).HasColumnName("CustomIS");

                entity.Property(e => e.FeatureUpdateDate).HasColumnType("date");

                entity.Property(e => e.VariationsEnabled).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CategoriesMercado>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_MercadoCategories");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryFeatures).IsUnicode(false);

                entity.Property(e => e.CategoryLevel).HasDefaultValueSql("((1))");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryParentId).HasColumnName("CategoryParentID");

                entity.Property(e => e.FeatureUpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<CategoryFavoritesBidStart>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryNamePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryNumberPath)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");
            });

            modelBuilder.Entity<CategoryFavoritesEbay>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryNamePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryNumberPath)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");
            });

            modelBuilder.Entity<CategoryFavoritesMercado>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryNamePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryNumberPath)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");
            });

            modelBuilder.Entity<ChangeDetails>(entity =>
            {
                entity.Property(e => e.ChangeDetailsId).HasColumnName("ChangeDetailsID");

                entity.Property(e => e.ChangeId).HasColumnName("ChangeID");

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NewValue)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OldValue)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Change)
                    .WithMany(p => p.ChangeDetails)
                    .HasForeignKey(d => d.ChangeId)
                    .HasConstraintName("FK_ChangeDetails_Changes");
            });

            modelBuilder.Entity<ChangeRequests>(entity =>
            {
                entity.HasKey(e => e.ChangeRequestId);

                entity.Property(e => e.ChangeRequestId)
                    .HasColumnName("ChangeRequestID")
                    .HasMaxLength(50);

                entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

                entity.Property(e => e.Result).IsRequired();

                entity.HasOne(d => d.Inventory)
                    .WithMany(p => p.ChangeRequests)
                    .HasForeignKey(d => d.InventoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChangeRequests_Inventory");
            });

            modelBuilder.Entity<Changes>(entity =>
            {
                entity.HasKey(e => e.ChangeId);

                entity.Property(e => e.ChangeId).HasColumnName("ChangeID");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserLoginId).HasColumnName("UserLoginID");

                entity.HasOne(d => d.UserLogin)
                    .WithMany(p => p.Changes)
                    .HasForeignKey(d => d.UserLoginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Changes_UserLogins");
            });

            modelBuilder.Entity<Charities>(entity =>
            {
                entity.HasKey(e => e.CharityId);

                entity.Property(e => e.CharityId)
                    .HasColumnName("CharityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Claims>(entity =>
            {
                entity.HasKey(e => e.ClaimId);

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ClaimType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ShipmentId).HasColumnName("ShipmentID");

                entity.Property(e => e.SsclaimId)
                    .HasColumnName("SSClaimID")
                    .HasMaxLength(50);

                entity.Property(e => e.SsclaimRetrievalCode)
                    .HasColumnName("SSClaimRetrievalCode")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<CollectionsShopify>(entity =>
            {
                entity.HasKey(e => e.CollectionId)
                    .HasName("PK_CollectionsShopify_1");

                entity.Property(e => e.CollectionId)
                    .HasColumnName("CollectionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BodyHtml)
                    .IsRequired()
                    .HasColumnName("BodyHTML");

                entity.Property(e => e.Handle).HasMaxLength(255);

                entity.Property(e => e.SellerAccountsShopifyId).HasColumnName("SellerAccountsShopifyID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.SellerAccountsShopify)
                    .WithMany(p => p.CollectionsShopify)
                    .HasForeignKey(d => d.SellerAccountsShopifyId)
                    .HasConstraintName("FK_CollectionsShopify_SellerAccountsShopify");
            });

            modelBuilder.Entity<CollectsShopify>(entity =>
            {
                entity.HasKey(e => e.CollectIndex);

                entity.Property(e => e.CollectId).HasColumnName("CollectID");

                entity.Property(e => e.CollectionId).HasColumnName("CollectionID");

                entity.Property(e => e.ItemShopifyId).HasColumnName("ItemShopifyID");

                entity.HasOne(d => d.Collection)
                    .WithMany(p => p.CollectsShopify)
                    .HasForeignKey(d => d.CollectionId)
                    .HasConstraintName("FK_CollectsShopify_CollectionsShopify");

                entity.HasOne(d => d.ItemShopify)
                    .WithMany(p => p.CollectsShopify)
                    .HasForeignKey(d => d.ItemShopifyId)
                    .HasConstraintName("FK_CollectsShopify_ItemsShopify");
            });

            modelBuilder.Entity<CompatibilitySets>(entity =>
            {
                entity.HasKey(e => e.CompatibilitySetId);

                entity.Property(e => e.CompatibilitySetId).HasColumnName("CompatibilitySetID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CompatibilitySetDefinition).HasColumnType("xml");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");
            });

            modelBuilder.Entity<ConditionsEbay>(entity =>
            {
                entity.HasKey(e => e.ConditionEbayId);

                entity.Property(e => e.ConditionEbayId)
                    .HasColumnName("ConditionEbayID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ConsignmentPlans>(entity =>
            {
                entity.HasKey(e => e.ConsignmentPlanId)
                    .HasName("PK_ConsignmentPlan");

                entity.Property(e => e.ConsignmentPlanId).HasColumnName("ConsignmentPlanID");

                entity.Property(e => e.BaseConsignmentFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CommissionScale).HasColumnType("xml");

                entity.Property(e => e.ConsignorSharePercent)
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((50))");

                entity.Property(e => e.FlatCommission).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IncludeFeesInCommission)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsFvfcharged).HasColumnName("IsFVFCharged");

                entity.Property(e => e.IsPpcharged).HasColumnName("IsPPCharged");

                entity.Property(e => e.MaxCommission).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MinCommission).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.OtherCommFees).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProfitSharingConsigneePaidFees)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProfitSharingConsignorPaidForItem)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ContactAccounts>(entity =>
            {
                entity.HasKey(e => e.ContactAccountId);

                entity.Property(e => e.ContactAccountId).HasColumnName("ContactAccountID");

                entity.Property(e => e.AuthPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuthUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bccaddress)
                    .HasColumnName("BCCAddress")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Ccaddress)
                    .HasColumnName("CCAddress")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FromAddress)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RemoteMailHost)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RemoteMailPort).HasDefaultValueSql("((25))");

                entity.Property(e => e.ReplyToAddress)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Signature).IsUnicode(false);

                entity.Property(e => e.SkypeId)
                    .HasColumnName("SkypeID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UseSsl).HasColumnName("UseSSL");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.HasIndex(e => e.CountryName)
                    .HasName("IX_Countries")
                    .IsUnique();

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressFormatId).HasColumnName("AddressFormatID");

                entity.Property(e => e.CountryCode).HasMaxLength(10);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EtsyCountryId).HasColumnName("EtsyCountryID");
            });

            modelBuilder.Entity<CreditCards>(entity =>
            {
                entity.HasKey(e => e.Ccid);

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.BuyerId).HasColumnName("BuyerID");

                entity.Property(e => e.CcexpMon).HasColumnName("CCExpMon");

                entity.Property(e => e.CcexpYear).HasColumnName("CCExpYear");

                entity.Property(e => e.Ccname)
                    .HasColumnName("CCName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ccnumber)
                    .HasColumnName("CCNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cctype)
                    .HasColumnName("CCType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DescriptionWrappers>(entity =>
            {
                entity.HasKey(e => e.DescriptionWrapperId);

                entity.Property(e => e.DescriptionWrapperId).HasColumnName("DescriptionWrapperID");

                entity.Property(e => e.Css)
                    .HasColumnName("CSS")
                    .IsUnicode(false);

                entity.Property(e => e.HtmlContent).IsUnicode(false);

                entity.Property(e => e.LayoutId).HasColumnName("LayoutID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.SubSiteId).HasColumnName("SubSiteID");
            });

            modelBuilder.Entity<Descriptions>(entity =>
            {
                entity.HasKey(e => e.DescriptionId)
                    .HasName("PK_Description");

                entity.Property(e => e.DescriptionId).HasColumnName("DescriptionID");

                entity.Property(e => e.Css)
                    .HasColumnName("CSS")
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ExternalDescriptionId)
                    .HasColumnName("ExternalDescriptionID")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<DetailsEbay>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ItemSpecificsDetails).IsUnicode(false);

                entity.Property(e => e.ShippingServiceDetails).IsUnicode(false);
            });

            modelBuilder.Entity<Dsrs>(entity =>
            {
                entity.HasKey(e => e.Dsrid);

                entity.ToTable("DSRs");

                entity.Property(e => e.Dsrid).HasColumnName("DSRID");

                entity.Property(e => e.RefreshDate).HasColumnType("date");

                entity.Property(e => e.SellerAccountseBayId).HasColumnName("SellerAccountseBayID");

                entity.Property(e => e.SellerRatingSummaryArray).HasColumnType("xml");

                entity.HasOne(d => d.SellerAccountseBay)
                    .WithMany(p => p.Dsrs)
                    .HasForeignKey(d => d.SellerAccountseBayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DSRs_SellerAccountseBay");
            });

            modelBuilder.Entity<DurationSetsEbay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DurationSetsEBay");

                entity.Property(e => e.DurationSetDefinition)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DurationSetId).HasColumnName("DurationSetID");
            });

            modelBuilder.Entity<EBayBusinessPolicies>(entity =>
            {
                entity.HasKey(e => e.EBayBusinessPolicyId);

                entity.ToTable("eBayBusinessPolicies");

                entity.HasIndex(e => e.Type)
                    .HasName("IX_Type");

                entity.Property(e => e.EBayBusinessPolicyId)
                    .HasColumnName("eBayBusinessPolicyID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.PolicyInfo).HasColumnType("xml");

                entity.Property(e => e.SellerAccount)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<EmailTemplates>(entity =>
            {
                entity.HasKey(e => e.EmailTemplateId);

                entity.Property(e => e.EmailTemplateId).HasColumnName("EmailTemplateID");

                entity.Property(e => e.HtmlContent).IsUnicode(false);

                entity.Property(e => e.IsCustom)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KeyName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.Subject).HasMaxLength(500);
            });

            modelBuilder.Entity<Feedbacks>(entity =>
            {
                entity.HasKey(e => e.FeedbackId);

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");

                entity.Property(e => e.Feedback)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");
            });

            modelBuilder.Entity<Feeds>(entity =>
            {
                entity.HasKey(e => e.FeedId);

                entity.HasIndex(e => e.ExternalFeedId);

                entity.Property(e => e.FeedId).HasColumnName("FeedID");

                entity.Property(e => e.ExternalFeedId)
                    .HasColumnName("ExternalFeedID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<GridLayouts>(entity =>
            {
                entity.HasKey(e => e.GridLayoutId);

                entity.Property(e => e.GridLayoutId).HasColumnName("GridLayoutID");

                entity.Property(e => e.GridSettings)
                    .IsRequired()
                    .HasColumnType("xml");

                entity.Property(e => e.GridSettingsBaseline).HasColumnType("xml");

                entity.Property(e => e.KeyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LayoutType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");
            });

            modelBuilder.Entity<ImageEditorMacros>(entity =>
            {
                entity.HasKey(e => e.MacroId);

                entity.Property(e => e.MacroId).HasColumnName("MacroID");

                entity.Property(e => e.Macro).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasIndex(e => e.ItemId);

                entity.HasIndex(e => e.Sku)
                    .HasName("UQ_Inventory_SKU")
                    .IsUnique();

                entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

                entity.Property(e => e.Asin)
                    .HasColumnName("ASIN")
                    .HasMaxLength(10);

                entity.Property(e => e.BuyItNowPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CatalogPhotoEbay)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Epid)
                    .HasColumnName("EPID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FbareconciliationDate).HasColumnName("FBAReconciliationDate");

                entity.Property(e => e.Features).HasColumnType("xml");

                entity.Property(e => e.FixedPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FixedPriceAmazon).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FixedPriceEtsy).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FixedPriceShopify).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FulfillmentChannelSku)
                    .IsRequired()
                    .HasColumnName("FulfillmentChannelSKU")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InventoryItemIdshopify).HasColumnName("InventoryItemIDShopify");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.MaximumSellerAllowedPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MinimumAdvertisedPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MinimumAdvertisedPriceExposure).HasDefaultValueSql("((2))");

                entity.Property(e => e.MinimumSellerAllowedPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Msrp)
                    .HasColumnName("MSRP")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PreferredSupplierId)
                    .HasColumnName("PreferredSupplierID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PricingTreatment).HasDefaultValueSql("((2))");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasMaxLength(100);

                entity.Property(e => e.ProductIdetsy).HasColumnName("ProductIDEtsy");

                entity.Property(e => e.QtyToList).HasDefaultValueSql("((1))");

                entity.Property(e => e.QtyUncommitted).HasComputedColumnSql("([dbo].[GetUncommittedForInventoryID]([inventoryid]))");

                entity.Property(e => e.ExternalQuantity).HasColumnName("ExternalQuantity");

                entity.Property(e => e.AmazonQuantity).HasColumnName("AmazonQuantity");

                entity.Property(e => e.ReservePrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SalePriceAmazon).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(255);

                entity.Property(e => e.StartingPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StorageLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxableShopify)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VariantIdshopify).HasColumnName("VariantIDShopify");

                entity.Property(e => e.Variation1).HasMaxLength(255);

                entity.Property(e => e.Variation2).HasMaxLength(255);

                entity.Property(e => e.Variation3).HasMaxLength(255);

                entity.Property(e => e.Variation4).HasMaxLength(255);

                entity.Property(e => e.Variation5).HasMaxLength(255);

                entity.Property(e => e.VariationInUse)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_Inventory_Items");
            });

            modelBuilder.Entity<InventoryFeeds>(entity =>
            {
                entity.HasKey(e => new { e.InventoryId, e.FeedId, e.MessageId });

                entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

                entity.Property(e => e.FeedId).HasColumnName("FeedID");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.HasOne(d => d.Feed)
                    .WithMany(p => p.InventoryFeeds)
                    .HasForeignKey(d => d.FeedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryFeeds_Feeds");

                entity.HasOne(d => d.Inventory)
                    .WithMany(p => p.InventoryFeeds)
                    .HasForeignKey(d => d.InventoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryFeeds_Items");
            });

            modelBuilder.Entity<ItemPromotionsEbay>(entity =>
            {
                entity.HasKey(e => e.ItemPromotionId);

                entity.Property(e => e.ItemPromotionId).HasColumnName("ItemPromotionID");

                entity.Property(e => e.Description).HasMaxLength(90);

                entity.Property(e => e.Name).HasMaxLength(90);

                entity.Property(e => e.PromotionId)
                    .HasColumnName("PromotionID")
                    .HasMaxLength(50);

                entity.Property(e => e.SellerAccountsEbayId).HasColumnName("SellerAccountsEbayID");

                entity.HasOne(d => d.SellerAccountsEbay)
                    .WithMany(p => p.ItemPromotionsEbay)
                    .HasForeignKey(d => d.SellerAccountsEbayId)
                    .HasConstraintName("FK_ItemPromotionsEbay_SellerAccountsEbay");
            });

            modelBuilder.Entity<ItemSpecificsEbay>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CatalogEnabledUpdateDate).HasColumnType("date");

                entity.Property(e => e.CatalogSearchCriteria)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CatalogSearchCriteriaUpdateDate).HasColumnType("date");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Csid).HasColumnName("CSID");

                entity.Property(e => e.RecommendedItemSpecifics).HasColumnType("xml");

                entity.Property(e => e.RecommendedUpdateDate).HasColumnType("date");

                entity.Property(e => e.UserItemSpecifics).HasColumnType("xml");
            });

            modelBuilder.Entity<ItemSpecificsMercado>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.RecommendedItemSpecifics).HasColumnType("xml");

                entity.Property(e => e.RecommendedUpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<ItemStatuses>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GridLayoutId)
                    .HasColumnName("GridLayoutID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ItemTemplates>(entity =>
            {
                entity.HasKey(e => e.ItemTemplateId);

                entity.Property(e => e.ItemTemplateId).HasColumnName("ItemTemplateID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemTemplates)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemTemplates_Items");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.HasIndex(e => e.BinId);

                entity.HasIndex(e => e.BusinessProfileId);

                entity.HasIndex(e => e.StatusId);

                entity.HasIndex(e => e.VariationSetId);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.BinId).HasColumnName("BinID");

                entity.Property(e => e.BusinessProfileId).HasColumnName("BusinessProfileID");

                entity.Property(e => e.CfCharger)
                    .HasColumnName("CF_Charger")
                    .HasMaxLength(4000);

                entity.Property(e => e.CfListedOn)
                    .HasColumnName("CF_ListedOn")
                    .HasMaxLength(4000);

                entity.Property(e => e.Condition).HasDefaultValueSql("((1))");

                entity.Property(e => e.ConsignmentPlanId)
                    .HasColumnName("ConsignmentPlanID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DimensionDepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.DimensionLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.DimensionWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.EnabledOnAmazon)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EnabledOnEbay)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EnabledOnEtsy)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EnabledOnShopify)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ExternalItemId)
                    .HasColumnName("ExternalItemID")
                    .HasMaxLength(100);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.OriginTemplateId)
                    .HasColumnName("OriginTemplateID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductBrand).HasMaxLength(100);

                entity.Property(e => e.ProductIdtype).HasColumnName("ProductIDType");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubStatusId).HasColumnName("SubStatusID");

                entity.Property(e => e.TareWeightMajor).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TareWeightMinor).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.VariationSetId).HasColumnName("VariationSetID");

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATPercent")
                    .HasColumnType("decimal(6, 3)");

                entity.Property(e => e.WeightMajor).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.WeightMinor).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Bin)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.BinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_Bins");

                entity.HasOne(d => d.BusinessProfile)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.BusinessProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_BusinessProfile");

                entity.HasOne(d => d.OriginTemplate)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.OriginTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_OriginTemplates");

                entity.HasOne(d => d.VariationSet)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.VariationSetId)
                    .HasConstraintName("FK_Items_VariationSets");
            });

            modelBuilder.Entity<ItemsAmazon>(entity =>
            {
                entity.Property(e => e.ItemsAmazonId).HasColumnName("ItemsAmazonID");

                entity.Property(e => e.AllocationPlanId)
                    .HasColumnName("AllocationPlanID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CatalogSummary).HasColumnType("xml");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConditionDescription).HasMaxLength(2000);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ParentAsin)
                    .HasColumnName("ParentASIN")
                    .HasMaxLength(10);

                entity.Property(e => e.ParentSku)
                    .HasColumnName("ParentSKU")
                    .HasMaxLength(40);

                entity.Property(e => e.RepricingPlanId)
                    .HasColumnName("RepricingPlanID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShippingTemplateId).HasColumnName("ShippingTemplateID");

                entity.HasOne(d => d.AllocationPlan)
                    .WithMany(p => p.ItemsAmazon)
                    .HasForeignKey(d => d.AllocationPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsAmazon_AllocationPlans");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ItemsAmazon)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsAmazon_CategoriesAmazon");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemsAmazon)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemsAmazon_Items");

                entity.HasOne(d => d.RepricingPlan)
                    .WithMany(p => p.ItemsAmazon)
                    .HasForeignKey(d => d.RepricingPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsAmazon_RepricingPlans");

                entity.HasOne(d => d.ShippingTemplate)
                    .WithMany(p => p.ItemsAmazon)
                    .HasForeignKey(d => d.ShippingTemplateId)
                    .HasConstraintName("FK_ItemsAmazon_ShippingTemplatesAmazon");
            });

            modelBuilder.Entity<ItemsBidstart>(entity =>
            {
                entity.HasKey(e => e.ItemBidstartId)
                    .HasName("PK_ItemsBidstart_1");

                entity.HasIndex(e => e.ItemId)
                    .HasName("UQ__ItemsBid__727E83EA3EF22DE0")
                    .IsUnique();

                entity.Property(e => e.ItemBidstartId).HasColumnName("ItemBidstartID");

                entity.Property(e => e.AllocationPlanId)
                    .HasColumnName("AllocationPlanID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DescriptionId).HasColumnName("DescriptionID");

                entity.Property(e => e.DescriptionWrapperId)
                    .HasColumnName("DescriptionWrapperID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ListingUpgradeId)
                    .HasColumnName("ListingUpgradeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PaymentTemplateId)
                    .HasColumnName("PaymentTemplateID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RepricingPlanId)
                    .HasColumnName("RepricingPlanID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShippingTemplateId)
                    .HasColumnName("ShippingTemplateID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SpotGoldPercent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SpotGoldPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.AllocationPlan)
                    .WithMany(p => p.ItemsBidstart)
                    .HasForeignKey(d => d.AllocationPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsBidstart_AllocationPlans");

                entity.HasOne(d => d.Category1Navigation)
                    .WithMany(p => p.ItemsBidstartCategory1Navigation)
                    .HasForeignKey(d => d.Category1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsBidStart_CategoriesBidStart");

                entity.HasOne(d => d.Category2Navigation)
                    .WithMany(p => p.ItemsBidstartCategory2Navigation)
                    .HasForeignKey(d => d.Category2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsBidStart_CategoriesBidStart2");

                entity.HasOne(d => d.Description)
                    .WithMany(p => p.ItemsBidstart)
                    .HasForeignKey(d => d.DescriptionId)
                    .HasConstraintName("FK_ItemsBidstart_Descriptions");

                entity.HasOne(d => d.DescriptionWrapper)
                    .WithMany(p => p.ItemsBidstart)
                    .HasForeignKey(d => d.DescriptionWrapperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsBidstart_DescriptionWrappers");

                entity.HasOne(d => d.Item)
                    .WithOne(p => p.ItemsBidstart)
                    .HasForeignKey<ItemsBidstart>(d => d.ItemId)
                    .HasConstraintName("FK_ItemsBidstart_Items");

                entity.HasOne(d => d.ListingUpgrade)
                    .WithMany(p => p.ItemsBidstart)
                    .HasForeignKey(d => d.ListingUpgradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsBidstart_ListingUpgrades");

                entity.HasOne(d => d.PaymentTemplate)
                    .WithMany(p => p.ItemsBidstart)
                    .HasForeignKey(d => d.PaymentTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsBidstart_PaymentTemplates");

                entity.HasOne(d => d.RepricingPlan)
                    .WithMany(p => p.ItemsBidstart)
                    .HasForeignKey(d => d.RepricingPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsBidstart_RepricingPlans");

                entity.HasOne(d => d.ShippingTemplate)
                    .WithMany(p => p.ItemsBidstart)
                    .HasForeignKey(d => d.ShippingTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsBidstart_ShippingTemplates");
            });

            modelBuilder.Entity<ItemsEbay>(entity =>
            {
                entity.HasKey(e => e.ItemEbayId)
                    .HasName("PK_ItemsEbay_1");

                entity.HasIndex(e => e.Category1);

                entity.HasIndex(e => e.Category2);

                entity.HasIndex(e => e.DescriptionId);

                entity.HasIndex(e => e.DescriptionWrapperId);

                entity.HasIndex(e => e.ItemId);

                entity.HasIndex(e => e.ListingUpgradeId);

                entity.HasIndex(e => e.PaymentPolicyId);

                entity.HasIndex(e => e.PaymentTemplateId);

                entity.HasIndex(e => e.ReturnPolicyId);

                entity.HasIndex(e => e.ShippingPolicyId);

                entity.HasIndex(e => e.ShippingTemplateId);

                entity.HasIndex(e => e.ThemeId);

                entity.Property(e => e.ItemEbayId).HasColumnName("ItemEbayID");

                entity.Property(e => e.AllocationPlanId)
                    .HasColumnName("AllocationPlanID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AutoAcceptBo).HasColumnName("AutoAcceptBO");

                entity.Property(e => e.AutoAcceptBopercent)
                    .HasColumnName("AutoAcceptBOPercent")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((80))");

                entity.Property(e => e.AutoAcceptBovalue)
                    .HasColumnName("AutoAcceptBOValue")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AutoAcceptBovalueType)
                    .HasColumnName("AutoAcceptBOValueType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AutoDeclineBo).HasColumnName("AutoDeclineBO");

                entity.Property(e => e.AutoDeclineBopercent)
                    .HasColumnName("AutoDeclineBOPercent")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((70))");

                entity.Property(e => e.AutoDeclineBovalue)
                    .HasColumnName("AutoDeclineBOValue")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AutoDeclineBovalueType)
                    .HasColumnName("AutoDeclineBOValueType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CatalogSummary).HasColumnType("xml");

                entity.Property(e => e.CharityId).HasColumnName("CharityID");

                entity.Property(e => e.CharityPercent).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CompatibilitySetId).HasColumnName("CompatibilitySetID");

                entity.Property(e => e.ConditionDescription).HasMaxLength(1000);

                entity.Property(e => e.ConditionId).HasColumnName("ConditionID");

                entity.Property(e => e.CounterId).HasColumnName("CounterID");

                entity.Property(e => e.DescriptionId).HasColumnName("DescriptionID");

                entity.Property(e => e.DescriptionWrapperId)
                    .HasColumnName("DescriptionWrapperID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemSpecifics).HasColumnType("xml");

                entity.Property(e => e.ListingUpgradeId)
                    .HasColumnName("ListingUpgradeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LotSize).HasDefaultValueSql("((1))");

                entity.Property(e => e.PaymentPolicyId).HasColumnName("PaymentPolicyID");

                entity.Property(e => e.PaymentTemplateId)
                    .HasColumnName("PaymentTemplateID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PictureSize).HasDefaultValueSql("((400))");

                entity.Property(e => e.ProductReferenceId)
                    .HasColumnName("ProductReferenceID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RepricingPlanId)
                    .HasColumnName("RepricingPlanID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReturnPolicyId).HasColumnName("ReturnPolicyID");

                entity.Property(e => e.ShippingPolicyId).HasColumnName("ShippingPolicyID");

                entity.Property(e => e.ShippingServiceCostOverrideList).HasColumnType("xml");

                entity.Property(e => e.ShippingTemplateId)
                    .HasColumnName("ShippingTemplateID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StockPhotoUrl)
                    .HasColumnName("StockPhotoURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitle).HasMaxLength(100);

                entity.Property(e => e.ThemeId)
                    .HasColumnName("ThemeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.AllocationPlan)
                    .WithMany(p => p.ItemsEbay)
                    .HasForeignKey(d => d.AllocationPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsEbay_AllocationPlans");

                entity.HasOne(d => d.Category1Navigation)
                    .WithMany(p => p.ItemsEbayCategory1Navigation)
                    .HasForeignKey(d => d.Category1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsEbay_CategoriesEbay");

                entity.HasOne(d => d.Category2Navigation)
                    .WithMany(p => p.ItemsEbayCategory2Navigation)
                    .HasForeignKey(d => d.Category2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsEbay_CategoriesEbay2");

                entity.HasOne(d => d.CompatibilitySet)
                    .WithMany(p => p.ItemsEbay)
                    .HasForeignKey(d => d.CompatibilitySetId)
                    .HasConstraintName("FK_ItemsEbay_CompatibilitySets");

                entity.HasOne(d => d.Description)
                    .WithMany(p => p.ItemsEbay)
                    .HasForeignKey(d => d.DescriptionId)
                    .HasConstraintName("FK_ItemsEbay_Descriptions");

                entity.HasOne(d => d.DescriptionWrapper)
                    .WithMany(p => p.ItemsEbay)
                    .HasForeignKey(d => d.DescriptionWrapperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsEbay_DescriptionWrappers");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemsEbay)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemsEbay_Items");

                entity.HasOne(d => d.ListingUpgrade)
                    .WithMany(p => p.ItemsEbay)
                    .HasForeignKey(d => d.ListingUpgradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsEbay_ListingUpgrades");

                entity.HasOne(d => d.PaymentTemplate)
                    .WithMany(p => p.ItemsEbay)
                    .HasForeignKey(d => d.PaymentTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsEbay_PaymentTemplates");

                entity.HasOne(d => d.RepricingPlan)
                    .WithMany(p => p.ItemsEbay)
                    .HasForeignKey(d => d.RepricingPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsEbay_RepricingPlans");

                entity.HasOne(d => d.ShippingTemplate)
                    .WithMany(p => p.ItemsEbay)
                    .HasForeignKey(d => d.ShippingTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsEbay_ShippingTemplates");
            });

            modelBuilder.Entity<ItemsEtsy>(entity =>
            {
                entity.HasKey(e => e.ItemEtsyId)
                    .HasName("PK_ItemsEtsy_1");

                entity.Property(e => e.ItemEtsyId).HasColumnName("ItemEtsyID");

                entity.Property(e => e.AllocationPlanId)
                    .HasColumnName("AllocationPlanID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Materials).HasMaxLength(597);

                entity.Property(e => e.RepricingPlanId)
                    .HasColumnName("RepricingPlanID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShippingTemplateId).HasColumnName("ShippingTemplateID");

                entity.Property(e => e.ShopSectionId).HasColumnName("ShopSectionID");

                entity.Property(e => e.Tags).HasMaxLength(272);

                entity.Property(e => e.TaxonomyEtsyId).HasColumnName("TaxonomyEtsyID");

                entity.Property(e => e.Title).HasMaxLength(140);

                entity.HasOne(d => d.AllocationPlan)
                    .WithMany(p => p.ItemsEtsy)
                    .HasForeignKey(d => d.AllocationPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsEtsy_AllocationPlans");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemsEtsy)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemsEtsy_Items");

                entity.HasOne(d => d.RepricingPlan)
                    .WithMany(p => p.ItemsEtsy)
                    .HasForeignKey(d => d.RepricingPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsEtsy_RepricingPlans");

                entity.HasOne(d => d.ShippingTemplate)
                    .WithMany(p => p.ItemsEtsy)
                    .HasForeignKey(d => d.ShippingTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsEtsy_ShippingTemplatesEtsy");

                entity.HasOne(d => d.ShopSection)
                    .WithMany(p => p.ItemsEtsy)
                    .HasForeignKey(d => d.ShopSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsEtsy_ShopSectionsEtsy");

                entity.HasOne(d => d.TaxonomyEtsy)
                    .WithMany(p => p.ItemsEtsy)
                    .HasForeignKey(d => d.TaxonomyEtsyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsEtsy_TaxonomyEtsy");
            });

            modelBuilder.Entity<ItemsMercado>(entity =>
            {
                entity.HasKey(e => e.ItemMercadoId)
                    .HasName("PK_ItemsMercado_1");

                entity.Property(e => e.ItemMercadoId).HasColumnName("ItemMercadoID");

                entity.Property(e => e.AllocationPlanId)
                    .HasColumnName("AllocationPlanID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DescriptionId).HasColumnName("DescriptionID");

                entity.Property(e => e.DescriptionWrapperId)
                    .HasColumnName("DescriptionWrapperID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemSpecifics).HasColumnType("xml");

                entity.Property(e => e.PaymentTemplateId)
                    .HasColumnName("PaymentTemplateID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PictureSize).HasDefaultValueSql("((400))");

                entity.Property(e => e.ProductReferenceId)
                    .HasColumnName("ProductReferenceID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RepricingPlanId)
                    .HasColumnName("RepricingPlanID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShippingTemplateId)
                    .HasColumnName("ShippingTemplateID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubTitle).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Warranty).HasMaxLength(500);

                entity.HasOne(d => d.AllocationPlan)
                    .WithMany(p => p.ItemsMercado)
                    .HasForeignKey(d => d.AllocationPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsMercado_AllocationPlans");

                entity.HasOne(d => d.Category1Navigation)
                    .WithMany(p => p.ItemsMercado)
                    .HasForeignKey(d => d.Category1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsMercado_CategoriesMercado");

                entity.HasOne(d => d.Description)
                    .WithMany(p => p.ItemsMercado)
                    .HasForeignKey(d => d.DescriptionId)
                    .HasConstraintName("FK_ItemsMercado_Descriptions");

                entity.HasOne(d => d.DescriptionWrapper)
                    .WithMany(p => p.ItemsMercado)
                    .HasForeignKey(d => d.DescriptionWrapperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsMercado_DescriptionWrappers");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemsMercado)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemsMercado_Items");

                entity.HasOne(d => d.PaymentTemplate)
                    .WithMany(p => p.ItemsMercado)
                    .HasForeignKey(d => d.PaymentTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsMercado_PaymentTemplates");

                entity.HasOne(d => d.RepricingPlan)
                    .WithMany(p => p.ItemsMercado)
                    .HasForeignKey(d => d.RepricingPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsMercado_RepricingPlans");

                entity.HasOne(d => d.ShippingTemplate)
                    .WithMany(p => p.ItemsMercado)
                    .HasForeignKey(d => d.ShippingTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsMercado_ShippingTemplates");
            });

            modelBuilder.Entity<ItemsShopify>(entity =>
            {
                entity.HasKey(e => e.ItemShopifyId);

                entity.Property(e => e.ItemShopifyId).HasColumnName("ItemShopifyID");

                entity.Property(e => e.AllocationPlanId)
                    .HasColumnName("AllocationPlanID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DescriptionWrapperId).HasColumnName("DescriptionWrapperID");

                entity.Property(e => e.Handle).IsRequired();

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ProductIdshopify).HasColumnName("ProductIDShopify");

                entity.Property(e => e.ProductType).IsRequired();

                entity.Property(e => e.Seodescription)
                    .IsRequired()
                    .HasColumnName("SEODescription")
                    .HasMaxLength(320);

                entity.Property(e => e.Seotitle)
                    .IsRequired()
                    .HasColumnName("SEOTitle")
                    .HasMaxLength(70);

                entity.Property(e => e.Tags).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.Property(e => e.Vendor).IsRequired();

                entity.HasOne(d => d.AllocationPlan)
                    .WithMany(p => p.ItemsShopify)
                    .HasForeignKey(d => d.AllocationPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsShopify_AllocationPlans");

                entity.HasOne(d => d.DescriptionWrapper)
                    .WithMany(p => p.ItemsShopify)
                    .HasForeignKey(d => d.DescriptionWrapperId)
                    .HasConstraintName("FK_ItemsShopify_DescriptionWrappers");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemsShopify)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemsShopify_Items");
            });

            modelBuilder.Entity<ItemsUploadLists>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.ItemId, e.UploadListId })
                    .HasName("IX_Items_UploadLists_Unique")
                    .IsUnique();

                entity.HasIndex(e => new { e.UploadListId, e.ItemId })
                    .HasName("PK_Items_UploadLists")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ItemId).HasColumnName("ItemID");
            });

            modelBuilder.Entity<LabelDefinitions>(entity =>
            {
                entity.HasKey(e => e.LabelDefinitionId);

                entity.Property(e => e.LabelDefinitionId).HasColumnName("LabelDefinitionID");

                entity.Property(e => e.Block1Height).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Block1Location)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Center')");

                entity.Property(e => e.Block1Margin)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0.1))");

                entity.Property(e => e.Block1Width).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Block2Height).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Block2Location)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Top Left')");

                entity.Property(e => e.Block2Margin)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0.1))");

                entity.Property(e => e.Block2Width).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.BottomMargin)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0.25))");

                entity.Property(e => e.ColumnCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.ColumnSpacing)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0.25))");

                entity.Property(e => e.FontName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('Arial')");

                entity.Property(e => e.FontSize)
                    .HasColumnType("decimal(4, 2)")
                    .HasDefaultValueSql("((12))");

                entity.Property(e => e.IsBold)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleteable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsEditable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPortrait)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LabelHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LabelWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftMargin).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.PageHeight)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((11))");

                entity.Property(e => e.PageWidth)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((8.5))");

                entity.Property(e => e.RightMargin)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0.25))");

                entity.Property(e => e.TopMargin)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0.25))");

                entity.Property(e => e.UnitOfMeasure).HasDefaultValueSql("((4))");
            });

            modelBuilder.Entity<ListingStatuses>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GridLayoutId)
                    .HasColumnName("GridLayoutID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ListingUpgradeTemplates>(entity =>
            {
                entity.HasKey(e => e.ListingUpgradeTemplateId)
                    .HasName("PK_ListingUpgrades");

                entity.Property(e => e.ListingUpgradeTemplateId).HasColumnName("ListingUpgradeTemplateID");

                entity.Property(e => e.Isv).HasColumnName("ISV");

                entity.Property(e => e.IsvnorthAmerica).HasColumnName("ISVNorthAmerica");

                entity.Property(e => e.Isvuk).HasColumnName("ISVUK");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");
            });

            modelBuilder.Entity<Listings>(entity =>
            {
                entity.HasKey(e => e.ListingId);

                entity.HasIndex(e => e.BuyerQuestionCount);

                entity.HasIndex(e => e.DescriptionId);

                entity.HasIndex(e => e.DescriptionWrapperId);

                entity.HasIndex(e => e.ECommerceId);

                entity.HasIndex(e => e.ItemId);

                entity.HasIndex(e => e.ListingUpgradeId);

                entity.HasIndex(e => e.OriginaleCommerceId);

                entity.HasIndex(e => e.PaymentTemplateId);

                entity.HasIndex(e => e.ShippingTemplateId);

                entity.HasIndex(e => e.Uuid);

                entity.HasIndex(e => new { e.SubmissionError, e.DeletionPending })
                    .HasName("IX_Listings_DeletionPending_SubmissionError");

                entity.HasIndex(e => new { e.StatusId, e.SubStatusId, e.ListingId, e.ItemId })
                    .HasName("IX_GridHelper");

                entity.HasIndex(e => new { e.StatusId, e.OutOfStock, e.SubStatusId, e.ListingId, e.SubmittedBy, e.SiteId, e.ItemId })
                    .HasName("IX_Listings_GETCOUNT_Helper");

                entity.HasIndex(e => new { e.BidCount, e.BuyItNowPrice, e.CurrentBidderEmail, e.CurrentBidderUserid, e.CurrentPrice, e.Duration, e.ECommerceId, e.EndDate, e.FixedPrice, e.HitCount, e.ItemId, e.LastBidDate, e.LastModifiedDate, e.LastRevisedDate, e.ListingFee, e.ListingId, e.ListingType, e.NumberSold, e.QtyToList, e.ReservePrice, e.ScheduleDate, e.SiteId, e.StartDate, e.StartingPrice, e.SubmittedBy, e.WatchCount, e.StatusId })
                    .HasName("IX_Listings_StatusID");

                entity.HasIndex(e => new { e.BidCount, e.BuyItNowPrice, e.CurrentBidderEmail, e.CurrentBidderUserid, e.CurrentPrice, e.Duration, e.ECommerceId, e.EndDate, e.FixedPrice, e.HitCount, e.LastBidDate, e.LastModifiedDate, e.LastRevisedDate, e.ListingFee, e.ListingId, e.ListingType, e.NumberSold, e.QtyToList, e.ReservePrice, e.ScheduleDate, e.SiteId, e.StartDate, e.StartingPrice, e.SubmittedBy, e.WatchCount, e.ItemId, e.StatusId })
                    .HasName("IX_Listings_ItemID_StatusID");

                entity.Property(e => e.ListingId).HasColumnName("ListingID");

                entity.Property(e => e.BusinessProfileId).HasColumnName("BusinessProfileID");

                entity.Property(e => e.BuyItNowPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CurrentBidderEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentBidderUserid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DescriptionId).HasColumnName("DescriptionID");

                entity.Property(e => e.DescriptionWrapperId)
                    .HasColumnName("DescriptionWrapperID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ECommerceId)
                    .HasColumnName("eCommerceID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FixedPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LastSaleTransactionId)
                    .HasColumnName("LastSaleTransactionID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListingFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ListingFeeDetails).HasColumnType("xml");

                entity.Property(e => e.ListingFeePaid).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ListingUpgradeId)
                    .HasColumnName("ListingUpgradeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.OfferId).HasColumnName("OfferID");

                entity.Property(e => e.OriginaleCommerceId)
                    .HasColumnName("OriginaleCommerceID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTemplateId)
                    .HasColumnName("PaymentTemplateID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QtyRemaining).HasComputedColumnSql("([QtyToList]-[NumberSold])");

                entity.Property(e => e.ReservePrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RevisionError).IsUnicode(false);

                entity.Property(e => e.SbmetaData)
                    .HasColumnName("SBMetaData")
                    .HasColumnType("xml");

                entity.Property(e => e.ScooriginaleCommerceId)
                    .HasColumnName("SCOOriginaleCommerceID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingTemplateId)
                    .HasColumnName("ShippingTemplateID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.SiteLink).HasMaxLength(250);

                entity.Property(e => e.StartingPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubStatusId).HasColumnName("SubStatusID");

                entity.Property(e => e.SubmissionError).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATPercent")
                    .HasColumnType("decimal(6, 3)");

                entity.HasOne(d => d.BusinessProfile)
                    .WithMany(p => p.Listings)
                    .HasForeignKey(d => d.BusinessProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Listings_BusinessProfile");

                entity.HasOne(d => d.Description)
                    .WithMany(p => p.Listings)
                    .HasForeignKey(d => d.DescriptionId)
                    .HasConstraintName("FK_Listings_Descriptions");

                entity.HasOne(d => d.DescriptionWrapper)
                    .WithMany(p => p.Listings)
                    .HasForeignKey(d => d.DescriptionWrapperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Listings_DescriptionWrappers");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Listings)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_Listings_Items");

                entity.HasOne(d => d.ListingUpgrade)
                    .WithMany(p => p.Listings)
                    .HasForeignKey(d => d.ListingUpgradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Listings_ListingUpgradeTemplates");

                entity.HasOne(d => d.PaymentTemplate)
                    .WithMany(p => p.Listings)
                    .HasForeignKey(d => d.PaymentTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Listings_PaymentTemplates");

                entity.HasOne(d => d.ShippingTemplate)
                    .WithMany(p => p.Listings)
                    .HasForeignKey(d => d.ShippingTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Listings_ShippingTemplates");
            });

            modelBuilder.Entity<ListingsBidstart>(entity =>
            {
                entity.HasKey(e => e.ListingBidStartId);

                entity.Property(e => e.ListingBidStartId).HasColumnName("ListingBidStartID");

                entity.Property(e => e.ListingIdlink).HasColumnName("ListingIDLink");

                entity.Property(e => e.SpotGoldPercent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SpotGoldPrice).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.ListingIdlinkNavigation)
                    .WithMany(p => p.ListingsBidstart)
                    .HasForeignKey(d => d.ListingIdlink)
                    .HasConstraintName("FK_ListingsBidstart_Listings");
            });

            modelBuilder.Entity<ListingsEbay>(entity =>
            {
                entity.HasKey(e => e.ListingEbayId)
                    .HasName("PK_ListingsEbay_1");

                entity.HasIndex(e => e.ListingIdlink);

                entity.HasIndex(e => e.PaymentPolicyId);

                entity.HasIndex(e => e.ReturnPolicyId);

                entity.HasIndex(e => e.ShippingPolicyId);

                entity.Property(e => e.ListingEbayId).HasColumnName("ListingEbayID");

                entity.Property(e => e.AdId).HasColumnName("AdID");

                entity.Property(e => e.AutoAcceptBo).HasColumnName("AutoAcceptBO");

                entity.Property(e => e.AutoAcceptBopercent)
                    .HasColumnName("AutoAcceptBOPercent")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((80))");

                entity.Property(e => e.AutoAcceptBovalue)
                    .HasColumnName("AutoAcceptBOValue")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AutoAcceptBovalueType).HasColumnName("AutoAcceptBOValueType");

                entity.Property(e => e.AutoDeclineBo).HasColumnName("AutoDeclineBO");

                entity.Property(e => e.AutoDeclineBopercent)
                    .HasColumnName("AutoDeclineBOPercent")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((70))");

                entity.Property(e => e.AutoDeclineBovalue)
                    .HasColumnName("AutoDeclineBOValue")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AutoDeclineBovalueType).HasColumnName("AutoDeclineBOValueType");

                entity.Property(e => e.CatalogSummary).HasColumnType("xml");

                entity.Property(e => e.CharityId).HasColumnName("CharityID");

                entity.Property(e => e.CharityPercent).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CompatibilitySetId).HasColumnName("CompatibilitySetID");

                entity.Property(e => e.ConditionDescription).HasMaxLength(1000);

                entity.Property(e => e.CounterId).HasColumnName("CounterID");

                entity.Property(e => e.ItemSpecifics).HasColumnType("xml");

                entity.Property(e => e.ListingIdlink).HasColumnName("ListingIDLink");

                entity.Property(e => e.ListingRecommendations)
                    .IsRequired()
                    .HasColumnType("xml")
                    .HasDefaultValueSql("('<Recommendations/>')");

                entity.Property(e => e.PaymentPolicyId).HasColumnName("PaymentPolicyID");

                entity.Property(e => e.PictureSize).HasDefaultValueSql("((400))");

                entity.Property(e => e.ReturnPolicyId).HasColumnName("ReturnPolicyID");

                entity.Property(e => e.ShippingPolicyId).HasColumnName("ShippingPolicyID");

                entity.Property(e => e.ShippingServiceCostOverrideList).HasColumnType("xml");

                entity.Property(e => e.StockPhotoUrl)
                    .HasColumnName("StockPhotoURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitle).HasMaxLength(100);

                entity.Property(e => e.ThemeId)
                    .HasColumnName("ThemeID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Ad)
                    .WithMany(p => p.ListingsEbay)
                    .HasForeignKey(d => d.AdId)
                    .HasConstraintName("FK__ListingsEb__AdID__36A7CBF9");

                entity.HasOne(d => d.CompatibilitySet)
                    .WithMany(p => p.ListingsEbay)
                    .HasForeignKey(d => d.CompatibilitySetId)
                    .HasConstraintName("FK_ListingsEbay_CompatibilitySets");

                entity.HasOne(d => d.ListingIdlinkNavigation)
                    .WithMany(p => p.ListingsEbay)
                    .HasForeignKey(d => d.ListingIdlink)
                    .HasConstraintName("FK_ListingsEbay_Listings");
            });

            modelBuilder.Entity<ListingsMercado>(entity =>
            {
                entity.HasKey(e => e.ListingMercadoId)
                    .HasName("PK_ListingsMercado_1");

                entity.Property(e => e.ListingMercadoId).HasColumnName("ListingMercadoID");

                entity.Property(e => e.CatalogSummary).HasColumnType("xml");

                entity.Property(e => e.ItemSpecifics).HasColumnType("xml");

                entity.Property(e => e.ListingIdlink).HasColumnName("ListingIDLink");

                entity.Property(e => e.PictureSize).HasDefaultValueSql("((400))");

                entity.Property(e => e.SubTitle).HasMaxLength(100);

                entity.Property(e => e.VideoLink).HasMaxLength(250);

                entity.Property(e => e.Warranty).HasMaxLength(500);

                entity.HasOne(d => d.ListingIdlinkNavigation)
                    .WithMany(p => p.ListingsMercado)
                    .HasForeignKey(d => d.ListingIdlink)
                    .HasConstraintName("FK_ListingsMercado_Listings");
            });

            modelBuilder.Entity<LocationKeyLink>(entity =>
            {
                entity.HasKey(e => new { e.BusinessProfileId, e.OriginTemplateId });

                entity.Property(e => e.BusinessProfileId).HasColumnName("BusinessProfileID");

                entity.Property(e => e.OriginTemplateId).HasColumnName("OriginTemplateID");

                entity.Property(e => e.LocationKey)
                    .IsRequired()
                    .HasMaxLength(36);

                entity.HasOne(d => d.BusinessProfile)
                    .WithMany(p => p.LocationKeyLink)
                    .HasForeignKey(d => d.BusinessProfileId)
                    .HasConstraintName("FK_LocationKeyLink_LocationKeyLink");

                entity.HasOne(d => d.OriginTemplate)
                    .WithMany(p => p.LocationKeyLink)
                    .HasForeignKey(d => d.OriginTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationKeyLink_OriginTemplates");
            });

            modelBuilder.Entity<LocationsShopify>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1).IsRequired();

                entity.Property(e => e.Address2).IsRequired();

                entity.Property(e => e.City).IsRequired();

                entity.Property(e => e.Country).IsRequired();

                entity.Property(e => e.CountryCode).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Phone).IsRequired();

                entity.Property(e => e.Province).IsRequired();

                entity.Property(e => e.ProvinceCode).IsRequired();

                entity.Property(e => e.SellerAccountsShopifyId).HasColumnName("SellerAccountsShopifyID");

                entity.Property(e => e.UpdatedAt).IsRequired();

                entity.Property(e => e.Zip).IsRequired();

                entity.HasOne(d => d.SellerAccountsShopify)
                    .WithMany(p => p.LocationsShopify)
                    .HasForeignKey(d => d.SellerAccountsShopifyId)
                    .HasConstraintName("FK_LocationsShopify_SellerAccountsShopify");
            });

            modelBuilder.Entity<Machines>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Settings).HasColumnType("xml");
            });

            modelBuilder.Entity<Manifests>(entity =>
            {
                entity.HasKey(e => e.ManifestId);

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.CarrierType).HasMaxLength(50);

                entity.Property(e => e.ConfirmationNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<MaterialTemplates>(entity =>
            {
                entity.HasKey(e => e.MaterialTemplateId)
                    .HasName("PK_Materials");

                entity.Property(e => e.MaterialTemplateId).HasColumnName("MaterialTemplateID");

                entity.Property(e => e.MaterialList).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Icon).HasMaxLength(100);

                entity.Property(e => e.Mode).HasMaxLength(50);
            });

            modelBuilder.Entity<OffersEtsy>(entity =>
            {
                entity.HasKey(e => e.OfferEtsyId);

                entity.HasIndex(e => e.InventoryId)
                    .HasName("IX_InventoryID");

                entity.HasIndex(e => new { e.SiteOfferId, e.SiteId })
                    .HasName("IX_SiteOfferID_SiteID");

                entity.Property(e => e.OfferEtsyId).HasColumnName("OfferEtsyID");

                entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.SiteOfferId)
                    .IsRequired()
                    .HasColumnName("SiteOfferID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Inventory)
                    .WithMany(p => p.OffersEtsy)
                    .HasForeignKey(d => d.InventoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffersEtsy_Inventory");
            });

            modelBuilder.Entity<OrderStatuses>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GridLayoutId)
                    .HasColumnName("GridLayoutID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.HasIndex(e => e.BuyerId);

                entity.HasIndex(e => new { e.OrderId, e.StatusId })
                    .HasName("IX_Orders_StatusID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ActualDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.AdjustmentCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AdjustmentCostReason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustmentFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AdjustmentFeeReason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddressID");

                entity.Property(e => e.BusinessProfileId).HasColumnName("BusinessProfileID");

                entity.Property(e => e.BuyerId).HasColumnName("BuyerID");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.CombinedOrderId)
                    .HasColumnName("CombinedOrderID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EarliestDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.EarliestShipDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalOrderId)
                    .HasColumnName("ExternalOrderID")
                    .HasMaxLength(50);

                entity.Property(e => e.ExternalTransactionDetails).HasColumnType("xml");

                entity.Property(e => e.ExternalTransactionId)
                    .HasColumnName("ExternalTransactionID")
                    .HasMaxLength(100);

                entity.Property(e => e.GiftWrapPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LatestDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.LatestShipDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PaymentProcessingFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.RemainingDueAmount)
                    .HasColumnType("decimal(13, 2)")
                    .HasComputedColumnSql("((([TotalDueAmount]+[SalesTax])+[AdjustmentFee])-[TotalPaidAmount])");

                entity.Property(e => e.SalesTax).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.SiteOrderId)
                    .HasColumnName("SiteOrderID")
                    .HasMaxLength(100);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1000))");

                entity.Property(e => e.SubStatusId).HasColumnName("SubStatusID");

                entity.Property(e => e.TotalDueAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TotalPaidAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Vatamount)
                    .HasColumnName("VATAmount")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.BusinessProfile)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.BusinessProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_BusinessProfile");

                entity.HasOne(d => d.Cc)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Ccid)
                    .HasConstraintName("FK_Orders_CreditCards");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_OrderStatuses");
            });

            modelBuilder.Entity<OrdersFeeds>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.FeedId });

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.FeedId).HasColumnName("FeedID");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.HasOne(d => d.Feed)
                    .WithMany(p => p.OrdersFeeds)
                    .HasForeignKey(d => d.FeedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersFeeds_Feeds");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrdersFeeds)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersFeeds_Orders");
            });

            modelBuilder.Entity<OriginTemplates>(entity =>
            {
                entity.HasKey(e => e.OriginTemplateId);

                entity.Property(e => e.OriginTemplateId).HasColumnName("OriginTemplateID");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'US')");

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.LocationAdditionalInformation).HasMaxLength(256);

                entity.Property(e => e.LocationInstructions).HasMaxLength(1000);

                entity.Property(e => e.LocationTypes).HasDefaultValueSql("((2))");

                entity.Property(e => e.LocationWebUrl)
                    .HasColumnName("LocationWebURL")
                    .HasMaxLength(512);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAddressId)
                    .HasColumnName("ReturnAddressID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ReturnAddress)
                    .WithMany(p => p.OriginTemplates)
                    .HasForeignKey(d => d.ReturnAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OriginTemplates_Addresses");
            });

            modelBuilder.Entity<PaymentServiceAccounts>(entity =>
            {
                entity.HasKey(e => e.PaymentServiceAccountId);

                entity.Property(e => e.PaymentServiceAccountId).HasColumnName("PaymentServiceAccountID");

                entity.Property(e => e.AccountLogin).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.PaymentService).HasMaxLength(20);

                entity.Property(e => e.SecretToken).HasMaxLength(100);

                entity.Property(e => e.Signature).HasMaxLength(100);

                entity.Property(e => e.Token).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(100);
            });

            modelBuilder.Entity<PaymentTemplates>(entity =>
            {
                entity.HasKey(e => e.PaymentTemplateId);

                entity.Property(e => e.PaymentTemplateId).HasColumnName("PaymentTemplateID");

                entity.Property(e => e.Ccother).HasColumnName("CCOther");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.DepositAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GoogleCheckoutId)
                    .HasColumnName("GoogleCheckoutID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleCheckoutKey)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.HoursToDeposit).HasDefaultValueSql("((72))");

                entity.Property(e => e.InternationalRefundPolicy).HasMaxLength(30);

                entity.Property(e => e.InternationalReturnPaidBy).HasMaxLength(10);

                entity.Property(e => e.InternationalReturnWithin).HasMaxLength(5);

                entity.Property(e => e.MoneybookersEmail)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NonMercadoPayment).HasColumnType("xml");

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.PayPalEmail)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentInstructions).IsUnicode(false);

                entity.Property(e => e.RefundPolicy).HasMaxLength(30);

                entity.Property(e => e.ReturnPaidBy).HasMaxLength(10);

                entity.Property(e => e.ReturnPolicy).IsUnicode(false);

                entity.Property(e => e.ReturnWithin).HasMaxLength(5);

                entity.Property(e => e.VisaMc).HasColumnName("VisaMC");
            });

            modelBuilder.Entity<PictureHosts>(entity =>
            {
                entity.HasKey(e => e.PictureHostId);

                entity.Property(e => e.PictureHostId).HasColumnName("PictureHostID");

                entity.Property(e => e.Ftppassword)
                    .HasColumnName("FTPPassword")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Ftpuserid)
                    .HasColumnName("FTPUserid")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HostSubdir)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HostUrl)
                    .HasColumnName("HostURL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RemoteFtphost)
                    .HasColumnName("RemoteFTPHost")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RemoteFtpport).HasColumnName("RemoteFTPPort");
            });

            modelBuilder.Entity<Pictures>(entity =>
            {
                entity.HasKey(e => e.PictureId);

                entity.HasIndex(e => e.IsVariationPicture);

                entity.HasIndex(e => e.ItemId);

                entity.HasIndex(e => e.VariationSpecificNameValue)
                    .HasName("IX_Pictures_VSNV");

                entity.Property(e => e.PictureId).HasColumnName("PictureID");

                entity.Property(e => e.DateLastUploaded).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsManualUrl).HasColumnName("IsManualURL");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ManualPictureUrl)
                    .HasColumnName("ManualPictureURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.PictureIdetsy)
                    .HasColumnName("PictureIDEtsy")
                    .HasMaxLength(50);

                entity.Property(e => e.PictureIdshopify).HasColumnName("PictureIDShopify");

                entity.Property(e => e.PictureUrl)
                    .HasColumnName("PictureURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PictureUrletsy)
                    .HasColumnName("PictureURLEtsy")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PictureUrlshopify)
                    .IsRequired()
                    .HasColumnName("PictureURLShopify")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VariationSpecificNameValue).HasMaxLength(250);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Pictures)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_Pictures_Items");
            });

            modelBuilder.Entity<PostageImages>(entity =>
            {
                entity.HasKey(e => e.PostageImageId);

                entity.Property(e => e.PostageImageId).HasColumnName("PostageImageID");

                entity.Property(e => e.ShipmentId).HasColumnName("ShipmentID");
            });

            modelBuilder.Entity<ProductFinders>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CatNumSiteId).HasColumnName("CatNumSiteID");

                entity.Property(e => e.ProductFinderId).HasColumnName("ProductFinderID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");
            });

            modelBuilder.Entity<PromotionsListings>(entity =>
            {
                entity.HasKey(e => new { e.PromotionId, e.ECommerceId })
                    .HasName("PK__Promotio__E02098AA8547165C");

                entity.Property(e => e.PromotionId)
                    .HasColumnName("PromotionID")
                    .HasMaxLength(50);

                entity.Property(e => e.ECommerceId)
                    .HasColumnName("eCommerceID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PurchaseOrderDetails>(entity =>
            {
                entity.Property(e => e.PurchaseOrderDetailsId).HasColumnName("PurchaseOrderDetailsID");

                entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

                entity.Property(e => e.PurchaseOrderId).HasColumnName("PurchaseOrderID");

                entity.Property(e => e.SupplierPrice).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Inventory)
                    .WithMany(p => p.PurchaseOrderDetails)
                    .HasForeignKey(d => d.InventoryId)
                    .HasConstraintName("FK_PurchaseOrderDetails_Inventory");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderDetails)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderDetails_PurchaseOrders");
            });

            modelBuilder.Entity<PurchaseOrders>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderId);

                entity.Property(e => e.PurchaseOrderId).HasColumnName("PurchaseOrderID");

                entity.Property(e => e.ActualDeliveryDate).HasDefaultValueSql("('')");

                entity.Property(e => e.Carrier)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EstimatedDeliveryDate).HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderedBy).HasMaxLength(50);

                entity.Property(e => e.OriginTemplateId).HasColumnName("OriginTemplateID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.OriginTemplate)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.OriginTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrders_OriginTemplates");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrders_Suppliers");
            });

            modelBuilder.Entity<Purchases>(entity =>
            {
                entity.HasKey(e => e.PurchaseId);

                entity.HasIndex(e => e.InventoryId);

                entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");

                entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopifyLocationId).HasColumnName("ShopifyLocationID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Inventory)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.InventoryId)
                    .HasConstraintName("FK_Purchases_Inventory");

                entity.HasOne(d => d.ShopifyLocation)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.ShopifyLocationId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Purchases_LocationsShopify");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Purchases_Suppliers");
            });

            modelBuilder.Entity<RateTablesEbay>(entity =>
            {
                entity.HasKey(e => new { e.RateTableEbayId, e.SellerAccount });

                entity.Property(e => e.RateTableEbayId).HasColumnName("RateTableEbayID");

                entity.Property(e => e.SellerAccount).HasMaxLength(255);

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<ReallocateReference>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ListingId });

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ListingId).HasColumnName("ListingID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ReallocateReference)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ReallocateReference_Items");

                entity.HasOne(d => d.Listing)
                    .WithMany(p => p.ReallocateReference)
                    .HasForeignKey(d => d.ListingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReallocateReference_Listings");
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.BaselineReportKeyName).HasMaxLength(100);

                entity.Property(e => e.IsEditable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KeyName).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.ParentReportKeyName).HasMaxLength(100);

                entity.Property(e => e.Report)
                    .IsRequired()
                    .HasColumnType("xml");

                entity.Property(e => e.ReportType).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ReportsAmazon>(entity =>
            {
                entity.HasKey(e => e.ReportRequestId);

                entity.Property(e => e.ReportRequestId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GeneratedReportId).HasMaxLength(50);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<RepricingPlans>(entity =>
            {
                entity.HasKey(e => e.RepricingPlanId)
                    .HasName("PK_RepricingPlan");

                entity.Property(e => e.RepricingPlanId).HasColumnName("RepricingPlanID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");
            });

            modelBuilder.Entity<Sales>(entity =>
            {
                entity.HasKey(e => e.SaleId);

                entity.HasIndex(e => e.ECommerceId);

                entity.HasIndex(e => e.ShipmentId);

                entity.HasIndex(e => e.TransactionId);

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.Property(e => e.AdFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CommissionIn).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ConsignmentPlanId)
                    .HasColumnName("ConsignmentPlanID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConsignorListingFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ConversionRate)
                    .HasColumnType("decimal(10, 3)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CurrencyCode).HasDefaultValueSql("((125))");

                entity.Property(e => e.CustomFields).HasColumnType("xml");

                entity.Property(e => e.DisputeId)
                    .HasColumnName("DisputeID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ECommerceId)
                    .HasColumnName("eCommerceID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExtendedPrice)
                    .HasColumnType("decimal(21, 2)")
                    .HasComputedColumnSql("([SalePrice]*[QtySold])");

                entity.Property(e => e.FeedbackMessageReceived).HasMaxLength(250);

                entity.Property(e => e.FeedbackMessageSent).HasMaxLength(250);

                entity.Property(e => e.FeedbackResponseSent).HasMaxLength(250);

                entity.Property(e => e.FeedbackTypeReceived).HasDefaultValueSql("((3))");

                entity.Property(e => e.FeedbackTypeSent).HasDefaultValueSql("((3))");

                entity.Property(e => e.Fvf)
                    .HasColumnName("FVF")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FvfrefundRequestedDate).HasColumnName("FVFRefundRequestedDate");

                entity.Property(e => e.ListingFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.OriginalChargedShippingCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OriginalShippingServiceId).HasColumnName("OriginalShippingServiceID");

                entity.Property(e => e.PaymentProcessingFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RawSalePrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SalePrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SalesTax).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ShipmentId).HasColumnName("ShipmentID");

                entity.Property(e => e.SiteSalesTaxCollectedAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.TotalConsignorCharges).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vatamount)
                    .HasColumnName("VATAmount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WeightMajor).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.WeightMinor).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.ShipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sales_Shipments");
            });

            modelBuilder.Entity<SalesPurchases>(entity =>
            {
                entity.HasKey(e => new { e.SaleId, e.PurchaseId });

                entity.HasIndex(e => new { e.PurchaseId, e.SaleId })
                    .HasName("IX_SalesPurchases")
                    .IsUnique();

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.SalesPurchases)
                    .HasForeignKey(d => d.PurchaseId)
                    .HasConstraintName("FK_SalesPurchases_Purchases");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SalesPurchases)
                    .HasForeignKey(d => d.SaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPurchases_Sales");
            });

            modelBuilder.Entity<SalesTax>(entity =>
            {
                entity.Property(e => e.SalesTaxId).HasColumnName("SalesTaxID");

                entity.Property(e => e.Authority)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessProfileId).HasColumnName("BusinessProfileID");

                entity.Property(e => e.TaxPercent)
                    .HasColumnType("decimal(6, 4)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SellerAccountsAmazon>(entity =>
            {
                entity.Property(e => e.SellerAccountsAmazonId).HasColumnName("SellerAccountsAmazonID");

                entity.Property(e => e.AccessKey).HasMaxLength(25);

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SecretKey).HasMaxLength(100);

                entity.Property(e => e.SellerId)
                    .HasColumnName("SellerID")
                    .HasMaxLength(255);

                entity.Property(e => e.SellerRefreshDetails).HasColumnType("xml");

                entity.Property(e => e.UseOutOfStockControl)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SellerAccountsBidStart>(entity =>
            {
                entity.Property(e => e.SellerAccountsBidStartId).HasColumnName("SellerAccountsBidStartID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SellerRefreshDetails).HasColumnType("xml");

                entity.Property(e => e.Token).IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SellerAccountsEtsy>(entity =>
            {
                entity.Property(e => e.SellerAccountsEtsyId).HasColumnName("SellerAccountsEtsyID");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Scopes).HasColumnType("xml");

                entity.Property(e => e.SellerRefreshDetails).HasColumnType("xml");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.ShopName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Token)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TokenSecret)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<SellerAccountsMercado>(entity =>
            {
                entity.Property(e => e.SellerAccountsMercadoId).HasColumnName("SellerAccountsMercadoID");

                entity.Property(e => e.AccessToken).HasMaxLength(150);

                entity.Property(e => e.BuyerMessageDetails).HasColumnType("xml");

                entity.Property(e => e.RefreshToken).HasMaxLength(75);

                entity.Property(e => e.SellerRefreshDetails).HasColumnType("xml");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(100);

                entity.Property(e => e.UserIdnumber)
                    .HasColumnName("UserIDNumber")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SellerAccountsShopify>(entity =>
            {
                entity.Property(e => e.SellerAccountsShopifyId).HasColumnName("SellerAccountsShopifyID");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Scopes).IsRequired();

                entity.Property(e => e.SellerRefreshDetails).IsRequired();

                entity.Property(e => e.ShopName).IsRequired();

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<SellerAccountseBay>(entity =>
            {
                entity.Property(e => e.SellerAccountsEbayId).HasColumnName("SellerAccountsEbayID");

                entity.Property(e => e.AccessTokenExpireDate).HasColumnType("datetime");

                entity.Property(e => e.BuyerMessageDetails).HasColumnType("xml");

                entity.Property(e => e.BuyerSatisfactionAlerts).HasColumnType("xml");

                entity.Property(e => e.CombinedPaymentPreferences).HasColumnType("xml");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EndOfAuctionEmailPreferences).HasColumnType("xml");

                entity.Property(e => e.LastRefresh).HasColumnType("datetime");

                entity.Property(e => e.NegativeFeedbackPeriodArray).HasColumnType("xml");

                entity.Property(e => e.NeutralFeedbackPeriodArray).HasColumnType("xml");

                entity.Property(e => e.PayPalAccountLevel)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayPalAccountStatus)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayPalAccountType)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PolicyComplianceAlerts).HasColumnType("xml");

                entity.Property(e => e.PositiveFeedbackPeriodArray).HasColumnType("xml");

                entity.Property(e => e.PowerSellerStatusAlerts).HasColumnType("xml");

                entity.Property(e => e.RefreshTokenExpireDate).HasColumnType("datetime");

                entity.Property(e => e.SearchStanding)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SellerAccount).IsUnicode(false);

                entity.Property(e => e.SellerAccountAlerts).HasColumnType("xml");

                entity.Property(e => e.SellerFeeDiscount).HasColumnType("numeric(6, 5)");

                entity.Property(e => e.SellerPaymentAddress).HasColumnType("xml");

                entity.Property(e => e.SellerPaymentPreferences).HasColumnType("xml");

                entity.Property(e => e.SellerRefreshDetails).HasColumnType("xml");

                entity.Property(e => e.SellerRoleMetrics).HasColumnType("xml");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.SkypeId)
                    .HasColumnName("SkypeID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StoreSite)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StoreUrl)
                    .HasColumnName("StoreURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Token).IsUnicode(false);

                entity.Property(e => e.TopRatedSellerDetails).HasColumnType("xml");

                entity.Property(e => e.TotalFeedbackPeriodArray).HasColumnType("xml");

                entity.Property(e => e.UserSubscriptions).HasColumnType("xml");
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.ApplicationVersion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0.0.0.0')");

                entity.Property(e => e.AutoFeedbackMsg)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryVersionEbayUs).HasColumnName("CategoryVersionEbayUS");

                entity.Property(e => e.Cfdefinition)
                    .HasColumnName("CFDefinition")
                    .HasColumnType("xml");

                entity.Property(e => e.DatabaseUuid)
                    .HasColumnName("DatabaseUUID")
                    .HasMaxLength(20);

                entity.Property(e => e.DomainLookup).HasColumnType("xml");

                entity.Property(e => e.DomainLookupUpdateDate).HasColumnType("date");

                entity.Property(e => e.DurationSetVersionEbayUs).HasColumnName("DurationSetVersionEbayUS");

                entity.Property(e => e.EndiciaAccountId)
                    .HasColumnName("EndiciaAccountID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndiciaPassphrase)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Express1AccountId)
                    .HasColumnName("Express1AccountID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Express1Passphrase)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Options)
                    .HasColumnType("xml")
                    .HasDefaultValueSql("('<Options><Items></Items><Listings></Listings><Orders><SetFulfilledOnPackingListPrinted>False</SetFulfilledOnPackingListPrinted><SetFulfilledOnPostagePrinted>False</SetFulfilledOnPostagePrinted><SetFulfilledOnInsurancePurchase>False</SetFulfilledOnInsurancePurchase><SetFulfilledOnFeedbackLeft>False</SetFulfilledOnFeedbackLeft></Orders><Maintenance></Maintenance><General><IsBetaTester>False</IsBetaTester></General><Pictures><PreferredLongestSide>400</PreferredLongestSide></Pictures></Options>')");

                entity.Property(e => e.RegisteredEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SiteIds)
                    .IsRequired()
                    .HasColumnName("SiteIDs")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<Shipments>(entity =>
            {
                entity.HasKey(e => e.ShipmentId);

                entity.HasIndex(e => e.OrderId)
                    .HasName("IX_Shipment_OrderID");

                entity.Property(e => e.ShipmentId).HasColumnName("ShipmentID");

                entity.Property(e => e.ActualInsuranceCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ActualShippingCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BillableItemId)
                    .HasColumnName("BillableItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.ChargedShippingCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DimensionDepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.DimensionLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.DimensionWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExternalManualService).HasMaxLength(100);

                entity.Property(e => e.ExternalManualServiceId)
                    .HasColumnName("ExternalManualServiceID")
                    .HasMaxLength(100);

                entity.Property(e => e.ExternalShipmentId)
                    .HasColumnName("ExternalShipmentID")
                    .HasMaxLength(50);

                entity.Property(e => e.HandlingFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.InsuranceId)
                    .HasColumnName("InsuranceID")
                    .HasMaxLength(50);

                entity.Property(e => e.InsuredValue).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IntegratedCarrierId).HasColumnName("IntegratedCarrierID");

                entity.Property(e => e.IsUspspickupRequested).HasColumnName("IsUSPSPickupRequested");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OriginTemplateId)
                    .HasColumnName("OriginTemplateID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ScanFormManifestId).HasColumnName("ScanFormManifestID");

                entity.Property(e => e.SelectedOrdinalId).HasColumnName("SelectedOrdinalID");

                entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddressID");

                entity.Property(e => e.ShippingServiceId).HasColumnName("ShippingServiceID");

                entity.Property(e => e.TrackingNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UspspickupManifestId).HasColumnName("USPSPickupManifestID");

                entity.Property(e => e.WeightMajor).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.WeightMinor).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipments_Orders");

                entity.HasOne(d => d.OriginTemplate)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.OriginTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipments_OriginTemplates");

                entity.HasOne(d => d.ScanFormManifest)
                    .WithMany(p => p.ShipmentsScanFormManifest)
                    .HasForeignKey(d => d.ScanFormManifestId)
                    .HasConstraintName("FK_Shipments_Manifests");

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipments_Addresses");

                entity.HasOne(d => d.UspspickupManifest)
                    .WithMany(p => p.ShipmentsUspspickupManifest)
                    .HasForeignKey(d => d.UspspickupManifestId)
                    .HasConstraintName("FK_Shipments_Manifests1");
            });

            modelBuilder.Entity<ShippingDiscountProfile>(entity =>
            {
                entity.HasKey(e => new { e.ShippingDiscountProfileId, e.SellerAccounteBay });

                entity.Property(e => e.ShippingDiscountProfileId)
                    .HasColumnName("ShippingDiscountProfileID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SellerAccounteBay)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");
            });

            modelBuilder.Entity<ShippingServices>(entity =>
            {
                entity.HasKey(e => e.ShippingServiceId);

                entity.HasIndex(e => e.EBayServiceId)
                    .HasName("IDX_eBayServiceID");

                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name");

                entity.Property(e => e.ShippingServiceId)
                    .HasColumnName("ShippingServiceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EBayServiceId).HasColumnName("eBayServiceID");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.GroupOrdinalId).HasColumnName("GroupOrdinalID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.PackageSizeAllowed)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");
            });

            modelBuilder.Entity<ShippingTemplateUpgradesEtsy>(entity =>
            {
                entity.HasKey(e => new { e.ShippingTemplateUpgradeId, e.ShippingTemplateId });

                entity.Property(e => e.ShippingTemplateUpgradeId).HasColumnName("ShippingTemplateUpgradeID");

                entity.Property(e => e.ShippingTemplateId).HasColumnName("ShippingTemplateID");

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SecondaryPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.ShippingTemplate)
                    .WithMany(p => p.ShippingTemplateUpgradesEtsy)
                    .HasForeignKey(d => d.ShippingTemplateId)
                    .HasConstraintName("FK_ShippingTemplateUpgradesEtsy_ShippingTemplateUpgradesEtsy");
            });

            modelBuilder.Entity<ShippingTemplates>(entity =>
            {
                entity.HasKey(e => e.ShippingTemplateId);

                entity.Property(e => e.ShippingTemplateId).HasColumnName("ShippingTemplateID");

                entity.Property(e => e.ApplyDomesticShippingDiscountProfileId).HasColumnName("ApplyDomesticShippingDiscountProfileID");

                entity.Property(e => e.ApplyInternationalShippingDiscountProfileId).HasColumnName("ApplyInternationalShippingDiscountProfileID");

                entity.Property(e => e.BidstartInsuranceCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BidstartInsuranceOption)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BidstartShippingCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BidstartShippingCostInt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BidstartShippingCostTier2).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BidstartShippingDiscount)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BidstartShippingService)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DomesticShippingDiscountProfileId)
                    .IsRequired()
                    .HasColumnName("DomesticShippingDiscountProfileID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.DomesticShippingRateTableId).HasColumnName("DomesticShippingRateTableID");

                entity.Property(e => e.HandlingFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IntShipToLocation1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IntShipToLocation2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IntShipToLocation3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IntShipToLocation4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IntShipToLocation5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IntShippingServiceAdditionalCost1).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IntShippingServiceAdditionalCost2).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IntShippingServiceAdditionalCost3).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IntShippingServiceAdditionalCost4).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IntShippingServiceAdditionalCost5).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IntShippingServiceCost1).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IntShippingServiceCost2).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IntShippingServiceCost3).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IntShippingServiceCost4).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IntShippingServiceCost5).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.InternationalHandlingFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.InternationalShippingDiscountProfileId)
                    .IsRequired()
                    .HasColumnName("InternationalShippingDiscountProfileID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.InternationalShippingRateTableId).HasColumnName("InternationalShippingRateTableID");

                entity.Property(e => e.InternationalShippingType).HasDefaultValueSql("((2))");

                entity.Property(e => e.MercadoFreeShippingServiceId).HasColumnName("MercadoFreeShippingServiceID");

                entity.Property(e => e.MercadoShippingMethods).HasColumnType("xml");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.SellerAccountsEbayId).HasColumnName("SellerAccountsEbayID");

                entity.Property(e => e.ShipToLocation).HasMaxLength(255);

                entity.Property(e => e.ShippingDetails).IsUnicode(false);

                entity.Property(e => e.ShippingServiceAdditionalCost1).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ShippingServiceAdditionalCost2).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ShippingServiceAdditionalCost3).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ShippingServiceAdditionalCost4).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ShippingServiceCost1).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ShippingServiceCost2).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ShippingServiceCost3).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ShippingServiceCost4).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ShippingType).HasDefaultValueSql("((2))");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.Surcharge1).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Surcharge2).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Surcharge3).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Surcharge4).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<ShippingTemplatesAmazon>(entity =>
            {
                entity.HasKey(e => e.ShippingTemplateId);

                entity.Property(e => e.ShippingTemplateId).HasColumnName("ShippingTemplateID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");
            });

            modelBuilder.Entity<ShippingTemplatesEtsy>(entity =>
            {
                entity.HasKey(e => e.ShippingTemplateId);

                entity.Property(e => e.ShippingTemplateId)
                    .HasColumnName("ShippingTemplateID")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.OriginCountryId).HasColumnName("OriginCountryID");

                entity.Property(e => e.ProcessingDaysLabel).HasMaxLength(255);

                entity.Property(e => e.SellerAccountsEtsyId).HasColumnName("SellerAccountsEtsyID");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.SellerAccountsEtsy)
                    .WithMany(p => p.ShippingTemplatesEtsy)
                    .HasForeignKey(d => d.SellerAccountsEtsyId)
                    .HasConstraintName("FK_ShippingTemplatesEtsy_SellerAccountsEtsy");
            });

            modelBuilder.Entity<ShopSectionsEtsy>(entity =>
            {
                entity.HasKey(e => e.ShopSectionId);

                entity.Property(e => e.ShopSectionId)
                    .HasColumnName("ShopSectionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.SellerAccountsEtsyId).HasColumnName("SellerAccountsEtsyID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.SellerAccountsEtsy)
                    .WithMany(p => p.ShopSectionsEtsy)
                    .HasForeignKey(d => d.SellerAccountsEtsyId)
                    .HasConstraintName("FK_ShopSectionsEtsy_SellerAccountsEtsy");
            });

            modelBuilder.Entity<Sites>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MetaData).HasColumnType("xml");

                entity.Property(e => e.SiteEnum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Snippets>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCustom)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OrdinalId)
                    .HasColumnName("OrdinalID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Snippet)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Type).HasComment("Type of snippet (0-Both, 1-Description, 2-Email)");
            });

            modelBuilder.Entity<StoreCategoriesEbay>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SellerAccount)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCategoryId).HasColumnName("StoreCategoryID");

                entity.Property(e => e.StoreCategoryName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoreCategoryFavoritesEbay>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.SellerAccount)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCategoryNamePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCategoryNumberPath)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubStatuses>(entity =>
            {
                entity.HasKey(e => e.SubStatusId);

                entity.Property(e => e.SubStatusId).HasColumnName("SubStatusID");

                entity.Property(e => e.Deleteable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Editable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GridLayoutId)
                    .HasColumnName("GridLayoutID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.ParentStatusId).HasColumnName("ParentStatusID");
            });

            modelBuilder.Entity<Suppliers>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.AccountNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AutoPayEmailAddress).HasMaxLength(80);

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentPlanId)
                    .HasColumnName("ConsignmentPlanID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DateLastModified).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Initial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.OriginTemplateId)
                    .HasColumnName("OriginTemplateID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.OriginTemplate)
                    .WithMany(p => p.Suppliers)
                    .HasForeignKey(d => d.OriginTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suppliers_OriginTemplates");
            });

            modelBuilder.Entity<TagTemplates>(entity =>
            {
                entity.HasKey(e => e.TagTemplateId)
                    .HasName("PK_Tags");

                entity.Property(e => e.TagTemplateId).HasColumnName("TagTemplateID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.TagList).IsUnicode(false);
            });

            modelBuilder.Entity<TagTemplatesShopify>(entity =>
            {
                entity.HasKey(e => e.ShopifyTagTemplateId);

                entity.Property(e => e.ShopifyTagTemplateId).HasColumnName("ShopifyTagTemplateID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");

                entity.Property(e => e.TagList).IsRequired();
            });

            modelBuilder.Entity<TaxonomyEtsy>(entity =>
            {
                entity.Property(e => e.TaxonomyEtsyId)
                    .HasColumnName("TaxonomyEtsyID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Parent).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Path).HasMaxLength(265);
            });

            modelBuilder.Entity<ThemesEbay>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.ThemeId)
                    .HasName("IX_Listings_ThemesEbay_ThemeID");

                entity.Property(e => e.Level).HasComputedColumnSql("([Node].[GetLevel]())");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.ThemeBottom).IsUnicode(false);

                entity.Property(e => e.ThemeId)
                    .HasColumnName("ThemeID")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.ThemeTop).IsUnicode(false);

                entity.Property(e => e.ThemeUserCellBottom).IsUnicode(false);

                entity.Property(e => e.ThemeUserCellTop).IsUnicode(false);

                entity.Property(e => e.ThemeUserContent).IsUnicode(false);

                entity.Property(e => e.Thumbnail).HasColumnType("image");
            });

            modelBuilder.Entity<Tt19c29d5e8ba04371be257cf896dac097>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TT19c29d5e8ba04371be257cf896dac097");

                entity.Property(e => e.Ordinal).HasColumnName("ordinal");

                entity.Property(e => e.RowId).HasColumnName("rowID");
            });

            modelBuilder.Entity<Tt5e940379542c493b9a55251a370a8b95>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TT5e940379542c493b9a55251a370a8b95");

                entity.Property(e => e.Ordinal).HasColumnName("ordinal");

                entity.Property(e => e.RowId).HasColumnName("rowID");
            });

            modelBuilder.Entity<Ttc6a9ba97b81d47eb8e5fee5b5605ae8e>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TTc6a9ba97b81d47eb8e5fee5b5605ae8e");

                entity.Property(e => e.Ordinal).HasColumnName("ordinal");

                entity.Property(e => e.RowId).HasColumnName("rowID");
            });

            modelBuilder.Entity<UploadLists>(entity =>
            {
                entity.HasKey(e => e.UploadListId);

                entity.Property(e => e.UploadListId).HasColumnName("UploadListID");

                entity.Property(e => e.GridLayoutId)
                    .HasColumnName("GridLayoutID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCustom)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OrdinalId).HasColumnName("OrdinalID");
            });

            modelBuilder.Entity<UserLogins>(entity =>
            {
                entity.HasKey(e => e.UserLoginId);

                entity.Property(e => e.UserLoginId).HasColumnName("UserLoginID");

                entity.Property(e => e.BuyersGridSettings).IsUnicode(false);

                entity.Property(e => e.ItemsGridSettings).IsUnicode(false);

                entity.Property(e => e.ListingsGridSettings).IsUnicode(false);

                entity.Property(e => e.OrdersGridSettings).IsUnicode(false);

                entity.Property(e => e.Permissions)
                    .HasColumnType("xml")
                    .HasDefaultValueSql("('<Permissions/>')");

                entity.Property(e => e.Settings)
                    .HasColumnType("xml")
                    .HasDefaultValueSql("('<Settings/>')");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VariationSets>(entity =>
            {
                entity.HasKey(e => e.VariationSetId);

                entity.Property(e => e.VariationSetId).HasColumnName("VariationSetID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PictureIndex).HasDefaultValueSql("((1))");

                entity.Property(e => e.Variations)
                    .IsRequired()
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<Views>(entity =>
            {
                entity.HasKey(e => e.ViewId);

                entity.Property(e => e.ViewId).HasColumnName("ViewID");

                entity.Property(e => e.ConditionXml)
                    .HasColumnName("ConditionXML")
                    .HasColumnType("xml");

                entity.Property(e => e.GridLayoutId)
                    .HasColumnName("GridLayoutID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyName).HasMaxLength(50);

                entity.Property(e => e.Mode).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.OrdinalId)
                    .HasColumnName("OrdinalID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SearchQuery)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.UserLoginId).HasColumnName("UserLoginID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
