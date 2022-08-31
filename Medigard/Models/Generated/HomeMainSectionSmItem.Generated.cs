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

[assembly: RegisterDocumentType(HomeMainSectionSmItem.CLASS_NAME, typeof(HomeMainSectionSmItem))]

namespace CMS.DocumentEngine.Types.Home
{
	/// <summary>
	/// Represents a content item of type HomeMainSectionSmItem.
	/// </summary>
	public partial class HomeMainSectionSmItem : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "Home.HomeMainSectionSmItem";


		/// <summary>
		/// The instance of the class that provides extended API for working with HomeMainSectionSmItem fields.
		/// </summary>
		private readonly HomeMainSectionSmItemFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// HomeMainSectionSmItemID.
		/// </summary>
		[DatabaseIDField]
		public int HomeMainSectionSmItemID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("HomeMainSectionSmItemID"), 0);
			}
			set
			{
				SetValue("HomeMainSectionSmItemID", value);
			}
		}


		/// <summary>
		/// Image.
		/// </summary>
		[DatabaseField]
		public string Image
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Image"), @"");
			}
			set
			{
				SetValue("Image", value);
			}
		}


		/// <summary>
		/// Explanation.
		/// </summary>
		[DatabaseField]
		public string Explanation
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Explanation"), @"");
			}
			set
			{
				SetValue("Explanation", value);
			}
		}


		/// <summary>
		/// Comment.
		/// </summary>
		[DatabaseField]
		public string Comment
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Comment"), @"");
			}
			set
			{
				SetValue("Comment", value);
			}
		}


		/// <summary>
		/// Like.
		/// </summary>
		[DatabaseField]
		public string Like
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Like"), @"");
			}
			set
			{
				SetValue("Like", value);
			}
		}


		/// <summary>
		/// Icon.
		/// </summary>
		[DatabaseField]
		public string Icon1
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Icon"), @"");
			}
			set
			{
				SetValue("Icon", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with HomeMainSectionSmItem fields.
		/// </summary>
		[RegisterProperty]
		public HomeMainSectionSmItemFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with HomeMainSectionSmItem fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class HomeMainSectionSmItemFields : AbstractHierarchicalObject<HomeMainSectionSmItemFields>
		{
			/// <summary>
			/// The content item of type HomeMainSectionSmItem that is a target of the extended API.
			/// </summary>
			private readonly HomeMainSectionSmItem mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="HomeMainSectionSmItemFields" /> class with the specified content item of type HomeMainSectionSmItem.
			/// </summary>
			/// <param name="instance">The content item of type HomeMainSectionSmItem that is a target of the extended API.</param>
			public HomeMainSectionSmItemFields(HomeMainSectionSmItem instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// HomeMainSectionSmItemID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.HomeMainSectionSmItemID;
				}
				set
				{
					mInstance.HomeMainSectionSmItemID = value;
				}
			}


			/// <summary>
			/// Image.
			/// </summary>
			public string Image
			{
				get
				{
					return mInstance.Image;
				}
				set
				{
					mInstance.Image = value;
				}
			}


			/// <summary>
			/// Explanation.
			/// </summary>
			public string Explanation
			{
				get
				{
					return mInstance.Explanation;
				}
				set
				{
					mInstance.Explanation = value;
				}
			}


			/// <summary>
			/// Comment.
			/// </summary>
			public string Comment
			{
				get
				{
					return mInstance.Comment;
				}
				set
				{
					mInstance.Comment = value;
				}
			}


			/// <summary>
			/// Like.
			/// </summary>
			public string Like
			{
				get
				{
					return mInstance.Like;
				}
				set
				{
					mInstance.Like = value;
				}
			}


			/// <summary>
			/// Icon.
			/// </summary>
			public string Icon
			{
				get
				{
					return mInstance.Icon1;
				}
				set
				{
					mInstance.Icon1 = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="HomeMainSectionSmItem" /> class.
		/// </summary>
		public HomeMainSectionSmItem() : base(CLASS_NAME)
		{
			mFields = new HomeMainSectionSmItemFields(this);
		}

		#endregion
	}
}