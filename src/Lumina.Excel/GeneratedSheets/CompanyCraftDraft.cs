// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftDraft", columnHash: 0xdf938294 )]
    public class CompanyCraftDraft : ExcelRow
    {
        public class UnkData2Obj
        {
            public int RequiredItem;
            public byte RequiredItemCount;
        }
        
        public SeString Name { get; set; }
        public LazyRow< CompanyCraftDraftCategory > CompanyCraftDraftCategory { get; set; }
        public UnkData2Obj[] UnkData2 { get; set; }
        public uint Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            CompanyCraftDraftCategory = new LazyRow< CompanyCraftDraftCategory >( gameData, parser.ReadColumn< byte >( 1 ), language );
            UnkData2 = new UnkData2Obj[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                UnkData2[ i ] = new UnkData2Obj();
                UnkData2[ i ].RequiredItem = parser.ReadColumn< int >( 2 + ( i * 2 + 0 ) );
                UnkData2[ i ].RequiredItemCount = parser.ReadColumn< byte >( 2 + ( i * 2 + 1 ) );
            }
            Order = parser.ReadColumn< uint >( 8 );
        }
    }
}