﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Home;

[assembly: RegisterDocumentType(HomeMainSectionFaqItem.CLASS_NAME, typeof(HomeMainSectionFaqItem))]

namespace CMS.DocumentEngine.Types.Home
{
	/// <summary>
	/// Represents a content item of type HomeMainSectionFaqItem.
	/// </summary>
	public partial class HomeMainSectionFaqItem : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "Home.HomeMainSectionFaqItem";


		/// <summary>
		/// The instance of the class that provides extended API for working with HomeMainSectionFaqItem fields.
		/// </summary>
		private readonly HomeMainSectionFaqItemFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// HomeMainSectionFaqItemID.
		/// </summary>
		[DatabaseIDField]
		public int HomeMainSectionFaqItemID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("HomeMainSectionFaqItemID"), 0);
			}
			set
			{
				SetValue("HomeMainSectionFaqItemID", value);
			}
		}


		/// <summary>
		/// Question.
		/// </summary>
		[DatabaseField]
		public string Question
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Question"), @"");
			}
			set
			{
				SetValue("Question", value);
			}
		}


		/// <summary>
		/// Answer.
		/// </summary>
		[DatabaseField]
		public string Answer
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Answer"), @"");
			}
			set
			{
				SetValue("Answer", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with HomeMainSectionFaqItem fields.
		/// </summary>
		[RegisterProperty]
		public HomeMainSectionFaqItemFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with HomeMainSectionFaqItem fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class HomeMainSectionFaqItemFields : AbstractHierarchicalObject<HomeMainSectionFaqItemFields>
		{
			/// <summary>
			/// The content item of type HomeMainSectionFaqItem that is a target of the extended API.
			/// </summary>
			private readonly HomeMainSectionFaqItem mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="HomeMainSectionFaqItemFields" /> class with the specified content item of type HomeMainSectionFaqItem.
			/// </summary>
			/// <param name="instance">The content item of type HomeMainSectionFaqItem that is a target of the extended API.</param>
			public HomeMainSectionFaqItemFields(HomeMainSectionFaqItem instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// HomeMainSectionFaqItemID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.HomeMainSectionFaqItemID;
				}
				set
				{
					mInstance.HomeMainSectionFaqItemID = value;
				}
			}


			/// <summary>
			/// Question.
			/// </summary>
			public string Question
			{
				get
				{
					return mInstance.Question;
				}
				set
				{
					mInstance.Question = value;
				}
			}


			/// <summary>
			/// Answer.
			/// </summary>
			public string Answer
			{
				get
				{
					return mInstance.Answer;
				}
				set
				{
					mInstance.Answer = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="HomeMainSectionFaqItem" /> class.
		/// </summary>
		public HomeMainSectionFaqItem() : base(CLASS_NAME)
		{
			mFields = new HomeMainSectionFaqItemFields(this);
		}

		#endregion
	}
}