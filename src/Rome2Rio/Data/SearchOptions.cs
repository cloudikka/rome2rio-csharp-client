namespace Rome2Rio.Data {

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum SearchOptions : int {
        All = 0,
        NoAirSegments = 1,
        NoAirLegs = 2,
        NoRail = 4,
        NoBus = 8,
        NoFerry = 16,
        NoCar = 32,
        NoBikeshare = 64,
        NoRideshare = 128,
        NoTowncar = 256,
        NoCommuter = 512,
        NoSpecial = 1024,
        NoMinorStart = 2048,
        NoMinorEnd = 4096,
        NoPath = 8192,
        NoPrice = 16384,
        None =
            NoAirSegments
            | NoAirLegs
            | NoRail
            | NoBus
            | NoFerry
            | NoCar
            | NoBikeshare
            | NoRideshare
            | NoTowncar
            | NoCommuter
            | NoSpecial
            | NoMinorStart
            | NoMinorEnd
            | NoPath
            | NoPrice
    }
}
