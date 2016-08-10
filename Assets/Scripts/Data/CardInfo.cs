using UnityEngine;

namespace Assets.Scripts.Data
{
    public struct CardInfo
    {

        public CardInfo
            (
            string title,
            int position,
            int purchasePrice,
            int layPrice,
            int sitePrice,
            int h1_Price,
            int h2_Price,
            int h3_Price,
            int h4_Price,
            int hotel_price,
            int group,
            Sprite sprite
            )
        {
            Title = title;
            Position = position;
            PurchasePrice = purchasePrice;
            LayPrice = layPrice;
            SitePrice = sitePrice;
            H1_Price = h1_Price;
            H2_Price = h2_Price;
            H3_Price = h3_Price;
            H4_Price = h4_Price;
            HotelPrice = hotel_price;
            Group = group;
            CardSprite = sprite;
        }

        public string Title { get; }

        public int Position { get; }

        public int PurchasePrice { get; }

        public int LayPrice { get; }

        public int SitePrice { get; }

        public int H1_Price { get; }

        public int H2_Price { get; }

        public int H3_Price { get; }

        public int H4_Price { get; }

        public int HotelPrice { get; }

        public int Group { get; }

        public Sprite CardSprite { get; }
    }
}
