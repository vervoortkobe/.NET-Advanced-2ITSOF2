using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFLab.Migrations
{
    /// <inheritdoc />
    public partial class fakedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { -20, "Fiat" },
                    { -19, "Mini" },
                    { -18, "Aston Martin" },
                    { -17, "Honda" },
                    { -16, "Volkswagen" },
                    { -15, "Hyundai" },
                    { -14, "Jaguar" },
                    { -13, "Maserati" },
                    { -12, "Mini" },
                    { -11, "Toyota" },
                    { -10, "Tesla" },
                    { -9, "Rolls Royce" },
                    { -8, "Bugatti" },
                    { -7, "Bugatti" },
                    { -6, "Volkswagen" },
                    { -5, "Mini" },
                    { -4, "Tesla" },
                    { -3, "Tesla" },
                    { -2, "Jaguar" },
                    { -1, "Chrysler" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Fuel", "ManufacturerId", "Model", "Year" },
                values: new object[,]
                {
                    { -1000, "Diesel", -20, "Ranchero", 2012 },
                    { -999, "Hybrid", -4, "Model S", 2003 },
                    { -998, "Hybrid", -1, "Cruze", 2000 },
                    { -997, "Diesel", -19, "2", 1999 },
                    { -996, "Diesel", -8, "Spyder", 2008 },
                    { -995, "Hybrid", -12, "Model S", 2016 },
                    { -994, "Gasoline", -9, "Civic", 1994 },
                    { -993, "Hybrid", -14, "Volt", 1995 },
                    { -992, "Hybrid", -12, "2", 1997 },
                    { -991, "Hybrid", -1, "A4", 2008 },
                    { -990, "Hybrid", -1, "Fortwo", 2007 },
                    { -989, "Gasoline", -18, "Model S", 1997 },
                    { -988, "Diesel", -15, "Durango", 2012 },
                    { -987, "Hybrid", -11, "Camry", 1997 },
                    { -986, "Electric", -11, "Spyder", 1997 },
                    { -985, "Diesel", -2, "PT Cruiser", 2000 },
                    { -984, "Gasoline", -2, "Alpine", 2022 },
                    { -983, "Electric", -6, "V90", 2004 },
                    { -982, "Electric", -9, "El Camino", 2007 },
                    { -981, "Hybrid", -4, "Camaro", 2023 },
                    { -980, "Gasoline", -15, "Model S", 2003 },
                    { -979, "Gasoline", -15, "Camaro", 2009 },
                    { -978, "Electric", -14, "Focus", 2011 },
                    { -977, "Diesel", -10, "Challenger", 2009 },
                    { -976, "Gasoline", -6, "Escalade", 2020 },
                    { -975, "Diesel", -11, "Model 3", 2015 },
                    { -974, "Hybrid", -17, "Ranchero", 2015 },
                    { -973, "Gasoline", -20, "Colorado", 2021 },
                    { -972, "Gasoline", -13, "Mercielago", 2003 },
                    { -971, "Gasoline", -4, "Challenger", 2022 },
                    { -970, "Hybrid", -11, "Jetta", 2019 },
                    { -969, "Gasoline", -14, "ATS", 2019 },
                    { -968, "Hybrid", -17, "Model T", 2005 },
                    { -967, "Electric", -20, "V90", 1995 },
                    { -966, "Gasoline", -20, "Volt", 2020 },
                    { -965, "Electric", -13, "Impala", 2008 },
                    { -964, "Hybrid", -20, "Grand Cherokee", 2009 },
                    { -963, "Gasoline", -10, "Model T", 1994 },
                    { -962, "Electric", -6, "Alpine", 2015 },
                    { -961, "Electric", -15, "A4", 2018 },
                    { -960, "Electric", -13, "Challenger", 1994 },
                    { -959, "Hybrid", -5, "LeBaron", 2022 },
                    { -958, "Diesel", -10, "Model 3", 2003 },
                    { -957, "Gasoline", -12, "Taurus", 2013 },
                    { -956, "Hybrid", -6, "Corvette", 2009 },
                    { -955, "Electric", -13, "Cruze", 2007 },
                    { -954, "Hybrid", -1, "Fiesta", 2015 },
                    { -953, "Diesel", -5, "PT Cruiser", 2012 },
                    { -952, "Diesel", -20, "Expedition", 2008 },
                    { -951, "Hybrid", -19, "Malibu", 2018 },
                    { -950, "Gasoline", -17, "Camaro", 2023 },
                    { -949, "Hybrid", -3, "Colorado", 2015 },
                    { -948, "Electric", -1, "Silverado", 2022 },
                    { -947, "Electric", -8, "Fortwo", 2019 },
                    { -946, "Electric", -4, "Ranchero", 2006 },
                    { -945, "Diesel", -5, "1", 2007 },
                    { -944, "Diesel", -12, "Expedition", 2021 },
                    { -943, "Hybrid", -18, "Challenger", 2014 },
                    { -942, "Gasoline", -2, "V90", 2008 },
                    { -941, "Hybrid", -20, "Cruze", 2002 },
                    { -940, "Gasoline", -16, "Explorer", 2004 },
                    { -939, "Hybrid", -18, "Challenger", 2005 },
                    { -938, "Gasoline", -19, "2", 2003 },
                    { -937, "Hybrid", -18, "Golf", 2021 },
                    { -936, "Gasoline", -15, "Alpine", 2009 },
                    { -935, "Electric", -3, "Challenger", 2023 },
                    { -934, "Electric", -14, "Corvette", 2021 },
                    { -933, "Hybrid", -4, "Model S", 2013 },
                    { -932, "Hybrid", -2, "Land Cruiser", 2008 },
                    { -931, "Hybrid", -18, "Durango", 2002 },
                    { -930, "Gasoline", -9, "Taurus", 2008 },
                    { -929, "Diesel", -13, "Malibu", 2015 },
                    { -928, "Electric", -19, "Roadster", 1994 },
                    { -927, "Electric", -15, "Malibu", 1998 },
                    { -926, "Electric", -13, "2", 2021 },
                    { -925, "Electric", -1, "1", 2007 },
                    { -924, "Hybrid", -4, "911", 2010 },
                    { -923, "Diesel", -13, "Malibu", 1997 },
                    { -922, "Diesel", -7, "Golf", 1997 },
                    { -921, "Diesel", -2, "Focus", 2010 },
                    { -920, "Hybrid", -12, "Mustang", 2021 },
                    { -919, "Hybrid", -1, "Grand Cherokee", 2017 },
                    { -918, "Diesel", -16, "Model 3", 2013 },
                    { -917, "Electric", -10, "Durango", 2001 },
                    { -916, "Hybrid", -6, "Sentra", 2016 },
                    { -915, "Hybrid", -4, "PT Cruiser", 1999 },
                    { -914, "Electric", -5, "Taurus", 2004 },
                    { -913, "Electric", -4, "Challenger", 2016 },
                    { -912, "Hybrid", -2, "Model T", 2012 },
                    { -911, "Hybrid", -6, "Camaro", 2012 },
                    { -910, "Diesel", -4, "Charger", 2011 },
                    { -909, "Electric", -15, "Model 3", 2001 },
                    { -908, "Hybrid", -13, "Countach", 2000 },
                    { -907, "Diesel", -12, "Focus", 2000 },
                    { -906, "Gasoline", -19, "XC90", 1998 },
                    { -905, "Hybrid", -17, "F-150", 2003 },
                    { -904, "Diesel", -7, "Taurus", 2002 },
                    { -903, "Diesel", -17, "Volt", 2011 },
                    { -902, "Diesel", -14, "Expedition", 2015 },
                    { -901, "Electric", -3, "Cruze", 2018 },
                    { -900, "Gasoline", -5, "1", 2002 },
                    { -899, "Gasoline", -20, "Fortwo", 2013 },
                    { -898, "Hybrid", -12, "Taurus", 2000 },
                    { -897, "Hybrid", -16, "A8", 2012 },
                    { -896, "Diesel", -18, "Grand Caravan", 2001 },
                    { -895, "Diesel", -20, "A4", 2014 },
                    { -894, "Electric", -3, "Wrangler", 2005 },
                    { -893, "Diesel", -3, "Alpine", 2008 },
                    { -892, "Hybrid", -13, "Golf", 1997 },
                    { -891, "Diesel", -18, "Spyder", 2002 },
                    { -890, "Diesel", -3, "Countach", 2009 },
                    { -889, "Diesel", -16, "Taurus", 2004 },
                    { -888, "Electric", -2, "El Camino", 2004 },
                    { -887, "Electric", -1, "Civic", 2022 },
                    { -886, "Electric", -2, "Volt", 2000 },
                    { -885, "Hybrid", -10, "Impala", 2023 },
                    { -884, "Gasoline", -3, "Escalade", 2017 },
                    { -883, "Hybrid", -20, "Silverado", 1999 },
                    { -882, "Gasoline", -14, "Explorer", 2013 },
                    { -881, "Electric", -7, "Beetle", 2005 },
                    { -880, "Gasoline", -9, "Grand Cherokee", 2012 },
                    { -879, "Hybrid", -11, "2", 2004 },
                    { -878, "Hybrid", -15, "Alpine", 2000 },
                    { -877, "Electric", -13, "Fortwo", 2002 },
                    { -876, "Hybrid", -18, "CTS", 2014 },
                    { -875, "Gasoline", -12, "V90", 2021 },
                    { -874, "Electric", -18, "Roadster", 1996 },
                    { -873, "Diesel", -8, "Grand Cherokee", 2003 },
                    { -872, "Diesel", -19, "Prius", 1994 },
                    { -871, "Diesel", -7, "Corvette", 2005 },
                    { -870, "Hybrid", -11, "Escalade", 1998 },
                    { -869, "Diesel", -12, "CTS", 2001 },
                    { -868, "Electric", -11, "Prius", 1996 },
                    { -867, "Hybrid", -2, "Grand Cherokee", 1994 },
                    { -866, "Gasoline", -8, "Element", 2022 },
                    { -865, "Diesel", -6, "Mercielago", 1996 },
                    { -864, "Gasoline", -6, "XTS", 2019 },
                    { -863, "Electric", -20, "Impala", 1998 },
                    { -862, "Diesel", -15, "Expedition", 2016 },
                    { -861, "Diesel", -1, "Challenger", 2008 },
                    { -860, "Diesel", -1, "F-150", 2004 },
                    { -859, "Hybrid", -7, "Fiesta", 1997 },
                    { -858, "Gasoline", -19, "Model 3", 2021 },
                    { -857, "Diesel", -12, "Volt", 2011 },
                    { -856, "Diesel", -8, "Jetta", 1993 },
                    { -855, "Hybrid", -6, "CTS", 2017 },
                    { -854, "Electric", -20, "Altima", 2010 },
                    { -853, "Hybrid", -16, "XC90", 2006 },
                    { -852, "Diesel", -4, "LeBaron", 1995 },
                    { -851, "Gasoline", -15, "Altima", 2018 },
                    { -850, "Hybrid", -14, "A8", 2014 },
                    { -849, "Gasoline", -15, "LeBaron", 1996 },
                    { -848, "Gasoline", -5, "Grand Cherokee", 2011 },
                    { -847, "Hybrid", -4, "Beetle", 1995 },
                    { -846, "Gasoline", -18, "F-150", 2015 },
                    { -845, "Electric", -17, "V90", 2015 },
                    { -844, "Gasoline", -8, "Charger", 2023 },
                    { -843, "Electric", -17, "A4", 2020 },
                    { -842, "Gasoline", -7, "XC90", 2022 },
                    { -841, "Hybrid", -17, "F-150", 1999 },
                    { -840, "Electric", -20, "Grand Caravan", 2011 },
                    { -839, "Electric", -4, "Aventador", 2014 },
                    { -838, "Hybrid", -5, "Beetle", 2011 },
                    { -837, "Diesel", -15, "Focus", 2007 },
                    { -836, "Hybrid", -2, "Expedition", 2013 },
                    { -835, "Diesel", -14, "Spyder", 1998 },
                    { -834, "Gasoline", -13, "Camaro", 2015 },
                    { -833, "Gasoline", -17, "Mustang", 2012 },
                    { -832, "Hybrid", -8, "Ranchero", 2001 },
                    { -831, "Diesel", -11, "Accord", 2020 },
                    { -830, "Gasoline", -8, "PT Cruiser", 2005 },
                    { -829, "Electric", -11, "F-150", 2009 },
                    { -828, "Gasoline", -19, "Camry", 2022 },
                    { -827, "Electric", -5, "Fortwo", 2017 },
                    { -826, "Diesel", -5, "Roadster", 2006 },
                    { -825, "Hybrid", -1, "Beetle", 2010 },
                    { -824, "Diesel", -7, "V90", 2022 },
                    { -823, "Hybrid", -18, "Sentra", 2006 },
                    { -822, "Diesel", -7, "Ranchero", 1995 },
                    { -821, "Diesel", -8, "Camaro", 2011 },
                    { -820, "Hybrid", -9, "Alpine", 1998 },
                    { -819, "Diesel", -2, "Cruze", 2001 },
                    { -818, "Electric", -14, "Grand Caravan", 1998 },
                    { -817, "Hybrid", -5, "Ranchero", 2005 },
                    { -816, "Diesel", -10, "Malibu", 2007 },
                    { -815, "Gasoline", -18, "Grand Cherokee", 2013 },
                    { -814, "Gasoline", -4, "Land Cruiser", 2000 },
                    { -813, "Gasoline", -9, "Camaro", 1999 },
                    { -812, "Electric", -9, "Mercielago", 2004 },
                    { -811, "Hybrid", -16, "Sentra", 2009 },
                    { -810, "Diesel", -7, "Volt", 2018 },
                    { -809, "Electric", -18, "Fiesta", 2012 },
                    { -808, "Diesel", -9, "Expedition", 2018 },
                    { -807, "Gasoline", -18, "Fiesta", 2018 },
                    { -806, "Hybrid", -18, "Challenger", 2000 },
                    { -805, "Diesel", -7, "PT Cruiser", 2019 },
                    { -804, "Hybrid", -9, "F-150", 1997 },
                    { -803, "Gasoline", -14, "Golf", 1994 },
                    { -802, "Hybrid", -14, "Camry", 2000 },
                    { -801, "Hybrid", -16, "Countach", 2007 },
                    { -800, "Electric", -11, "XC90", 2002 },
                    { -799, "Diesel", -19, "XC90", 2019 },
                    { -798, "Gasoline", -1, "V90", 2021 },
                    { -797, "Diesel", -19, "Durango", 2002 },
                    { -796, "Diesel", -1, "Golf", 1998 },
                    { -795, "Electric", -4, "Beetle", 2010 },
                    { -794, "Gasoline", -6, "PT Cruiser", 1999 },
                    { -793, "Gasoline", -5, "Focus", 1999 },
                    { -792, "Electric", -3, "Silverado", 2005 },
                    { -791, "Hybrid", -4, "Explorer", 2000 },
                    { -790, "Electric", -10, "Cruze", 1994 },
                    { -789, "Electric", -15, "Model T", 1997 },
                    { -788, "Gasoline", -3, "Model 3", 2013 },
                    { -787, "Electric", -3, "Explorer", 2006 },
                    { -786, "Hybrid", -9, "2", 1995 },
                    { -785, "Hybrid", -12, "LeBaron", 2004 },
                    { -784, "Hybrid", -9, "Charger", 2012 },
                    { -783, "Gasoline", -14, "CX-9", 1997 },
                    { -782, "Gasoline", -3, "Roadster", 2020 },
                    { -781, "Gasoline", -8, "Durango", 2010 },
                    { -780, "Electric", -13, "Explorer", 2002 },
                    { -779, "Diesel", -12, "Mustang", 2008 },
                    { -778, "Diesel", -1, "Explorer", 1997 },
                    { -777, "Electric", -5, "Impala", 2003 },
                    { -776, "Hybrid", -6, "F-150", 2008 },
                    { -775, "Diesel", -7, "Alpine", 2019 },
                    { -774, "Hybrid", -2, "Silverado", 2009 },
                    { -773, "Gasoline", -2, "Mustang", 2008 },
                    { -772, "Gasoline", -7, "Sentra", 2004 },
                    { -771, "Diesel", -19, "Prius", 2023 },
                    { -770, "Gasoline", -10, "Altima", 2021 },
                    { -769, "Gasoline", -5, "Impala", 1999 },
                    { -768, "Gasoline", -15, "Model T", 1995 },
                    { -767, "Gasoline", -5, "CTS", 2013 },
                    { -766, "Gasoline", -6, "Camaro", 2009 },
                    { -765, "Gasoline", -15, "Challenger", 2022 },
                    { -764, "Hybrid", -6, "Beetle", 2001 },
                    { -763, "Diesel", -14, "Corvette", 1997 },
                    { -762, "Diesel", -2, "Grand Cherokee", 2007 },
                    { -761, "Hybrid", -14, "LeBaron", 1995 },
                    { -760, "Hybrid", -5, "Fiesta", 2020 },
                    { -759, "Diesel", -12, "Sentra", 2001 },
                    { -758, "Gasoline", -1, "Countach", 2009 },
                    { -757, "Diesel", -10, "V90", 2018 },
                    { -756, "Hybrid", -18, "Wrangler", 2010 },
                    { -755, "Electric", -8, "Civic", 2014 },
                    { -754, "Gasoline", -20, "El Camino", 2016 },
                    { -753, "Electric", -16, "Element", 2014 },
                    { -752, "Diesel", -18, "Land Cruiser", 2009 },
                    { -751, "Diesel", -12, "Alpine", 2016 },
                    { -750, "Electric", -8, "2", 2015 },
                    { -749, "Hybrid", -8, "Explorer", 2019 },
                    { -748, "Hybrid", -20, "Corvette", 2019 },
                    { -747, "Diesel", -6, "Silverado", 2023 },
                    { -746, "Gasoline", -17, "Fiesta", 1995 },
                    { -745, "Hybrid", -11, "Escalade", 2007 },
                    { -744, "Electric", -2, "Expedition", 2002 },
                    { -743, "Electric", -8, "Fiesta", 2021 },
                    { -742, "Hybrid", -5, "XC90", 2019 },
                    { -741, "Hybrid", -10, "Durango", 2001 },
                    { -740, "Electric", -17, "Colorado", 2022 },
                    { -739, "Electric", -7, "Fortwo", 2012 },
                    { -738, "Electric", -1, "Ranchero", 2016 },
                    { -737, "Electric", -10, "Malibu", 2006 },
                    { -736, "Electric", -20, "El Camino", 2021 },
                    { -735, "Electric", -16, "Altima", 1995 },
                    { -734, "Gasoline", -5, "Countach", 2007 },
                    { -733, "Gasoline", -10, "CX-9", 2019 },
                    { -732, "Gasoline", -3, "Camry", 2019 },
                    { -731, "Hybrid", -18, "Land Cruiser", 1995 },
                    { -730, "Diesel", -16, "XTS", 2000 },
                    { -729, "Hybrid", -10, "Fortwo", 1999 },
                    { -728, "Hybrid", -10, "Grand Cherokee", 2022 },
                    { -727, "Electric", -19, "Taurus", 2017 },
                    { -726, "Hybrid", -10, "Expedition", 1997 },
                    { -725, "Gasoline", -9, "XC90", 2002 },
                    { -724, "Diesel", -19, "Grand Cherokee", 1994 },
                    { -723, "Gasoline", -2, "Roadster", 1997 },
                    { -722, "Diesel", -16, "CX-9", 2006 },
                    { -721, "Hybrid", -9, "V90", 2019 },
                    { -720, "Gasoline", -15, "Durango", 1994 },
                    { -719, "Hybrid", -3, "Model 3", 2015 },
                    { -718, "Gasoline", -12, "Civic", 2007 },
                    { -717, "Gasoline", -12, "Mercielago", 2006 },
                    { -716, "Diesel", -8, "Accord", 2004 },
                    { -715, "Diesel", -4, "Model T", 1997 },
                    { -714, "Hybrid", -10, "2", 2003 },
                    { -713, "Electric", -7, "Countach", 2005 },
                    { -712, "Diesel", -16, "ATS", 2005 },
                    { -711, "Gasoline", -1, "Wrangler", 2007 },
                    { -710, "Gasoline", -20, "Accord", 2015 },
                    { -709, "Hybrid", -11, "Durango", 2018 },
                    { -708, "Gasoline", -19, "Durango", 2005 },
                    { -707, "Hybrid", -11, "Durango", 2023 },
                    { -706, "Gasoline", -4, "Countach", 2002 },
                    { -705, "Electric", -1, "Ranchero", 2009 },
                    { -704, "Hybrid", -16, "PT Cruiser", 2007 },
                    { -703, "Diesel", -20, "Prius", 2013 },
                    { -702, "Hybrid", -1, "Mustang", 1999 },
                    { -701, "Diesel", -14, "Challenger", 2009 },
                    { -700, "Electric", -17, "1", 1994 },
                    { -699, "Electric", -4, "Mustang", 2003 },
                    { -698, "Hybrid", -9, "Spyder", 2010 },
                    { -697, "Hybrid", -7, "PT Cruiser", 2019 },
                    { -696, "Hybrid", -5, "Spyder", 2005 },
                    { -695, "Hybrid", -6, "Ranchero", 2018 },
                    { -694, "Electric", -8, "Land Cruiser", 1997 },
                    { -693, "Hybrid", -11, "Wrangler", 2003 },
                    { -692, "Hybrid", -3, "Expedition", 1996 },
                    { -691, "Diesel", -12, "XC90", 2001 },
                    { -690, "Gasoline", -18, "Malibu", 2015 },
                    { -689, "Gasoline", -3, "Camaro", 2010 },
                    { -688, "Hybrid", -10, "911", 2005 },
                    { -687, "Gasoline", -17, "Charger", 1994 },
                    { -686, "Diesel", -4, "Challenger", 2010 },
                    { -685, "Diesel", -9, "Challenger", 2010 },
                    { -684, "Gasoline", -8, "Model 3", 2011 },
                    { -683, "Gasoline", -19, "Element", 2022 },
                    { -682, "Diesel", -3, "Corvette", 2020 },
                    { -681, "Electric", -5, "Roadster", 2022 },
                    { -680, "Diesel", -18, "A8", 2000 },
                    { -679, "Electric", -9, "Camaro", 2015 },
                    { -678, "Hybrid", -4, "Prius", 1994 },
                    { -677, "Hybrid", -10, "Golf", 2019 },
                    { -676, "Electric", -4, "Beetle", 2009 },
                    { -675, "Gasoline", -20, "Roadster", 1996 },
                    { -674, "Diesel", -3, "Durango", 2009 },
                    { -673, "Gasoline", -3, "Charger", 2011 },
                    { -672, "Hybrid", -12, "LeBaron", 2004 },
                    { -671, "Electric", -2, "Escalade", 2022 },
                    { -670, "Diesel", -6, "Durango", 2018 },
                    { -669, "Hybrid", -14, "Altima", 2006 },
                    { -668, "Gasoline", -18, "Alpine", 1997 },
                    { -667, "Gasoline", -15, "LeBaron", 2019 },
                    { -666, "Electric", -18, "Accord", 1999 },
                    { -665, "Diesel", -15, "Malibu", 2011 },
                    { -664, "Gasoline", -13, "Camaro", 2021 },
                    { -663, "Electric", -10, "Corvette", 1996 },
                    { -662, "Electric", -3, "Malibu", 2000 },
                    { -661, "Diesel", -7, "Focus", 2015 },
                    { -660, "Gasoline", -17, "ATS", 2002 },
                    { -659, "Hybrid", -14, "Focus", 2003 },
                    { -658, "Gasoline", -1, "Fiesta", 1999 },
                    { -657, "Hybrid", -7, "Wrangler", 2023 },
                    { -656, "Gasoline", -12, "Wrangler", 2020 },
                    { -655, "Diesel", -2, "Wrangler", 1994 },
                    { -654, "Hybrid", -12, "Element", 2007 },
                    { -653, "Electric", -12, "Element", 2001 },
                    { -652, "Gasoline", -6, "PT Cruiser", 2021 },
                    { -651, "Hybrid", -6, "1", 2000 },
                    { -650, "Diesel", -2, "2", 2022 },
                    { -649, "Gasoline", -16, "Alpine", 2009 },
                    { -648, "Hybrid", -14, "Volt", 2015 },
                    { -647, "Diesel", -5, "Challenger", 2010 },
                    { -646, "Hybrid", -8, "Explorer", 2016 },
                    { -645, "Gasoline", -13, "Alpine", 1995 },
                    { -644, "Diesel", -4, "Cruze", 2005 },
                    { -643, "Electric", -3, "Escalade", 2015 },
                    { -642, "Diesel", -2, "El Camino", 2004 },
                    { -641, "Diesel", -9, "Golf", 2023 },
                    { -640, "Electric", -18, "Volt", 1998 },
                    { -639, "Gasoline", -12, "Durango", 2006 },
                    { -638, "Diesel", -19, "Fiesta", 2020 },
                    { -637, "Hybrid", -17, "Wrangler", 2016 },
                    { -636, "Gasoline", -4, "Mustang", 2019 },
                    { -635, "Diesel", -14, "Charger", 2023 },
                    { -634, "Diesel", -14, "CX-9", 1999 },
                    { -633, "Diesel", -11, "PT Cruiser", 2003 },
                    { -632, "Gasoline", -11, "Model S", 2019 },
                    { -631, "Hybrid", -14, "PT Cruiser", 1994 },
                    { -630, "Hybrid", -4, "Silverado", 1998 },
                    { -629, "Hybrid", -8, "El Camino", 2020 },
                    { -628, "Electric", -20, "1", 2010 },
                    { -627, "Electric", -9, "Sentra", 2003 },
                    { -626, "Electric", -16, "Expedition", 2019 },
                    { -625, "Diesel", -8, "Accord", 2002 },
                    { -624, "Electric", -20, "LeBaron", 2011 },
                    { -623, "Electric", -15, "Grand Caravan", 2009 },
                    { -622, "Electric", -15, "Civic", 1997 },
                    { -621, "Electric", -13, "Fortwo", 2009 },
                    { -620, "Diesel", -5, "Countach", 2004 },
                    { -619, "Hybrid", -16, "Expedition", 2011 },
                    { -618, "Electric", -8, "F-150", 2002 },
                    { -617, "Diesel", -6, "1", 2006 },
                    { -616, "Electric", -5, "Expedition", 2017 },
                    { -615, "Electric", -6, "Roadster", 2011 },
                    { -614, "Diesel", -6, "Durango", 2020 },
                    { -613, "Electric", -15, "Golf", 2017 },
                    { -612, "Electric", -9, "Prius", 2014 },
                    { -611, "Hybrid", -17, "Grand Cherokee", 2000 },
                    { -610, "Gasoline", -17, "Expedition", 2015 },
                    { -609, "Diesel", -16, "Explorer", 1998 },
                    { -608, "Diesel", -1, "Prius", 1999 },
                    { -607, "Electric", -10, "Explorer", 2005 },
                    { -606, "Gasoline", -3, "XC90", 2006 },
                    { -605, "Diesel", -16, "Challenger", 2003 },
                    { -604, "Gasoline", -10, "Impala", 1996 },
                    { -603, "Electric", -7, "Expedition", 2000 },
                    { -602, "Electric", -6, "Golf", 2006 },
                    { -601, "Diesel", -14, "Jetta", 2016 },
                    { -600, "Electric", -2, "Civic", 2012 },
                    { -599, "Gasoline", -19, "Beetle", 2003 },
                    { -598, "Gasoline", -12, "911", 2008 },
                    { -597, "Hybrid", -9, "Roadster", 2000 },
                    { -596, "Electric", -18, "Expedition", 2022 },
                    { -595, "Gasoline", -15, "911", 2005 },
                    { -594, "Diesel", -2, "Cruze", 2013 },
                    { -593, "Hybrid", -20, "2", 2009 },
                    { -592, "Diesel", -15, "1", 2003 },
                    { -591, "Electric", -13, "Colorado", 1999 },
                    { -590, "Electric", -10, "Ranchero", 2021 },
                    { -589, "Electric", -17, "Mercielago", 2022 },
                    { -588, "Electric", -7, "V90", 2012 },
                    { -587, "Electric", -8, "Accord", 2017 },
                    { -586, "Diesel", -11, "Corvette", 2013 },
                    { -585, "Gasoline", -6, "Focus", 1997 },
                    { -584, "Diesel", -3, "Mustang", 2013 },
                    { -583, "Electric", -3, "Grand Cherokee", 2019 },
                    { -582, "Hybrid", -5, "Element", 2011 },
                    { -581, "Electric", -13, "Beetle", 2015 },
                    { -580, "Electric", -20, "Charger", 2016 },
                    { -579, "Electric", -18, "Grand Cherokee", 2007 },
                    { -578, "Diesel", -15, "Model 3", 2001 },
                    { -577, "Electric", -3, "Roadster", 1995 },
                    { -576, "Gasoline", -4, "Roadster", 2011 },
                    { -575, "Gasoline", -9, "Silverado", 2022 },
                    { -574, "Electric", -19, "Model S", 2003 },
                    { -573, "Electric", -14, "Taurus", 2016 },
                    { -572, "Electric", -12, "Model T", 2019 },
                    { -571, "Hybrid", -13, "Alpine", 2004 },
                    { -570, "Electric", -18, "Expedition", 2011 },
                    { -569, "Electric", -5, "Countach", 1995 },
                    { -568, "Hybrid", -19, "Model T", 2002 },
                    { -567, "Diesel", -13, "Golf", 2022 },
                    { -566, "Diesel", -8, "Malibu", 2021 },
                    { -565, "Diesel", -14, "Fiesta", 2012 },
                    { -564, "Gasoline", -15, "Corvette", 1998 },
                    { -563, "Diesel", -4, "CTS", 1996 },
                    { -562, "Diesel", -7, "LeBaron", 2007 },
                    { -561, "Gasoline", -1, "Model 3", 2017 },
                    { -560, "Gasoline", -13, "Model S", 2010 },
                    { -559, "Electric", -18, "Fiesta", 2003 },
                    { -558, "Diesel", -16, "CTS", 2003 },
                    { -557, "Hybrid", -11, "V90", 2003 },
                    { -556, "Diesel", -3, "1", 2001 },
                    { -555, "Electric", -20, "Model 3", 2000 },
                    { -554, "Diesel", -13, "LeBaron", 2004 },
                    { -553, "Diesel", -3, "Roadster", 1998 },
                    { -552, "Gasoline", -18, "Accord", 2019 },
                    { -551, "Hybrid", -5, "Alpine", 1998 },
                    { -550, "Diesel", -14, "Aventador", 2010 },
                    { -549, "Diesel", -5, "PT Cruiser", 1995 },
                    { -548, "Diesel", -3, "Accord", 1998 },
                    { -547, "Diesel", -16, "Expedition", 2021 },
                    { -546, "Electric", -19, "Explorer", 2007 },
                    { -545, "Electric", -3, "Spyder", 2002 },
                    { -544, "Diesel", -1, "Alpine", 2001 },
                    { -543, "Electric", -16, "Golf", 2007 },
                    { -542, "Diesel", -20, "Colorado", 1996 },
                    { -541, "Gasoline", -7, "Model 3", 2006 },
                    { -540, "Diesel", -12, "Alpine", 2011 },
                    { -539, "Diesel", -7, "Countach", 1995 },
                    { -538, "Gasoline", -20, "Prius", 2009 },
                    { -537, "Diesel", -5, "Ranchero", 2022 },
                    { -536, "Hybrid", -5, "Ranchero", 1995 },
                    { -535, "Gasoline", -8, "Impala", 1993 },
                    { -534, "Diesel", -15, "Silverado", 1997 },
                    { -533, "Electric", -12, "Camaro", 2005 },
                    { -532, "Electric", -13, "PT Cruiser", 2019 },
                    { -531, "Electric", -12, "XC90", 2004 },
                    { -530, "Gasoline", -5, "CTS", 1995 },
                    { -529, "Gasoline", -6, "Aventador", 2013 },
                    { -528, "Gasoline", -5, "Model S", 2009 },
                    { -527, "Electric", -9, "Model T", 2019 },
                    { -526, "Electric", -10, "Durango", 2003 },
                    { -525, "Diesel", -19, "Spyder", 2001 },
                    { -524, "Hybrid", -10, "Model S", 2013 },
                    { -523, "Electric", -11, "2", 2013 },
                    { -522, "Diesel", -5, "Beetle", 2023 },
                    { -521, "Gasoline", -3, "Model S", 2001 },
                    { -520, "Hybrid", -4, "Civic", 2008 },
                    { -519, "Diesel", -6, "Model T", 1996 },
                    { -518, "Gasoline", -16, "El Camino", 2009 },
                    { -517, "Electric", -2, "Volt", 2001 },
                    { -516, "Diesel", -7, "1", 2014 },
                    { -515, "Electric", -20, "Challenger", 2023 },
                    { -514, "Diesel", -2, "Altima", 2003 },
                    { -513, "Electric", -4, "CTS", 2021 },
                    { -512, "Gasoline", -2, "Model S", 2010 },
                    { -511, "Hybrid", -13, "Wrangler", 1999 },
                    { -510, "Electric", -12, "Ranchero", 2001 },
                    { -509, "Electric", -15, "Model T", 2017 },
                    { -508, "Diesel", -12, "Mustang", 2015 },
                    { -507, "Hybrid", -19, "Challenger", 2020 },
                    { -506, "Hybrid", -4, "Model T", 2003 },
                    { -505, "Diesel", -13, "Focus", 2000 },
                    { -504, "Hybrid", -16, "Mustang", 2010 },
                    { -503, "Gasoline", -9, "Model 3", 1998 },
                    { -502, "Diesel", -1, "Charger", 2010 },
                    { -501, "Electric", -16, "Colorado", 2014 },
                    { -500, "Gasoline", -12, "Prius", 2010 },
                    { -499, "Gasoline", -13, "2", 2012 },
                    { -498, "Hybrid", -2, "Malibu", 2004 },
                    { -497, "Gasoline", -1, "Land Cruiser", 1997 },
                    { -496, "Diesel", -18, "ATS", 2009 },
                    { -495, "Electric", -16, "Corvette", 1998 },
                    { -494, "Hybrid", -8, "Ranchero", 1995 },
                    { -493, "Hybrid", -2, "Ranchero", 2015 },
                    { -492, "Hybrid", -18, "F-150", 1997 },
                    { -491, "Diesel", -9, "CX-9", 1997 },
                    { -490, "Hybrid", -2, "Corvette", 2015 },
                    { -489, "Gasoline", -15, "Prius", 2021 },
                    { -488, "Diesel", -17, "Camaro", 2017 },
                    { -487, "Hybrid", -2, "V90", 2004 },
                    { -486, "Electric", -14, "Spyder", 2020 },
                    { -485, "Gasoline", -7, "Cruze", 2007 },
                    { -484, "Electric", -3, "A8", 2009 },
                    { -483, "Gasoline", -9, "2", 2007 },
                    { -482, "Electric", -18, "Land Cruiser", 2006 },
                    { -481, "Gasoline", -14, "CTS", 2016 },
                    { -480, "Gasoline", -20, "F-150", 2011 },
                    { -479, "Diesel", -4, "Sentra", 2010 },
                    { -478, "Hybrid", -5, "ATS", 1997 },
                    { -477, "Diesel", -9, "Impala", 1995 },
                    { -476, "Diesel", -8, "1", 2017 },
                    { -475, "Gasoline", -14, "Model 3", 2002 },
                    { -474, "Hybrid", -14, "Volt", 2010 },
                    { -473, "Electric", -17, "Model 3", 2006 },
                    { -472, "Electric", -14, "Mercielago", 2010 },
                    { -471, "Gasoline", -5, "LeBaron", 2017 },
                    { -470, "Diesel", -1, "A8", 2003 },
                    { -469, "Diesel", -13, "XTS", 2012 },
                    { -468, "Diesel", -20, "Wrangler", 2012 },
                    { -467, "Diesel", -11, "2", 1997 },
                    { -466, "Gasoline", -10, "Civic", 2019 },
                    { -465, "Electric", -12, "A4", 2006 },
                    { -464, "Hybrid", -6, "Grand Caravan", 2014 },
                    { -463, "Gasoline", -1, "Countach", 1999 },
                    { -462, "Electric", -3, "Alpine", 2010 },
                    { -461, "Gasoline", -14, "Accord", 2016 },
                    { -460, "Electric", -3, "Prius", 2016 },
                    { -459, "Hybrid", -18, "CTS", 2020 },
                    { -458, "Diesel", -1, "XC90", 2015 },
                    { -457, "Diesel", -14, "Sentra", 2002 },
                    { -456, "Diesel", -9, "Roadster", 2021 },
                    { -455, "Gasoline", -19, "2", 2002 },
                    { -454, "Hybrid", -3, "Wrangler", 2011 },
                    { -453, "Hybrid", -8, "Jetta", 2001 },
                    { -452, "Hybrid", -3, "Jetta", 2001 },
                    { -451, "Gasoline", -11, "Ranchero", 2008 },
                    { -450, "Gasoline", -15, "ATS", 2003 },
                    { -449, "Gasoline", -7, "Escalade", 1996 },
                    { -448, "Electric", -6, "1", 1999 },
                    { -447, "Hybrid", -15, "Wrangler", 2004 },
                    { -446, "Hybrid", -10, "Model 3", 2010 },
                    { -445, "Electric", -16, "Sentra", 2017 },
                    { -444, "Hybrid", -15, "Model 3", 1997 },
                    { -443, "Gasoline", -7, "Mercielago", 2006 },
                    { -442, "Gasoline", -15, "Ranchero", 2012 },
                    { -441, "Electric", -11, "Alpine", 2017 },
                    { -440, "Electric", -7, "2", 2019 },
                    { -439, "Hybrid", -1, "Grand Cherokee", 2009 },
                    { -438, "Gasoline", -19, "Colorado", 2007 },
                    { -437, "Hybrid", -1, "Accord", 1996 },
                    { -436, "Electric", -6, "Escalade", 1998 },
                    { -435, "Gasoline", -8, "XTS", 2021 },
                    { -434, "Electric", -15, "ATS", 2011 },
                    { -433, "Diesel", -7, "Impala", 2015 },
                    { -432, "Electric", -9, "Accord", 2006 },
                    { -431, "Diesel", -9, "Mustang", 2002 },
                    { -430, "Electric", -12, "911", 1997 },
                    { -429, "Electric", -15, "Charger", 2014 },
                    { -428, "Diesel", -5, "Silverado", 2009 },
                    { -427, "Gasoline", -8, "911", 2006 },
                    { -426, "Hybrid", -7, "Roadster", 2015 },
                    { -425, "Diesel", -12, "Malibu", 2002 },
                    { -424, "Electric", -9, "Durango", 2008 },
                    { -423, "Hybrid", -16, "Focus", 2013 },
                    { -422, "Hybrid", -7, "El Camino", 2012 },
                    { -421, "Hybrid", -8, "Malibu", 2003 },
                    { -420, "Electric", -11, "Land Cruiser", 2015 },
                    { -419, "Hybrid", -16, "Wrangler", 2000 },
                    { -418, "Diesel", -10, "Impala", 1997 },
                    { -417, "Diesel", -16, "ATS", 1996 },
                    { -416, "Hybrid", -16, "Camry", 2009 },
                    { -415, "Hybrid", -18, "Taurus", 1999 },
                    { -414, "Diesel", -7, "Element", 2010 },
                    { -413, "Diesel", -19, "ATS", 1995 },
                    { -412, "Diesel", -16, "Cruze", 1996 },
                    { -411, "Electric", -8, "XC90", 2012 },
                    { -410, "Electric", -9, "Golf", 2008 },
                    { -409, "Hybrid", -3, "Colorado", 2004 },
                    { -408, "Hybrid", -1, "Taurus", 2007 },
                    { -407, "Hybrid", -16, "Grand Caravan", 2018 },
                    { -406, "Hybrid", -8, "Focus", 2009 },
                    { -405, "Hybrid", -7, "Alpine", 1996 },
                    { -404, "Diesel", -14, "CTS", 1994 },
                    { -403, "Diesel", -19, "2", 1994 },
                    { -402, "Hybrid", -6, "Fortwo", 2016 },
                    { -401, "Electric", -11, "A4", 2010 },
                    { -400, "Diesel", -16, "Camry", 2016 },
                    { -399, "Diesel", -18, "Colorado", 2015 },
                    { -398, "Hybrid", -5, "XC90", 2016 },
                    { -397, "Gasoline", -4, "Mercielago", 1995 },
                    { -396, "Gasoline", -2, "Grand Caravan", 2012 },
                    { -395, "Electric", -11, "Sentra", 2021 },
                    { -394, "Electric", -7, "Sentra", 1995 },
                    { -393, "Electric", -17, "A4", 2008 },
                    { -392, "Electric", -4, "1", 2003 },
                    { -391, "Gasoline", -6, "911", 1996 },
                    { -390, "Gasoline", -11, "Grand Cherokee", 2021 },
                    { -389, "Electric", -7, "Camry", 2016 },
                    { -388, "Gasoline", -20, "Camaro", 2012 },
                    { -387, "Gasoline", -19, "2", 1999 },
                    { -386, "Gasoline", -2, "Focus", 1994 },
                    { -385, "Diesel", -17, "Grand Caravan", 2005 },
                    { -384, "Electric", -1, "Land Cruiser", 2000 },
                    { -383, "Hybrid", -1, "Prius", 2003 },
                    { -382, "Electric", -15, "Mustang", 2000 },
                    { -381, "Gasoline", -6, "Jetta", 2003 },
                    { -380, "Diesel", -8, "2", 2007 },
                    { -379, "Hybrid", -3, "Accord", 2014 },
                    { -378, "Electric", -20, "Roadster", 1993 },
                    { -377, "Gasoline", -3, "LeBaron", 2015 },
                    { -376, "Hybrid", -9, "Mercielago", 2016 },
                    { -375, "Diesel", -12, "Golf", 2015 },
                    { -374, "Electric", -14, "Camaro", 1994 },
                    { -373, "Gasoline", -5, "Fortwo", 2019 },
                    { -372, "Electric", -10, "Escalade", 2002 },
                    { -371, "Gasoline", -14, "PT Cruiser", 2010 },
                    { -370, "Hybrid", -11, "Beetle", 2020 },
                    { -369, "Hybrid", -17, "Impala", 1999 },
                    { -368, "Hybrid", -6, "F-150", 1993 },
                    { -367, "Gasoline", -9, "Colorado", 2021 },
                    { -366, "Hybrid", -9, "Civic", 2010 },
                    { -365, "Gasoline", -16, "Camaro", 2008 },
                    { -364, "Hybrid", -3, "Escalade", 2012 },
                    { -363, "Electric", -9, "Focus", 2009 },
                    { -362, "Diesel", -6, "Escalade", 1994 },
                    { -361, "Diesel", -13, "CX-9", 2015 },
                    { -360, "Hybrid", -5, "Fortwo", 2005 },
                    { -359, "Gasoline", -3, "Escalade", 1997 },
                    { -358, "Diesel", -19, "Prius", 2020 },
                    { -357, "Gasoline", -3, "Fiesta", 2001 },
                    { -356, "Diesel", -3, "Silverado", 2014 },
                    { -355, "Electric", -6, "F-150", 1996 },
                    { -354, "Electric", -19, "PT Cruiser", 2007 },
                    { -353, "Hybrid", -6, "Escalade", 1998 },
                    { -352, "Gasoline", -6, "Grand Caravan", 1995 },
                    { -351, "Electric", -9, "Prius", 1994 },
                    { -350, "Hybrid", -19, "Jetta", 2021 },
                    { -349, "Hybrid", -19, "Explorer", 2022 },
                    { -348, "Hybrid", -20, "Colorado", 2020 },
                    { -347, "Hybrid", -15, "2", 2023 },
                    { -346, "Diesel", -7, "Challenger", 2012 },
                    { -345, "Gasoline", -6, "Model S", 2019 },
                    { -344, "Electric", -17, "XTS", 1997 },
                    { -343, "Hybrid", -12, "XTS", 2001 },
                    { -342, "Gasoline", -20, "ATS", 2000 },
                    { -341, "Diesel", -10, "Mustang", 2016 },
                    { -340, "Hybrid", -19, "Cruze", 2017 },
                    { -339, "Electric", -4, "Grand Caravan", 2010 },
                    { -338, "Hybrid", -17, "Colorado", 2010 },
                    { -337, "Electric", -13, "Beetle", 2013 },
                    { -336, "Gasoline", -9, "911", 2016 },
                    { -335, "Diesel", -17, "Spyder", 2020 },
                    { -334, "Gasoline", -20, "CX-9", 2002 },
                    { -333, "Hybrid", -14, "Spyder", 2008 },
                    { -332, "Hybrid", -18, "V90", 1996 },
                    { -331, "Electric", -6, "Aventador", 1996 },
                    { -330, "Gasoline", -16, "XC90", 2001 },
                    { -329, "Diesel", -3, "XTS", 2003 },
                    { -328, "Diesel", -18, "F-150", 2012 },
                    { -327, "Electric", -11, "Prius", 2009 },
                    { -326, "Diesel", -10, "Mercielago", 2000 },
                    { -325, "Gasoline", -5, "Alpine", 2015 },
                    { -324, "Electric", -6, "Aventador", 2020 },
                    { -323, "Gasoline", -6, "Malibu", 2004 },
                    { -322, "Electric", -15, "PT Cruiser", 2023 },
                    { -321, "Hybrid", -10, "Jetta", 2014 },
                    { -320, "Electric", -7, "Spyder", 2018 },
                    { -319, "Electric", -16, "XC90", 2011 },
                    { -318, "Hybrid", -2, "Fortwo", 2006 },
                    { -317, "Diesel", -1, "Durango", 1995 },
                    { -316, "Hybrid", -5, "Charger", 1995 },
                    { -315, "Hybrid", -15, "Altima", 2023 },
                    { -314, "Gasoline", -8, "Jetta", 1999 },
                    { -313, "Diesel", -12, "Land Cruiser", 2012 },
                    { -312, "Electric", -2, "1", 2000 },
                    { -311, "Diesel", -2, "Cruze", 2023 },
                    { -310, "Diesel", -18, "Wrangler", 2008 },
                    { -309, "Gasoline", -11, "XC90", 2021 },
                    { -308, "Electric", -5, "Wrangler", 2019 },
                    { -307, "Hybrid", -2, "Escalade", 2018 },
                    { -306, "Gasoline", -11, "Wrangler", 2018 },
                    { -305, "Gasoline", -17, "Corvette", 1995 },
                    { -304, "Electric", -14, "Cruze", 2010 },
                    { -303, "Electric", -6, "Mustang", 2012 },
                    { -302, "Electric", -4, "Aventador", 2021 },
                    { -301, "Hybrid", -5, "Alpine", 2020 },
                    { -300, "Diesel", -7, "LeBaron", 2021 },
                    { -299, "Gasoline", -7, "Escalade", 2023 },
                    { -298, "Hybrid", -17, "Impala", 2006 },
                    { -297, "Diesel", -20, "Colorado", 2005 },
                    { -296, "Gasoline", -13, "Element", 2015 },
                    { -295, "Electric", -5, "Camry", 1998 },
                    { -294, "Diesel", -19, "Alpine", 1995 },
                    { -293, "Hybrid", -10, "ATS", 2004 },
                    { -292, "Electric", -18, "Ranchero", 2015 },
                    { -291, "Gasoline", -2, "Camry", 2010 },
                    { -290, "Gasoline", -7, "Golf", 2011 },
                    { -289, "Hybrid", -4, "1", 1995 },
                    { -288, "Hybrid", -10, "Alpine", 1998 },
                    { -287, "Hybrid", -15, "Beetle", 2001 },
                    { -286, "Hybrid", -7, "Sentra", 2008 },
                    { -285, "Gasoline", -3, "Roadster", 2020 },
                    { -284, "Hybrid", -5, "1", 2001 },
                    { -283, "Electric", -20, "Beetle", 2018 },
                    { -282, "Hybrid", -18, "F-150", 2012 },
                    { -281, "Diesel", -8, "Civic", 2002 },
                    { -280, "Hybrid", -15, "Focus", 2002 },
                    { -279, "Electric", -16, "Civic", 2006 },
                    { -278, "Electric", -20, "Altima", 1995 },
                    { -277, "Hybrid", -4, "Alpine", 2014 },
                    { -276, "Hybrid", -5, "Model 3", 2015 },
                    { -275, "Hybrid", -15, "Jetta", 1995 },
                    { -274, "Electric", -15, "El Camino", 2013 },
                    { -273, "Hybrid", -15, "V90", 2009 },
                    { -272, "Gasoline", -1, "Fiesta", 2006 },
                    { -271, "Hybrid", -13, "V90", 2013 },
                    { -270, "Diesel", -14, "Corvette", 2005 },
                    { -269, "Hybrid", -20, "PT Cruiser", 2008 },
                    { -268, "Electric", -10, "Spyder", 2011 },
                    { -267, "Hybrid", -7, "Durango", 2019 },
                    { -266, "Electric", -13, "El Camino", 2016 },
                    { -265, "Hybrid", -3, "Altima", 2005 },
                    { -264, "Gasoline", -19, "El Camino", 2018 },
                    { -263, "Hybrid", -5, "Fortwo", 1995 },
                    { -262, "Electric", -10, "Mustang", 2020 },
                    { -261, "Electric", -16, "Roadster", 2009 },
                    { -260, "Electric", -16, "Aventador", 2011 },
                    { -259, "Gasoline", -14, "Grand Caravan", 1994 },
                    { -258, "Diesel", -20, "Challenger", 2000 },
                    { -257, "Gasoline", -18, "Fortwo", 2018 },
                    { -256, "Electric", -12, "ATS", 2011 },
                    { -255, "Diesel", -17, "LeBaron", 1994 },
                    { -254, "Electric", -13, "Spyder", 1994 },
                    { -253, "Hybrid", -1, "Grand Caravan", 2023 },
                    { -252, "Gasoline", -16, "911", 1999 },
                    { -251, "Diesel", -18, "Challenger", 2006 },
                    { -250, "Hybrid", -13, "Golf", 1996 },
                    { -249, "Electric", -11, "Cruze", 2019 },
                    { -248, "Diesel", -10, "Camaro", 1999 },
                    { -247, "Diesel", -2, "Spyder", 2015 },
                    { -246, "Gasoline", -18, "V90", 2002 },
                    { -245, "Diesel", -2, "Countach", 2021 },
                    { -244, "Diesel", -17, "Escalade", 1995 },
                    { -243, "Gasoline", -17, "Focus", 1998 },
                    { -242, "Gasoline", -11, "Model T", 2013 },
                    { -241, "Hybrid", -14, "Challenger", 2014 },
                    { -240, "Gasoline", -20, "911", 2012 },
                    { -239, "Hybrid", -11, "Silverado", 2001 },
                    { -238, "Hybrid", -7, "XTS", 2011 },
                    { -237, "Diesel", -4, "Camaro", 2020 },
                    { -236, "Electric", -19, "Sentra", 2008 },
                    { -235, "Gasoline", -1, "Durango", 2015 },
                    { -234, "Electric", -9, "Golf", 2000 },
                    { -233, "Diesel", -15, "Fiesta", 2005 },
                    { -232, "Gasoline", -19, "Corvette", 2003 },
                    { -231, "Gasoline", -12, "Element", 1997 },
                    { -230, "Diesel", -13, "911", 1998 },
                    { -229, "Hybrid", -12, "Mustang", 2013 },
                    { -228, "Electric", -8, "Explorer", 2014 },
                    { -227, "Diesel", -6, "Colorado", 2004 },
                    { -226, "Electric", -18, "Spyder", 2011 },
                    { -225, "Gasoline", -6, "Wrangler", 2006 },
                    { -224, "Gasoline", -3, "Civic", 1996 },
                    { -223, "Electric", -15, "Model 3", 2016 },
                    { -222, "Electric", -1, "Civic", 2010 },
                    { -221, "Hybrid", -7, "Mustang", 2010 },
                    { -220, "Electric", -18, "2", 1996 },
                    { -219, "Gasoline", -20, "A8", 1997 },
                    { -218, "Diesel", -8, "Alpine", 2014 },
                    { -217, "Hybrid", -16, "Prius", 2012 },
                    { -216, "Gasoline", -10, "Countach", 2020 },
                    { -215, "Gasoline", -3, "Colorado", 2018 },
                    { -214, "Gasoline", -17, "Alpine", 2010 },
                    { -213, "Diesel", -7, "LeBaron", 2020 },
                    { -212, "Gasoline", -12, "F-150", 2015 },
                    { -211, "Electric", -9, "Model 3", 2010 },
                    { -210, "Electric", -13, "Colorado", 2015 },
                    { -209, "Gasoline", -16, "Camaro", 2009 },
                    { -208, "Hybrid", -3, "Mercielago", 2010 },
                    { -207, "Diesel", -6, "Spyder", 2022 },
                    { -206, "Hybrid", -17, "CX-9", 2000 },
                    { -205, "Gasoline", -13, "Durango", 2003 },
                    { -204, "Diesel", -9, "Durango", 2015 },
                    { -203, "Hybrid", -5, "Malibu", 1996 },
                    { -202, "Diesel", -1, "Mercielago", 1999 },
                    { -201, "Diesel", -2, "Colorado", 2019 },
                    { -200, "Diesel", -20, "CTS", 2019 },
                    { -199, "Hybrid", -9, "2", 2018 },
                    { -198, "Diesel", -10, "Grand Caravan", 2017 },
                    { -197, "Electric", -3, "Fiesta", 2008 },
                    { -196, "Hybrid", -12, "Accord", 1996 },
                    { -195, "Gasoline", -3, "El Camino", 2006 },
                    { -194, "Hybrid", -4, "Altima", 2008 },
                    { -193, "Diesel", -19, "Silverado", 2005 },
                    { -192, "Hybrid", -20, "XTS", 2001 },
                    { -191, "Hybrid", -9, "Civic", 2013 },
                    { -190, "Hybrid", -14, "Model 3", 2000 },
                    { -189, "Diesel", -8, "Prius", 1994 },
                    { -188, "Diesel", -14, "1", 1999 },
                    { -187, "Hybrid", -14, "Cruze", 2017 },
                    { -186, "Diesel", -12, "Ranchero", 2001 },
                    { -185, "Gasoline", -2, "F-150", 2004 },
                    { -184, "Hybrid", -16, "Countach", 1993 },
                    { -183, "Gasoline", -6, "911", 2002 },
                    { -182, "Hybrid", -13, "CTS", 2009 },
                    { -181, "Gasoline", -8, "Escalade", 2006 },
                    { -180, "Diesel", -2, "A4", 1999 },
                    { -179, "Electric", -7, "Fortwo", 2019 },
                    { -178, "Diesel", -14, "Challenger", 2011 },
                    { -177, "Hybrid", -2, "Wrangler", 2009 },
                    { -176, "Hybrid", -7, "Ranchero", 2005 },
                    { -175, "Electric", -2, "Grand Cherokee", 2018 },
                    { -174, "Gasoline", -15, "Accord", 2002 },
                    { -173, "Diesel", -11, "Altima", 1996 },
                    { -172, "Hybrid", -10, "Jetta", 1999 },
                    { -171, "Hybrid", -3, "XC90", 2012 },
                    { -170, "Electric", -14, "XC90", 2006 },
                    { -169, "Gasoline", -6, "Golf", 2014 },
                    { -168, "Gasoline", -11, "Focus", 1995 },
                    { -167, "Diesel", -4, "Sentra", 2016 },
                    { -166, "Gasoline", -17, "Altima", 2004 },
                    { -165, "Hybrid", -18, "Escalade", 2007 },
                    { -164, "Diesel", -10, "Volt", 1999 },
                    { -163, "Diesel", -6, "Fiesta", 2019 },
                    { -162, "Electric", -5, "CX-9", 2006 },
                    { -161, "Electric", -13, "Model T", 1996 },
                    { -160, "Electric", -3, "Altima", 2015 },
                    { -159, "Electric", -10, "CX-9", 2016 },
                    { -158, "Diesel", -14, "2", 2012 },
                    { -157, "Hybrid", -16, "Taurus", 1998 },
                    { -156, "Hybrid", -5, "Camaro", 2017 },
                    { -155, "Electric", -13, "Challenger", 2017 },
                    { -154, "Electric", -18, "Model S", 1996 },
                    { -153, "Electric", -4, "Model T", 2011 },
                    { -152, "Diesel", -5, "Roadster", 2014 },
                    { -151, "Diesel", -8, "Aventador", 2021 },
                    { -150, "Gasoline", -2, "CTS", 2003 },
                    { -149, "Diesel", -18, "Challenger", 1999 },
                    { -148, "Electric", -9, "Ranchero", 1998 },
                    { -147, "Diesel", -6, "Camaro", 2021 },
                    { -146, "Electric", -1, "Fortwo", 2018 },
                    { -145, "Hybrid", -1, "XC90", 1994 },
                    { -144, "Gasoline", -5, "Accord", 2010 },
                    { -143, "Diesel", -17, "Challenger", 1995 },
                    { -142, "Hybrid", -8, "Challenger", 2014 },
                    { -141, "Diesel", -14, "Ranchero", 2012 },
                    { -140, "Hybrid", -5, "Charger", 2023 },
                    { -139, "Diesel", -5, "Grand Caravan", 2021 },
                    { -138, "Hybrid", -14, "Charger", 1997 },
                    { -137, "Gasoline", -15, "Camry", 2001 },
                    { -136, "Electric", -4, "Beetle", 2018 },
                    { -135, "Hybrid", -9, "Focus", 2018 },
                    { -134, "Gasoline", -14, "Grand Cherokee", 2002 },
                    { -133, "Diesel", -19, "2", 2003 },
                    { -132, "Gasoline", -17, "Grand Cherokee", 2007 },
                    { -131, "Diesel", -15, "Sentra", 2008 },
                    { -130, "Gasoline", -12, "Mercielago", 2008 },
                    { -129, "Hybrid", -14, "Expedition", 2005 },
                    { -128, "Gasoline", -5, "XTS", 2017 },
                    { -127, "Electric", -1, "Escalade", 2007 },
                    { -126, "Electric", -2, "XC90", 2023 },
                    { -125, "Gasoline", -1, "Mustang", 2006 },
                    { -124, "Gasoline", -14, "911", 2010 },
                    { -123, "Electric", -18, "Cruze", 1997 },
                    { -122, "Electric", -15, "El Camino", 2006 },
                    { -121, "Electric", -18, "Countach", 1997 },
                    { -120, "Electric", -11, "Prius", 2021 },
                    { -119, "Hybrid", -14, "Model T", 2022 },
                    { -118, "Electric", -1, "Wrangler", 1998 },
                    { -117, "Gasoline", -12, "Explorer", 2020 },
                    { -116, "Hybrid", -10, "Wrangler", 2017 },
                    { -115, "Electric", -9, "1", 2006 },
                    { -114, "Electric", -1, "Impala", 2014 },
                    { -113, "Electric", -16, "V90", 2012 },
                    { -112, "Electric", -12, "A8", 2021 },
                    { -111, "Electric", -18, "Camaro", 2001 },
                    { -110, "Hybrid", -8, "V90", 1999 },
                    { -109, "Gasoline", -12, "Impala", 2013 },
                    { -108, "Diesel", -17, "Alpine", 2006 },
                    { -107, "Hybrid", -11, "Jetta", 2007 },
                    { -106, "Electric", -16, "Fiesta", 2018 },
                    { -105, "Electric", -15, "PT Cruiser", 2021 },
                    { -104, "Gasoline", -11, "1", 1999 },
                    { -103, "Gasoline", -16, "Sentra", 2002 },
                    { -102, "Hybrid", -14, "Spyder", 2006 },
                    { -101, "Diesel", -15, "Impala", 2007 },
                    { -100, "Diesel", -11, "Jetta", 2006 },
                    { -99, "Diesel", -19, "Element", 2019 },
                    { -98, "Gasoline", -1, "Wrangler", 2020 },
                    { -97, "Hybrid", -10, "Mustang", 2022 },
                    { -96, "Electric", -4, "Accord", 2000 },
                    { -95, "Diesel", -15, "911", 2014 },
                    { -94, "Diesel", -4, "Volt", 1998 },
                    { -93, "Electric", -18, "Camaro", 2009 },
                    { -92, "Hybrid", -1, "Corvette", 2023 },
                    { -91, "Hybrid", -1, "ATS", 2008 },
                    { -90, "Electric", -16, "Prius", 1995 },
                    { -89, "Gasoline", -13, "Golf", 1997 },
                    { -88, "Gasoline", -2, "ATS", 1994 },
                    { -87, "Gasoline", -7, "Ranchero", 2019 },
                    { -86, "Gasoline", -3, "F-150", 2019 },
                    { -85, "Electric", -9, "Malibu", 2004 },
                    { -84, "Hybrid", -5, "Escalade", 2003 },
                    { -83, "Electric", -8, "Element", 2018 },
                    { -82, "Hybrid", -4, "Element", 2008 },
                    { -81, "Hybrid", -19, "PT Cruiser", 2013 },
                    { -80, "Hybrid", -1, "Wrangler", 2017 },
                    { -79, "Diesel", -16, "Spyder", 2003 },
                    { -78, "Hybrid", -20, "Grand Caravan", 2010 },
                    { -77, "Gasoline", -3, "Aventador", 2022 },
                    { -76, "Electric", -9, "Countach", 2017 },
                    { -75, "Gasoline", -2, "Alpine", 2010 },
                    { -74, "Gasoline", -15, "Focus", 2021 },
                    { -73, "Diesel", -14, "CX-9", 2009 },
                    { -72, "Diesel", -18, "Challenger", 1994 },
                    { -71, "Gasoline", -5, "Grand Caravan", 1994 },
                    { -70, "Diesel", -10, "Jetta", 2020 },
                    { -69, "Gasoline", -17, "Cruze", 2016 },
                    { -68, "Hybrid", -11, "Explorer", 2022 },
                    { -67, "Gasoline", -5, "Charger", 1996 },
                    { -66, "Gasoline", -6, "Cruze", 2015 },
                    { -65, "Gasoline", -7, "Altima", 2010 },
                    { -64, "Diesel", -5, "A8", 2012 },
                    { -63, "Electric", -5, "Beetle", 2019 },
                    { -62, "Hybrid", -17, "V90", 1995 },
                    { -61, "Diesel", -12, "A4", 2016 },
                    { -60, "Electric", -1, "Fiesta", 2010 },
                    { -59, "Gasoline", -7, "LeBaron", 2006 },
                    { -58, "Electric", -18, "Element", 2020 },
                    { -57, "Diesel", -6, "911", 2004 },
                    { -56, "Diesel", -9, "Escalade", 1998 },
                    { -55, "Hybrid", -6, "PT Cruiser", 2000 },
                    { -54, "Diesel", -9, "Golf", 2016 },
                    { -53, "Hybrid", -10, "Model 3", 2016 },
                    { -52, "Gasoline", -17, "Silverado", 1996 },
                    { -51, "Gasoline", -8, "Durango", 1997 },
                    { -50, "Gasoline", -19, "Fiesta", 2006 },
                    { -49, "Diesel", -1, "Impala", 1999 },
                    { -48, "Diesel", -15, "Aventador", 2008 },
                    { -47, "Electric", -18, "Taurus", 2001 },
                    { -46, "Hybrid", -13, "Escalade", 2014 },
                    { -45, "Diesel", -17, "LeBaron", 2006 },
                    { -44, "Hybrid", -16, "Malibu", 2003 },
                    { -43, "Gasoline", -1, "LeBaron", 1997 },
                    { -42, "Gasoline", -15, "Prius", 2005 },
                    { -41, "Hybrid", -5, "Sentra", 1996 },
                    { -40, "Hybrid", -2, "XC90", 2016 },
                    { -39, "Diesel", -10, "Civic", 2011 },
                    { -38, "Gasoline", -10, "Accord", 2018 },
                    { -37, "Diesel", -11, "911", 2018 },
                    { -36, "Hybrid", -10, "Wrangler", 2009 },
                    { -35, "Diesel", -14, "CTS", 1998 },
                    { -34, "Electric", -5, "Countach", 2019 },
                    { -33, "Electric", -2, "Fiesta", 2021 },
                    { -32, "Diesel", -16, "Model 3", 2021 },
                    { -31, "Diesel", -1, "A8", 2012 },
                    { -30, "Electric", -12, "Jetta", 2001 },
                    { -29, "Hybrid", -5, "Fortwo", 2008 },
                    { -28, "Diesel", -10, "Volt", 2010 },
                    { -27, "Gasoline", -16, "A8", 2001 },
                    { -26, "Gasoline", -18, "2", 2011 },
                    { -25, "Gasoline", -7, "Explorer", 2017 },
                    { -24, "Gasoline", -20, "Explorer", 2007 },
                    { -23, "Gasoline", -4, "2", 2016 },
                    { -22, "Gasoline", -8, "Sentra", 2018 },
                    { -21, "Electric", -11, "Camaro", 2005 },
                    { -20, "Electric", -16, "XTS", 2010 },
                    { -19, "Electric", -7, "Roadster", 2011 },
                    { -18, "Gasoline", -11, "Beetle", 2019 },
                    { -17, "Hybrid", -3, "Element", 2009 },
                    { -16, "Gasoline", -13, "ATS", 2004 },
                    { -15, "Electric", -20, "Colorado", 2003 },
                    { -14, "Gasoline", -10, "Ranchero", 2012 },
                    { -13, "Diesel", -1, "Corvette", 1999 },
                    { -12, "Hybrid", -19, "Durango", 2017 },
                    { -11, "Electric", -19, "V90", 2013 },
                    { -10, "Electric", -16, "A4", 2018 },
                    { -9, "Gasoline", -17, "A8", 2002 },
                    { -8, "Hybrid", -18, "Beetle", 2023 },
                    { -7, "Diesel", -9, "Camaro", 2000 },
                    { -6, "Electric", -11, "Model S", 2006 },
                    { -5, "Diesel", -3, "Model T", 2019 },
                    { -4, "Diesel", -5, "Spyder", 2021 },
                    { -3, "Diesel", -4, "Model T", 2002 },
                    { -2, "Gasoline", -13, "Element", 2016 },
                    { -1, "Hybrid", -12, "Fortwo", 2023 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -1000);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -999);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -998);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -997);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -996);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -995);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -994);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -993);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -992);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -991);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -990);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -989);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -988);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -987);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -986);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -985);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -984);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -983);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -982);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -981);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -980);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -979);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -978);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -977);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -976);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -975);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -974);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -973);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -972);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -971);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -970);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -969);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -968);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -967);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -966);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -965);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -964);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -963);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -962);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -961);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -960);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -959);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -958);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -957);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -956);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -955);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -954);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -953);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -952);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -951);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -950);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -949);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -948);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -947);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -946);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -945);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -944);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -943);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -942);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -941);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -940);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -939);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -938);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -937);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -936);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -935);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -934);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -933);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -932);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -931);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -930);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -929);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -928);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -927);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -926);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -925);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -924);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -923);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -922);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -921);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -920);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -919);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -918);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -917);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -916);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -915);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -914);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -913);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -912);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -911);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -910);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -909);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -908);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -907);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -906);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -905);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -904);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -903);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -902);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -901);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -900);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -899);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -898);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -897);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -896);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -895);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -894);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -893);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -892);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -891);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -890);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -889);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -888);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -887);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -886);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -885);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -884);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -883);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -882);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -881);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -880);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -879);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -878);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -877);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -876);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -875);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -874);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -873);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -872);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -871);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -870);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -869);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -868);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -867);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -866);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -865);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -864);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -863);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -862);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -861);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -860);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -859);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -858);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -857);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -856);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -855);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -854);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -853);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -852);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -851);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -850);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -849);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -848);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -847);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -846);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -845);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -844);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -843);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -842);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -841);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -840);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -839);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -838);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -837);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -836);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -835);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -834);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -833);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -832);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -831);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -830);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -829);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -828);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -827);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -826);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -825);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -824);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -823);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -822);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -821);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -820);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -819);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -818);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -817);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -816);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -815);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -814);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -813);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -812);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -811);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -810);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -809);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -808);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -807);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -806);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -805);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -804);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -803);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -802);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -801);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -800);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -799);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -798);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -797);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -796);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -795);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -794);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -793);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -792);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -791);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -790);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -789);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -788);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -787);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -786);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -785);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -784);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -783);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -782);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -781);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -780);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -779);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -778);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -777);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -776);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -775);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -774);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -773);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -772);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -771);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -770);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -769);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -768);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -767);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -766);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -765);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -764);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -763);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -762);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -761);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -760);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -759);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -758);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -757);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -756);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -755);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -754);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -753);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -752);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -751);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -750);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -749);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -748);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -747);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -746);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -745);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -744);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -743);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -742);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -741);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -740);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -739);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -738);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -737);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -736);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -735);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -734);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -733);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -732);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -731);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -730);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -729);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -728);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -727);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -726);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -725);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -724);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -723);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -722);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -721);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -720);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -719);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -718);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -717);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -716);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -715);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -714);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -713);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -712);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -711);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -710);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -709);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -708);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -707);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -706);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -705);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -704);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -703);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -702);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -701);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -700);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -699);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -698);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -697);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -696);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -695);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -694);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -693);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -692);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -691);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -690);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -689);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -688);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -687);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -686);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -685);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -684);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -683);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -682);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -681);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -680);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -679);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -678);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -677);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -676);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -675);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -674);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -673);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -672);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -671);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -670);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -669);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -668);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -667);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -666);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -665);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -664);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -663);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -662);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -661);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -660);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -659);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -658);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -657);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -656);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -655);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -654);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -653);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -652);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -651);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -650);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -649);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -648);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -647);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -646);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -645);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -644);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -643);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -642);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -641);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -640);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -639);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -638);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -637);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -636);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -635);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -634);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -633);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -632);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -631);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -630);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -629);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -628);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -627);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -626);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -625);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -624);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -623);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -622);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -621);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -620);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -619);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -618);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -617);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -616);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -615);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -614);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -613);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -612);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -611);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -610);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -609);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -608);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -607);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -606);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -605);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -604);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -603);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -602);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -601);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -600);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -599);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -598);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -597);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -596);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -595);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -594);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -593);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -592);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -591);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -590);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -589);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -588);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -587);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -586);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -585);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -584);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -583);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -582);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -581);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -580);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -579);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -578);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -577);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -576);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -575);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -574);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -573);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -572);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -571);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -570);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -569);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -568);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -567);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -566);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -565);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -564);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -563);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -562);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -561);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -560);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -559);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -558);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -557);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -556);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -555);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -554);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -553);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -552);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -551);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -550);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -549);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -548);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -547);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -546);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -545);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -544);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -543);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -542);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -541);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -540);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -539);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -538);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -537);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -536);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -535);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -534);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -533);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -532);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -531);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -530);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -529);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -528);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -527);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -526);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -525);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -524);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -523);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -522);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -521);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -520);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -519);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -518);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -517);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -516);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -515);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -514);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -513);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -512);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -511);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -510);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -509);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -508);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -507);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -506);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -505);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -504);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -503);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -502);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -501);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -500);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -499);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -498);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -497);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -496);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -495);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -494);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -493);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -492);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -491);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -490);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -489);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -488);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -487);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -486);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -485);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -484);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -483);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -482);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -481);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -480);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -479);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -478);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -477);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -476);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -475);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -474);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -473);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -472);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -471);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -470);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -469);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -468);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -467);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -466);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -465);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -464);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -463);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -462);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -461);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -460);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -459);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -458);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -457);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -456);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -455);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -454);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -453);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -452);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -451);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -450);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -449);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -448);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -447);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -446);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -445);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -444);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -443);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -442);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -441);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -440);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -439);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -438);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -437);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -436);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -435);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -434);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -433);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -432);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -431);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -430);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -429);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -428);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -427);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -426);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -425);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -424);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -423);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -422);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -421);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -420);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -419);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -418);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -417);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -416);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -415);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -414);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -413);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -412);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -411);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -410);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -409);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -408);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -407);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -406);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -405);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -404);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -403);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -402);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -401);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -400);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -399);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -398);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -397);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -396);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -395);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -394);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -393);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -392);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -391);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -390);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -389);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -388);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -387);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -386);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -385);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -384);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -383);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -382);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -381);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -380);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -379);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -378);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -377);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -376);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -375);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -374);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -373);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -372);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -371);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -370);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -369);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -368);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -367);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -366);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -365);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -364);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -363);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -362);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -361);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -360);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -359);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -358);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -357);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -356);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -355);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -354);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -353);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -352);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -351);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -350);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -349);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -348);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -347);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -346);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -345);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -344);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -343);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -342);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -341);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -340);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -339);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -338);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -337);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -336);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -335);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -334);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -333);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -332);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -331);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -330);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -329);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -328);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -327);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -326);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -325);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -324);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -323);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -322);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -321);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -320);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -319);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -318);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -317);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -316);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -315);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -314);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -313);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -312);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -311);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -310);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -309);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -308);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -307);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -306);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -305);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -304);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -303);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -302);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -301);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -300);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -299);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -298);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -297);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -296);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -295);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -294);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -293);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -292);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -291);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -290);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -289);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -288);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -287);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -286);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -285);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -284);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -283);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -282);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -281);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -280);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -279);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -278);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -277);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -276);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -275);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -274);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -273);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -272);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -271);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -270);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -269);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -268);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -267);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -266);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -265);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -264);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -263);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -262);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -261);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -260);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -259);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -258);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -257);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -256);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -255);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -254);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -253);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -252);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -251);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -250);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -249);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -248);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -247);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -246);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -245);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -244);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -243);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -242);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -241);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -240);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -239);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -238);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -237);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -236);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -235);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -234);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -233);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -232);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -231);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -230);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -229);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -228);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -227);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -226);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -225);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -224);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -223);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -222);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -221);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -220);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -219);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -218);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -217);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -216);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -215);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -214);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -213);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -212);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -211);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -210);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -209);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -208);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -207);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -206);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -205);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -204);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -203);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -202);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -201);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -200);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -199);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -198);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -197);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -196);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -195);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -194);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -193);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -192);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -191);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -190);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -189);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -188);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -187);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -186);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -185);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -184);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -183);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -182);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -181);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -180);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -179);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -178);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -177);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -176);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -175);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -174);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -173);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -172);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -171);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -170);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -169);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -168);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -167);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -166);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -165);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -164);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -163);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -162);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -161);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -160);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -159);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -158);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -157);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -156);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -155);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -154);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -153);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -152);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -151);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -150);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -149);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -148);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -147);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -146);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -145);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -144);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -143);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -142);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -141);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -140);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -139);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -138);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -137);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -136);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -135);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -134);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -133);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -132);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -131);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -130);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -129);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -128);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -127);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -126);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -125);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -124);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -123);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -122);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -121);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -120);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -119);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -118);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -117);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -116);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -115);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -114);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -113);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -112);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -111);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -110);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -109);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -108);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -107);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -106);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -105);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -104);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -103);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -102);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -101);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -100);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -96);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -95);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -94);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -93);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -92);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -91);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -90);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -89);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -88);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -87);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -86);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -85);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -84);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -83);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -82);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -81);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -80);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -79);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -78);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -77);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
