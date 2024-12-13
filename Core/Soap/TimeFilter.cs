// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.TimeFilter
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.Runtime.InteropServices;


namespace eBay.Service.Core.Soap
{
  /// <summary>
  /// This class enables specification of time values for DateTime fields.
  /// Information and tips about DateTime objects are available in the MSDN library.
  /// This class contains properties for both local and GMT (UTC) time.
  /// If you use such properties of this class interchangably, the last property that is set overwrites the previous one.
  /// Note that if only the properties for local time are used, then the following can occur with an application: A local time (for example, 10 a.m.) is emitted by an application, and the API changes that time to GMT (for example, to 5 p.m.). And a GMT time from the API (for example, 1 p.m.) received by an application is converted to local time (for example, to 6 a.m.).
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class TimeFilter
  {
    private DateTime mTimeFrom;
    private DateTime mTimeTo;

    /// <summary>
    /// 
    /// </summary>
    public TimeFilter()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="TimeFrom"></param>
    /// <param name="TimeTo"></param>
    public TimeFilter(DateTime TimeFrom, DateTime TimeTo)
    {
      this.mTimeFrom = TimeFrom;
      this.mTimeTo = TimeTo;
    }

    /// <summary>
    /// Specifies a "time from" value that uses local computer time, regardless of the .NET Framework version used by the client.
    /// </summary>
    public DateTime TimeFrom
    {
      get => this.mTimeFrom;
      set => this.mTimeFrom = value;
    }

    /// <summary>
    /// Specifies a "time to" value that uses local computer time, regardless of the .NET Framework version used by the client.
    /// </summary>
    public DateTime TimeTo
    {
      get => this.mTimeTo;
      set => this.mTimeTo = value;
    }

    /// <summary>
    /// Specifies a "time from" value that uses UTC (GMT) time, regardless of the .NET Framework version used by the client.
    /// </summary>
    public DateTime TimeFromUTC
    {
      get => this.mTimeFrom.ToUniversalTime();
      set => this.mTimeFrom = value.ToLocalTime();
    }

    /// <summary>
    /// Specifies a "time to" value that uses UTC (GMT) time, regardless of the .NET Framework version used by the client.
    /// </summary>
    public DateTime TimeToUTC
    {
      get => this.mTimeTo.ToUniversalTime();
      set => this.mTimeTo = value.ToLocalTime();
    }
  }
}
