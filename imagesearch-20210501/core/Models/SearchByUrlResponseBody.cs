// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20210501.Models
{
    public class SearchByUrlResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchByUrlResponseBodyData Data { get; set; }
        public class SearchByUrlResponseBodyData : TeaModel {
            [NameInMap("Auctions")]
            [Validation(Required=false)]
            public List<SearchByUrlResponseBodyDataAuctions> Auctions { get; set; }
            public class SearchByUrlResponseBodyDataAuctions : TeaModel {
                public SearchByUrlResponseBodyDataAuctionsResult Result { get; set; }
                public class SearchByUrlResponseBodyDataAuctionsResult : TeaModel {
                    [NameInMap("ItemId")]
                    [Validation(Required=false)]
                    public string ItemId { get; set; }

                    [NameInMap("ItemName")]
                    [Validation(Required=false)]
                    public string ItemName { get; set; }

                    [NameInMap("Pic")]
                    [Validation(Required=false)]
                    public string Pic { get; set; }

                    [NameInMap("Price")]
                    [Validation(Required=false)]
                    public string Price { get; set; }

                    [NameInMap("PromotionPrice")]
                    [Validation(Required=false)]
                    public string PromotionPrice { get; set; }

                    [NameInMap("UserType")]
                    [Validation(Required=false)]
                    public int? UserType { get; set; }

                    [NameInMap("Provcity")]
                    [Validation(Required=false)]
                    public string Provcity { get; set; }

                    [NameInMap("SellerNickName")]
                    [Validation(Required=false)]
                    public string SellerNickName { get; set; }

                    [NameInMap("SellerId")]
                    [Validation(Required=false)]
                    public string SellerId { get; set; }

                    [NameInMap("MonthSellCount")]
                    [Validation(Required=false)]
                    public int? MonthSellCount { get; set; }

                    [NameInMap("LevelOneCategoryName")]
                    [Validation(Required=false)]
                    public string LevelOneCategoryName { get; set; }

                    [NameInMap("CategoryName")]
                    [Validation(Required=false)]
                    public string CategoryName { get; set; }

                    [NameInMap("CouponTotalCount")]
                    [Validation(Required=false)]
                    public string CouponTotalCount { get; set; }

                    [NameInMap("CouponRemainCount")]
                    [Validation(Required=false)]
                    public int? CouponRemainCount { get; set; }

                    [NameInMap("CouponStartTime")]
                    [Validation(Required=false)]
                    public string CouponStartTime { get; set; }

                    [NameInMap("CouponEndTime")]
                    [Validation(Required=false)]
                    public string CouponEndTime { get; set; }

                    [NameInMap("CouponStartFee")]
                    [Validation(Required=false)]
                    public string CouponStartFee { get; set; }

                    [NameInMap("CouponAmount")]
                    [Validation(Required=false)]
                    public int? CouponAmount { get; set; }

                    [NameInMap("CouponSaleTextInfo")]
                    [Validation(Required=false)]
                    public string CouponSaleTextInfo { get; set; }

                    [NameInMap("CommissionRate")]
                    [Validation(Required=false)]
                    public string CommissionRate { get; set; }

                    [NameInMap("CouponShareUrl")]
                    [Validation(Required=false)]
                    public string CouponShareUrl { get; set; }

                    [NameInMap("ClickUrl")]
                    [Validation(Required=false)]
                    public string ClickUrl { get; set; }

                }
                public float? RankScore { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PicInfo")]
        [Validation(Required=false)]
        public SearchByUrlResponseBodyPicInfo PicInfo { get; set; }
        public class SearchByUrlResponseBodyPicInfo : TeaModel {
            [NameInMap("MainRegion")]
            [Validation(Required=false)]
            public SearchByUrlResponseBodyPicInfoMainRegion MainRegion { get; set; }
            public class SearchByUrlResponseBodyPicInfoMainRegion : TeaModel {
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("MultiCategoryId")]
                [Validation(Required=false)]
                public List<SearchByUrlResponseBodyPicInfoMainRegionMultiCategoryId> MultiCategoryId { get; set; }
                public class SearchByUrlResponseBodyPicInfoMainRegionMultiCategoryId : TeaModel {
                    [NameInMap("CategoryId")]
                    [Validation(Required=false)]
                    public int? CategoryId { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

            }
            [NameInMap("MultiRegion")]
            [Validation(Required=false)]
            public List<SearchByUrlResponseBodyPicInfoMultiRegion> MultiRegion { get; set; }
            public class SearchByUrlResponseBodyPicInfoMultiRegion : TeaModel {
                public string Region { get; set; }
            }
        };

    }

}