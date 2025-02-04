// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MonsterNoteTarget", columnHash: 0x4157404f )]
    public class MonsterNoteTarget : ExcelRow
    {
        public class UnkData3Obj
        {
            public ushort PlaceNameZone;
            public ushort PlaceNameLocation;
        }
        
        public LazyRow< BNpcName > BNpcName { get; set; }
        public int Icon { get; set; }
        public LazyRow< Town > Town { get; set; }
        public UnkData3Obj[] UnkData3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            BNpcName = new LazyRow< BNpcName >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Icon = parser.ReadColumn< int >( 1 );
            Town = new LazyRow< Town >( gameData, parser.ReadColumn< byte >( 2 ), language );
            UnkData3 = new UnkData3Obj[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                UnkData3[ i ] = new UnkData3Obj();
                UnkData3[ i ].PlaceNameZone = parser.ReadColumn< ushort >( 3 + ( i * 2 + 0 ) );
                UnkData3[ i ].PlaceNameLocation = parser.ReadColumn< ushort >( 3 + ( i * 2 + 1 ) );
            }
        }
    }
}