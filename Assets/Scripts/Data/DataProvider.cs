using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Assets.Scripts.MonopolyCore;
using UnityEngine;

namespace Assets.Scripts.Data
{
    public class DataProvider : MonoBehaviour
    { 
        #region DataProvider Singleton
        private static readonly Lazy<DataProvider> InstanceContainer = new Lazy<DataProvider>(GetInstanceInternal);

        private static DataProvider GetInstanceInternal()
        {
            DataProvider result = FindObjectOfType<DataProvider>();
            if(result == null)
                throw new Exception("DataProvider Not Finded");

            if(FindObjectsOfType<DataProvider>().Length > 1)
                throw new Exception("DataProvider is Not Only provider");

            return result;
        }
        #endregion

        void Awake()
        {
            CardSprites = new List<Sprite>();
            TextData = Resources.Load<TextAsset>("Cards").text.Split('\n').ToList();
           
            GenerateCards();
            
        }

        public static DataProvider GetInstance() => InstanceContainer.Value;

        private IList<Sprite> CardSprites { get; set; }

        private IList<string> TextData { get; set; }

        public IDictionary<int, CardInfo> Cards { get; } = new SortedDictionary<int, CardInfo>();

        private void GenerateCards()
        {
            foreach (var row in TextData)
            {
                var rowData = row.Split(',');
                int position = int.Parse(rowData[9]);

                #region CardInfo Constructor
                CardInfo rowInfo = new CardInfo(
                        //Name
                        rowData[0],
                        //Position
                        position,
                        //PurchasePrice
                        int.Parse(rowData[1]),
                        //layPrice
                        int.Parse(rowData[1]) / 2,
                        //sitePrice
                        int.Parse(rowData[2]),
                        // h1Price
                        int.Parse(rowData[3]),
                        // h2Price
                        int.Parse(rowData[4]),
                        // h3Price
                        int.Parse(rowData[5]),
                        // h4Price
                        int.Parse(rowData[6]),
                        // hotelPrice
                        int.Parse(rowData[7]),
                        //Group
                        int.Parse(rowData[8]),
                        //sprite
                        Resources.Load<Sprite>(position.ToString())
                    );
                #endregion

                Cards.Add(position, rowInfo);
            }
        }


        
        #region Get Count Cards of Group
        public int GetCountCardsOfGroup(ColorGroup group)
        {
            return TextData.Count(row => Convert.ToInt32(row.Split(',')[8]) == (int) group);
        }
        #endregion
        #region Get Cards Names
        public IEnumerable<string> GetCardsNames()
        {
            return TextData.Select(item => item.Split(',')[0]);
        }
        #endregion
    }
}

