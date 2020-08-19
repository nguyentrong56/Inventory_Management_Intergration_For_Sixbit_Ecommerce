using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ItemsMercado
    {
        public int ItemMercadoId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public int DescriptionWrapperId { get; set; }
        public int? DescriptionId { get; set; }
        public int ShippingTemplateId { get; set; }
        public int PaymentTemplateId { get; set; }
        public int Category1 { get; set; }
        public string ItemSpecifics { get; set; }
        public int ItemId { get; set; }
        public bool PictureResize { get; set; }
        public short PictureSize { get; set; }
        public bool SelfHostPictures { get; set; }
        public string ProductReferenceId { get; set; }
        public int AllocationPlanId { get; set; }
        public int RepricingPlanId { get; set; }
        public string Warranty { get; set; }
        public string VideoLink { get; set; }

        public virtual AllocationPlans AllocationPlan { get; set; }
        public virtual CategoriesMercado Category1Navigation { get; set; }
        public virtual Descriptions Description { get; set; }
        public virtual DescriptionWrappers DescriptionWrapper { get; set; }
        public virtual Items Item { get; set; }
        public virtual PaymentTemplates PaymentTemplate { get; set; }
        public virtual RepricingPlans RepricingPlan { get; set; }
        public virtual ShippingTemplates ShippingTemplate { get; set; }
    }
}
