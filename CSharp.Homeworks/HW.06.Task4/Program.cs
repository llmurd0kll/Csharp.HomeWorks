using System.Globalization;
using System.Text;

double val = 1;
var now = DateTime.Now;
Console.OutputEncoding = Encoding.Unicode;
var enUs = new CultureInfo("en-US");
CultureInfo.DefaultThreadCurrentCulture = enUs;
Console.WriteLine($"Current culture USA: {CultureInfo.CurrentCulture.Name}");
Console.WriteLine($"The national currency is: {val:c}");
Console.WriteLine(enUs.DateTimeFormat.LongDatePattern);
Console.WriteLine(now.ToString(enUs.DateTimeFormat.LongDatePattern));
Console.WriteLine("\n");

var byBy = new CultureInfo("by-BY");
CultureInfo.DefaultThreadCurrentCulture = byBy;
Console.WriteLine($"Current culture Belarus: {CultureInfo.CurrentCulture.Name}");
Console.WriteLine($"The national currency is: {val:c}");
Console.WriteLine(byBy.DateTimeFormat.LongDatePattern);
Console.WriteLine(now.ToString(byBy.DateTimeFormat.LongDatePattern));
Console.WriteLine("\n");

var plPl = new CultureInfo("pl-Pl");
CultureInfo.DefaultThreadCurrentCulture = plPl;
Console.WriteLine($"Current culture Poland: {CultureInfo.CurrentCulture.Name}");
Console.WriteLine($"The national currency is: {val:c}");
Console.WriteLine(plPl.DateTimeFormat.LongDatePattern);
Console.WriteLine(now.ToString(plPl.DateTimeFormat.LongDatePattern));
Console.WriteLine("\n");

var zhCn = new CultureInfo("zh-CN");
CultureInfo.DefaultThreadCurrentCulture = zhCn;
Console.WriteLine($"Current culture China: {CultureInfo.CurrentCulture.Name}");
Console.WriteLine($"The national currency is: {val:c}");
Console.WriteLine(zhCn.DateTimeFormat.LongDatePattern);
Console.WriteLine(now.ToString(zhCn.DateTimeFormat.LongDatePattern));
Console.WriteLine("\n");

var enGb = new CultureInfo("en-GB");
CultureInfo.DefaultThreadCurrentCulture = enGb;
Console.WriteLine($"Current culture Great Britan: {CultureInfo.CurrentCulture.Name}");
Console.WriteLine($"The national currency is: {val:c}");
Console.WriteLine(enGb.DateTimeFormat.LongDatePattern);
Console.WriteLine(now.ToString(enGb.DateTimeFormat.LongDatePattern));
Console.WriteLine("\n");

var nlNL = new CultureInfo("nl-NL");
CultureInfo.DefaultThreadCurrentCulture = nlNL;
Console.WriteLine($"Current culture the Netherlends: {CultureInfo.CurrentCulture.Name}");
Console.WriteLine($"The national currency is: {val:c}");
Console.WriteLine(nlNL.DateTimeFormat.LongDatePattern);
Console.WriteLine(now.ToString(nlNL.DateTimeFormat.LongDatePattern));
Console.WriteLine("\n");

var itIt = new CultureInfo("it-It");
CultureInfo.DefaultThreadCurrentCulture = itIt;
Console.WriteLine($"Current culture Italy: {CultureInfo.CurrentCulture.Name}");
Console.WriteLine($"The national currency is: {val:c}");
Console.WriteLine(itIt.DateTimeFormat.LongDatePattern);
Console.WriteLine(now.ToString(itIt.DateTimeFormat.LongDatePattern));
Console.WriteLine("\n");

var frFR = new CultureInfo("fr-Fr");
CultureInfo.DefaultThreadCurrentCulture = frFR;
Console.WriteLine($"Current culture France: {CultureInfo.CurrentCulture.Name}");
Console.WriteLine($"The national currency is: {val:c}");
Console.WriteLine(frFR.DateTimeFormat.LongDatePattern);
Console.WriteLine(now.ToString(frFR.DateTimeFormat.LongDatePattern));
Console.WriteLine("\n");

var enCA = new CultureInfo("en-CA");
CultureInfo.DefaultThreadCurrentCulture = enCA;
Console.WriteLine($"Current culture Canada: {CultureInfo.CurrentCulture.Name}");
Console.WriteLine($"The national currency is: {val:c}");
Console.WriteLine(enCA.DateTimeFormat.LongDatePattern);
Console.WriteLine(now.ToString(enCA.DateTimeFormat.LongDatePattern));
Console.WriteLine("\n");