// Decompiled with JetBrains decompiler
// Type: eBay.Service.Util.MotorAttributeHelper
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Soap;
using System;


namespace eBay.Service.Util
{
  /// <summary>Helper class to work on motor attributes.</summary>
  public class MotorAttributeHelper
  {
    private AttributeSetType mSet;
    /// <summary>ID of Subtitle attribute.</summary>
    public const int ID_SUBTITLE = 10246;
    /// <summary>ID of DepositAmount attribute.</summary>
    public const int ID_DEPOSITAMOUNT = 10733;
    /// <summary>ID of DepositType attribute.</summary>
    public const int ID_DEPOSITTYPE = 10734;

    /// <summary>Constructor.</summary>
    /// <param name="ast">The object that contains the motor attributes that you want to access.</param>
    public MotorAttributeHelper(AttributeSetType ast) => this.mSet = ast;

    /// <summary>
    /// Get or set subtitle. Setting null string will remove Subtitle from the attribute list.
    /// </summary>
    public string Subtitle
    {
      get => AttributeHelper.GetValueLiteral(this.mSet, 10246);
      set
      {
        if (value == null || value.Length == 0)
          AttributeHelper.RemoveAttribute(this.mSet, 10246);
        else
          AttributeHelper.InsertToAttributeSet(this.mSet, 10246, 0, value);
      }
    }

    /// <summary>
    /// Get or set DepositAmount. Setting 0.0m will remove DepositType and DepositAmount
    /// from the attribute list.
    /// </summary>
    public Decimal DepositAmount
    {
      get
      {
        string valueLiteral = AttributeHelper.GetValueLiteral(this.mSet, 10733);
        return valueLiteral != null && valueLiteral.Length > 0 ? Decimal.Parse(valueLiteral) : 0.0M;
      }
      set
      {
        if (value == 0.0M)
        {
          AttributeHelper.RemoveAttribute(this.mSet, 10734);
          AttributeHelper.RemoveAttribute(this.mSet, 10733);
        }
        else
        {
          AttributeHelper.InsertToAttributeSet(this.mSet, 10733, 0, value.ToString());
          AttributeHelper.InsertToAttributeSet(this.mSet, 10734, 0, "1");
        }
      }
    }
  }
}
