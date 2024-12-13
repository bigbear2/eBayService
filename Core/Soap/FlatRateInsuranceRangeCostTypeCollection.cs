// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.FlatRateInsuranceRangeCostTypeCollection
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.Collections;


namespace eBay.Service.Core.Soap
{
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  public sealed class FlatRateInsuranceRangeCostTypeCollection : CollectionBase
  {
    /// <summary>
    /// 
    /// </summary>
    public FlatRateInsuranceRangeCostTypeCollection()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    public FlatRateInsuranceRangeCostTypeCollection(FlatRateInsuranceRangeCostType[] items)
    {
      this.AddRange(items);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    public FlatRateInsuranceRangeCostTypeCollection(FlatRateInsuranceRangeCostTypeCollection items)
    {
      this.AddRange(items);
    }

    /// <summary>
    /// 
    /// </summary>
    public FlatRateInsuranceRangeCostType this[int index]
    {
      get => (FlatRateInsuranceRangeCostType) this.InnerList[index];
      set => this.InnerList[index] = (object) value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool IsFixedSize => this.InnerList.IsFixedSize;

    /// <summary>
    /// 
    /// </summary>
    public bool IsReadOnly => this.InnerList.IsReadOnly;

    /// <summary>
    /// 
    /// </summary>
    public bool IsSynchronized => this.InnerList.IsSynchronized;

    /// <summary>
    /// 
    /// </summary>
    public object SyncRoot => this.InnerList.SyncRoot;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public int Add(FlatRateInsuranceRangeCostType item) => this.InnerList.Add((object) item);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    public void AddRange(FlatRateInsuranceRangeCostType[] items)
    {
      this.InnerList.AddRange((ICollection) items);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    public void AddRange(FlatRateInsuranceRangeCostTypeCollection items)
    {
      this.InnerList.AddRange((ICollection) items);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public bool Contains(FlatRateInsuranceRangeCostType item)
    {
      return this.InnerList.Contains((object) item);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    /// <param name="index"></param>
    public void CopyTo(FlatRateInsuranceRangeCostType[] items, int index)
    {
      this.InnerList.CopyTo((Array) items, index);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public int IndexOf(FlatRateInsuranceRangeCostType item)
    {
      return this.InnerList.IndexOf((object) item);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    /// <param name="item"></param>
    public void Insert(int index, FlatRateInsuranceRangeCostType item)
    {
      this.InnerList.Insert(index, (object) item);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public FlatRateInsuranceRangeCostType ItemAt(int index)
    {
      return (FlatRateInsuranceRangeCostType) this.InnerList[index];
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    public void Remove(FlatRateInsuranceRangeCostType item) => this.InnerList.Remove((object) item);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public FlatRateInsuranceRangeCostType[] ToArray()
    {
      return (FlatRateInsuranceRangeCostType[]) this.InnerList.ToArray(typeof (FlatRateInsuranceRangeCostType));
    }
  }
}
