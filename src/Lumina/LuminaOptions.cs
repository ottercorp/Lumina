using Lumina.Data;
using Lumina.Excel;

namespace Lumina
{
    /// <summary>
    /// Options that can be provided to change the behaviour of caching, integrity checks and other behaviour.
    /// </summary>
    public class LuminaOptions
    {
        /// <summary>
        /// Current platform id used to load data files
        /// </summary>
        public Data.Structs.PlatformId CurrentPlatform { get; set; } = Data.Structs.PlatformId.Win32;

        /// <summary>
        /// If true, each loaded FileResource will have a weak reference maintained by Lumina so that sequential loads will return the pre-loaded file
        /// in the event it hasn't been GC'd/a reference is maintained elsewhere. This is constrained by the file type used to load, so loading the
        /// same file as a FileResource and then a TexFile will kill the old FileResource reference and replace it with a TexFile reference and miss the cache.
        /// </summary>
        public bool CacheFileResources { get; set; } = true;

        /// <summary>
        /// The default language to fetch from Excel sheets. Can be overriden on a case-by-case basis but this serves as the default.
        /// </summary>
        public Language DefaultExcelLanguage { get; set; } = Language.ChineseSimplified;

        /// <summary>
        /// Whether or not an exception should be thrown in the event that a sheet's column checksum no longer matches. This has no effect on sheets
        /// which do not define a column checksum.
        /// </summary>
        public bool PanicOnSheetChecksumMismatch { get; set; } = true;

        /// <summary>
        /// The resolver delegate to use when resolving RSV strings. Leave <see langword="null"/> if you don't need it.
        /// </summary>
        public ExcelModule.ResolveRsvDelegate? RsvResolver { get; set; }

        /// <summary>
        /// If enabled, resources will be loaded using multiple threads.
        /// </summary>
        public bool LoadMultithreaded { get; set; } = false;
    }
}