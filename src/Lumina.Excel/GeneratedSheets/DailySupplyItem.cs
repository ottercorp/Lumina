// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DailySupplyItem", columnHash: 0x5e7b2507 )]
    public class DailySupplyItem : ExcelRow
    {
        public class UnkData0Obj
        {
            public int Item;
            public byte Quantity;
            public byte RecipeLevel;
        }
        
        public UnkData0Obj[] UnkData0 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnkData0 = new UnkData0Obj[ 8 ];
            for( var i = 0; i < 8; i++ )
            {
                UnkData0[ i ] = new UnkData0Obj();
                UnkData0[ i ].Item = parser.ReadColumn< int >( 0 + ( i * 3 + 0 ) );
                UnkData0[ i ].Quantity = parser.ReadColumn< byte >( 0 + ( i * 3 + 1 ) );
                UnkData0[ i ].RecipeLevel = parser.ReadColumn< byte >( 0 + ( i * 3 + 2 ) );
            }
        }
    }
}