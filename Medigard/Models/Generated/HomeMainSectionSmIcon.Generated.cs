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

[assembly: RegisterDocumentType(HomeMainSectionSmIcon.CLASS_NAME, typeof(HomeMainSectionSmIcon))]

namespace CMS.DocumentEngine.Types.Home
{
	/// <summary>
	/// Represents a content item of type HomeMainSectionSmIcon.
	/// </summary>
	public partial class HomeMainSectionSmIcon : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "Home.HomeMainSectionSmIcon";


		/// <summary>
		/// The instance of the class that provides extended API for working with HomeMainSectionSmIcon fields.
		/// </summary>
		private readonly HomeMainSectionSmIconFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// HomeMainSectionSmIconID.
		/// </summary>
		[DatabaseIDField]
		public int HomeMainSectionSmIconID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("HomeMainSectionSmIconID"), 0);
			}
			set
			{
				SetValue("HomeMainSectionSmIconID", value);
			}
		}


		/// <summary>
		/// SocialIcon.
		/// </summary>
		[DatabaseField]
		public string SocialIcon
		{
			get
			{
				return ValidationHelper.GetString(GetValue("SocialIcon"), @"");
			}
			set
			{
				SetValue("SocialIcon", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with HomeMainSectionSmIcon fields.
		/// </summary>
		[RegisterProperty]
		public HomeMainSectionSmIconFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with HomeMainSectionSmIcon fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class HomeMainSectionSmIconFields : AbstractHierarchicalObject<HomeMainSectionSmIconFields>
		{
			/// <summary>
			/// The content item of type HomeMainSectionSmIcon that is a target of the extended API.
			/// </summary>
			private readonly HomeMainSectionSmIcon mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="HomeMainSectionSmIconFields" /> class with the specified content item of type HomeMainSectionSmIcon.
			/// </summary>
			/// <param name="instance">The content item of type HomeMainSectionSmIcon that is a target of the extended API.</param>
			public HomeMainSectionSmIconFields(HomeMainSectionSmIcon instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// HomeMainSectionSmIconID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.HomeMainSectionSmIconID;
				}
				set
				{
					mInstance.HomeMainSectionSmIconID = value;
				}
			}


			/// <summary>
			/// SocialIcon.
			/// </summary>
			public string SocialIcon
			{
				get
				{
					return mInstance.SocialIcon;
				}
				set
				{
					mInstance.SocialIcon = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="HomeMainSectionSmIcon" /> class.
		/// </summary>
		public HomeMainSectionSmIcon() : base(CLASS_NAME)
		{
			mFields = new HomeMainSectionSmIconFields(this);
		}

		#endregion
	}
}