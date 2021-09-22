﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using PizzaOrder.HelperClasses;
using PizzaOrder.FactoryClasses;
using PizzaOrder.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace PizzaOrder.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Pizza'.<br/><br/></summary>
	[Serializable]
	public partial class PizzaEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private EntityCollection<OrderPizzaEntity> _orderPizzas;
		private EntityCollection<PizzaToppingEntity> _pizzaToppings;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static PizzaEntityStaticMetaData _staticMetaData = new PizzaEntityStaticMetaData();
		private static PizzaRelations _relationsFactory = new PizzaRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name OrderPizzas</summary>
			public static readonly string OrderPizzas = "OrderPizzas";
			/// <summary>Member name PizzaToppings</summary>
			public static readonly string PizzaToppings = "PizzaToppings";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class PizzaEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public PizzaEntityStaticMetaData()
			{
				SetEntityCoreInfo("PizzaEntity", InheritanceHierarchyType.None, false, (int)PizzaOrder.EntityType.PizzaEntity, typeof(PizzaEntity), typeof(PizzaEntityFactory), false);
				AddNavigatorMetaData<PizzaEntity, EntityCollection<OrderPizzaEntity>>("OrderPizzas", a => a._orderPizzas, (a, b) => a._orderPizzas = b, a => a.OrderPizzas, () => new PizzaRelations().OrderPizzaEntityUsingPizzaId, typeof(OrderPizzaEntity), (int)PizzaOrder.EntityType.OrderPizzaEntity);
				AddNavigatorMetaData<PizzaEntity, EntityCollection<PizzaToppingEntity>>("PizzaToppings", a => a._pizzaToppings, (a, b) => a._pizzaToppings = b, a => a.PizzaToppings, () => new PizzaRelations().PizzaToppingEntityUsingPizzaId, typeof(PizzaToppingEntity), (int)PizzaOrder.EntityType.PizzaToppingEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static PizzaEntity()
		{
		}

		/// <summary> CTor</summary>
		public PizzaEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PizzaEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PizzaEntity</param>
		public PizzaEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Pizza which data should be fetched into this Pizza object</param>
		public PizzaEntity(System.Int64 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Pizza which data should be fetched into this Pizza object</param>
		/// <param name="validator">The custom validator object for this PizzaEntity</param>
		public PizzaEntity(System.Int64 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PizzaEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'OrderPizza' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoOrderPizzas() { return CreateRelationInfoForNavigator("OrderPizzas"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PizzaTopping' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPizzaToppings() { return CreateRelationInfoForNavigator("PizzaToppings"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this PizzaEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END


			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static PizzaRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'OrderPizza' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathOrderPizzas { get { return _staticMetaData.GetPrefetchPathElement("OrderPizzas", CommonEntityBase.CreateEntityCollection<OrderPizzaEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PizzaTopping' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPizzaToppings { get { return _staticMetaData.GetPrefetchPathElement("PizzaToppings", CommonEntityBase.CreateEntityCollection<PizzaToppingEntity>()); } }

		/// <summary>The Id property of the Entity Pizza<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Pizza"."Id".<br/>Table field type characteristics (type, precision, scale, length): Bigint, 20, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)PizzaFieldIndex.Id, true); }
			set { SetValue((int)PizzaFieldIndex.Id, value); }		}

		/// <summary>The Name property of the Entity Pizza<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Pizza"."Name".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)PizzaFieldIndex.Name, true); }
			set	{ SetValue((int)PizzaFieldIndex.Name, value); }
		}

		/// <summary>The Size property of the Entity Pizza<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Pizza"."Size".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Size
		{
			get { return (System.String)GetValue((int)PizzaFieldIndex.Size, true); }
			set	{ SetValue((int)PizzaFieldIndex.Size, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'OrderPizzaEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(OrderPizzaEntity))]
		public virtual EntityCollection<OrderPizzaEntity> OrderPizzas { get { return GetOrCreateEntityCollection<OrderPizzaEntity, OrderPizzaEntityFactory>("Pizza", true, false, ref _orderPizzas); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'PizzaToppingEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PizzaToppingEntity))]
		public virtual EntityCollection<PizzaToppingEntity> PizzaToppings { get { return GetOrCreateEntityCollection<PizzaToppingEntity, PizzaToppingEntityFactory>("Pizza", true, false, ref _pizzaToppings); } }
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace PizzaOrder
{
	public enum PizzaFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		///<summary>Size. </summary>
		Size,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace PizzaOrder.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Pizza. </summary>
	public partial class PizzaRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between PizzaEntity and OrderPizzaEntity over the 1:n relation they have, using the relation between the fields: Pizza.Id - OrderPizza.PizzaId</summary>
		public virtual IEntityRelation OrderPizzaEntityUsingPizzaId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "OrderPizzas", true, new[] { PizzaFields.Id, OrderPizzaFields.PizzaId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between PizzaEntity and PizzaToppingEntity over the 1:n relation they have, using the relation between the fields: Pizza.Id - PizzaTopping.PizzaId</summary>
		public virtual IEntityRelation PizzaToppingEntityUsingPizzaId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "PizzaToppings", true, new[] { PizzaFields.Id, PizzaToppingFields.PizzaId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticPizzaRelations
	{
		internal static readonly IEntityRelation OrderPizzaEntityUsingPizzaIdStatic = new PizzaRelations().OrderPizzaEntityUsingPizzaId;
		internal static readonly IEntityRelation PizzaToppingEntityUsingPizzaIdStatic = new PizzaRelations().PizzaToppingEntityUsingPizzaId;

		/// <summary>CTor</summary>
		static StaticPizzaRelations() { }
	}
}
