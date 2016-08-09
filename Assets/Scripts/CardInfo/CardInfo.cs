using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardInfo : BaseCardInfo {

	public int PurchasePrice {get;}
	public int LayPrice {get;}
	public int SitePrice {get;}
	public int H1_Price {get;}
	public int H2_Price {get;}
	public int H3_Price {get;}
	public int H4_Price {get;}
	public int HotelPrice {get;}
	public int Position {get;}
    public CardInfo(string title, Group group, List<int> providerCardInfo) 
        :base(title, group)
    {
        if (providerCardInfo == null || providerCardInfo.Count < 8)
        {
            Debug.LogError($"Class:{GetType()}\n ctor: provider is null or less needed count");
        }
        PurchasePrice = providerCardInfo[0];
        LayPrice = PurchasePrice / 2;
        SitePrice = providerCardInfo[1];
        H1_Price = providerCardInfo[2];
        H2_Price = providerCardInfo[3];
        H3_Price = providerCardInfo[4];
        H4_Price = providerCardInfo[5];
        HotelPrice = providerCardInfo[6];
        Position = providerCardInfo[7];
    }
}
