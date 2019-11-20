using System.Collections.Generic;
using UltimateTeam.Toolkit.Parameters;

namespace UltimateTeam.Toolkit.Models
{
    public class ItemData
    {
        public long AssetId { get; set; }

        public ushort Assists { get; set; }

        public ushort Gold { get; set; }

        public ushort Silver { get; set; }

        public ushort Bronze { get; set; }

        public int WeightRare { get; set; }

        public int Amount { get; set; }

        public int? Negotiation { get; set; }

        public string Description { get; set; }

        public string DetailDescription { get; set; }

        public string BioDescription { get; set; }

        public List<Attribute> AttributeList { get; set; }

        public ushort Category { get; set; }

        public int Capacity { get; set; }

        public string Name { get; set; }

        public ushort CardSubTypeId { get; set; }

        public ushort CardAssetId { get; set; }

        public int Contract { get; set; }

        public bool Dream { get; set; }

        public ushort? DiscardValue { get; set; }

        public int? Value { get; set; }

        public int? Weightrare { get; set; }

        public string Header { get; set; }

        public string Manufacturer { get; set; }

        public int? Year { get; set; }

        public int Fitness { get; set; }

        public string Formation { get; set; }

        public long Id { get; set; }

        public int InjuryGames { get; set; }

        public string InjuryType { get; set; }

        public string ItemState { get; set; }

        public string ItemType { get; set; }

        public uint LastSalePrice { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public uint LeagueId { get; set; }

        public ushort LifeTimeAssists { get; set; }

        public ushort Loans { get; set; }

        public List<Attribute> LifeTimeStats { get; set; }

        public int LoyaltyBonus { get; set; }

        public uint MarketDataMaxPrice { get; set; }

        public uint MarketDataMinPrice { get; set; }

        public int Morale { get; set; }

        public int Owners { get; set; }

        public ChemistryStyle PlayStyle { get; set; }

        public string PreferredPosition { get; set; }

        public int RareFlag { get; set; }

        public int Rating { get; set; }

        public long ResourceId { get; set; }

        public List<Attribute> StatsList { get; set; }

        public int Suspension { get; set; }

        public uint TeamId { get; set; }

        public uint StadiumId { get; set; }

        public string Timestamp { get; set; }

        public int Training { get; set; }

        public bool Untradeable { get; set; }

        public int Pile { get; set; }

        public int Nation { get; set; }

        public TrainingItem TrainingItem { get; set; }

        public string ResourceGameYear { get; set; }

        public string FieldPos { get; set; }

        public string PosBonus { get; set; }

        public string ChantsCount { get; set; }

    }
}
