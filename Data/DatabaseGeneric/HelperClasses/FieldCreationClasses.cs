﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace PizzaOrder.HelperClasses
{
	/// <summary>Field Creation Class for entity OrderEntity</summary>
	public partial class OrderFields
	{
		/// <summary>Creates a new OrderEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.Id); }}
		/// <summary>Creates a new OrderEntity.Name field instance</summary>
		public static EntityField2 Name { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.Name); }}
	}

	/// <summary>Field Creation Class for entity OrderPizzaEntity</summary>
	public partial class OrderPizzaFields
	{
		/// <summary>Creates a new OrderPizzaEntity.OrderId field instance</summary>
		public static EntityField2 OrderId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderPizzaFieldIndex.OrderId); }}
		/// <summary>Creates a new OrderPizzaEntity.PizzaId field instance</summary>
		public static EntityField2 PizzaId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderPizzaFieldIndex.PizzaId); }}
	}

	/// <summary>Field Creation Class for entity PizzaEntity</summary>
	public partial class PizzaFields
	{
		/// <summary>Creates a new PizzaEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(PizzaFieldIndex.Id); }}
		/// <summary>Creates a new PizzaEntity.Name field instance</summary>
		public static EntityField2 Name { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(PizzaFieldIndex.Name); }}
		/// <summary>Creates a new PizzaEntity.Size field instance</summary>
		public static EntityField2 Size { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(PizzaFieldIndex.Size); }}
	}

	/// <summary>Field Creation Class for entity PizzaToppingEntity</summary>
	public partial class PizzaToppingFields
	{
		/// <summary>Creates a new PizzaToppingEntity.PizzaId field instance</summary>
		public static EntityField2 PizzaId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(PizzaToppingFieldIndex.PizzaId); }}
		/// <summary>Creates a new PizzaToppingEntity.ToppingId field instance</summary>
		public static EntityField2 ToppingId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(PizzaToppingFieldIndex.ToppingId); }}
	}

	/// <summary>Field Creation Class for entity ToppingEntity</summary>
	public partial class ToppingFields
	{
		/// <summary>Creates a new ToppingEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ToppingFieldIndex.Id); }}
		/// <summary>Creates a new ToppingEntity.Name field instance</summary>
		public static EntityField2 Name { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ToppingFieldIndex.Name); }}
		/// <summary>Creates a new ToppingEntity.Price field instance</summary>
		public static EntityField2 Price { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ToppingFieldIndex.Price); }}
	}
	

}