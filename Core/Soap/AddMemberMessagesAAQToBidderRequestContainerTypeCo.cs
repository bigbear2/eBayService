﻿// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AddMemberMessagesAAQToBidderRequestContainerTypeCollection
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
  public sealed class AddMemberMessagesAAQToBidderRequestContainerTypeCollection : CollectionBase
  {
    /// <summary>
    /// 
    /// </summary>
    public AddMemberMessagesAAQToBidderRequestContainerTypeCollection()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    public AddMemberMessagesAAQToBidderRequestContainerTypeCollection(
      AddMemberMessagesAAQToBidderRequestContainerType[] items)
    {
      this.AddRange(items);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    public AddMemberMessagesAAQToBidderRequestContainerTypeCollection(
      AddMemberMessagesAAQToBidderRequestContainerTypeCollection items)
    {
      this.AddRange(items);
    }

    /// <summary>
    /// 
    /// </summary>
    public AddMemberMessagesAAQToBidderRequestContainerType this[int index]
    {
      get => (AddMemberMessagesAAQToBidderRequestContainerType) this.InnerList[index];
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
    public int Add(
      AddMemberMessagesAAQToBidderRequestContainerType item)
    {
      return this.InnerList.Add((object) item);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    public void AddRange(
      AddMemberMessagesAAQToBidderRequestContainerType[] items)
    {
      this.InnerList.AddRange((ICollection) items);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    public void AddRange(
      AddMemberMessagesAAQToBidderRequestContainerTypeCollection items)
    {
      this.InnerList.AddRange((ICollection) items);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public bool Contains(
      AddMemberMessagesAAQToBidderRequestContainerType item)
    {
      return this.InnerList.Contains((object) item);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    /// <param name="index"></param>
    public void CopyTo(
      AddMemberMessagesAAQToBidderRequestContainerType[] items,
      int index)
    {
      this.InnerList.CopyTo((Array) items, index);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public int IndexOf(
      AddMemberMessagesAAQToBidderRequestContainerType item)
    {
      return this.InnerList.IndexOf((object) item);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    /// <param name="item"></param>
    public void Insert(
      int index,
      AddMemberMessagesAAQToBidderRequestContainerType item)
    {
      this.InnerList.Insert(index, (object) item);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public AddMemberMessagesAAQToBidderRequestContainerType ItemAt(int index)
    {
      return (AddMemberMessagesAAQToBidderRequestContainerType) this.InnerList[index];
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    public void Remove(
      AddMemberMessagesAAQToBidderRequestContainerType item)
    {
      this.InnerList.Remove((object) item);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public AddMemberMessagesAAQToBidderRequestContainerType[] ToArray()
    {
      return (AddMemberMessagesAAQToBidderRequestContainerType[]) this.InnerList.ToArray(typeof (AddMemberMessagesAAQToBidderRequestContainerType));
    }
  }
}