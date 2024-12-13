﻿// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.RemoveFromWatchListResponseType
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;


namespace eBay.Service.Core.Soap
{
  /// <remarks />
  [GeneratedCode("CodeGen05", "1.0.7142.28876")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:ebay:apis:eBLBaseComponents")]
  [Serializable]
  public class RemoveFromWatchListResponseType : AbstractResponseType
  {
    private int mWatchListCount;
    private bool mWatchListCountSpecified;
    private int mWatchListMaximum;
    private bool mWatchListMaximumSpecified;

    /// <summary>
    /// 
    /// </summary>
    public int WatchListCount
    {
      get => this.mWatchListCount;
      set
      {
        this.mWatchListCount = value;
        this.mWatchListCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool WatchListCountSpecified
    {
      get => this.mWatchListCountSpecified;
      set => this.mWatchListCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int WatchListMaximum
    {
      get => this.mWatchListMaximum;
      set
      {
        this.mWatchListMaximum = value;
        this.mWatchListMaximumSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool WatchListMaximumSpecified
    {
      get => this.mWatchListMaximumSpecified;
      set => this.mWatchListMaximumSpecified = value;
    }
  }
}