using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class DataProvider : MonoBehaviour {

    private static DataProvider _staticProvider;
    public static DataProvider StaticProvider
    {
        get
        {
            if (_staticProvider != null) return _staticProvider;

            _staticProvider = new DataProvider();
            _staticProvider.CardSprites = new List<Sprite>();
            _staticProvider.Data = Resources.Load<TextAsset>("Cards").text.Split('\n').ToList();
            _staticProvider.CardSprites = Resources.LoadAll<Sprite>("Sprites").ToList();
            return _staticProvider;
        }
    }

    private TextAsset CardsInfo;
    public List<Sprite> CardSprites { get; private set; }
	private List<string> Data;	
	



	
	

	/// <summary>
	///  IN Case of Estate and upper Card 
	/// 0 = name; 1 = PurchasePrice, 2 = RentPrice, 3 = Price with 1 home
	/// 4 = Price with 2 home, 5 = 3homes, 6 = 4 homes, 7 = Hotel, 8 group, 
	/// 9 position on board 
	/// IN case of ACTIVITY CARD
	/// 0 = name, 1 = 
	/// </summary>
	/// <returns>The card info.</returns>
	/// <param name="Name">Name.</param>
	public CardInfo GetCardInfo(string Name)
	{

		var temp = Data.FirstOrDefault(n => n == Name)?.Split(',');
        if (temp == null)
        {
            Debug.LogError($"CardInfo: Card With Name:{Name} not found");
            return null;
        } 
		return new CardInfo(
            temp[0],     
            (Group)int.Parse(temp[8]),
            new List<int>()
            {
                int.Parse(temp[1]),
                int.Parse(temp[2]),
                int.Parse(temp[3]),
                int.Parse(temp[4]),
                int.Parse(temp[5]),
                int.Parse(temp[6]),
                int.Parse(temp[7]),
                int.Parse(temp[9])
            });
	}
	#endregion
	#region Get Count Cards of Group
	public int GetCountCardsOfGroup(Group group)
	{
        return Data.Where(gr => ((Group)int.Parse(gr.Split(',')[8])) == group).Count();
	}
	#endregion
	#region Get Cards Names
	public List<string> GetCardsNames()
	{
        return Data.ConvertAll(item => item.Split(',')[0]);
    }
	#endregion
}

