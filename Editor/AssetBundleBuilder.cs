#region Header
/*	============================================
 *	Aurthor 			    : Strix
 *	Initial Creation Date 	: 2020-04-10
 *	Summary 		        : 
 *  Template 		        : For Unity Editor V1
   ============================================ */
#endregion Header

#if ASSET_BUNDLE_BROWSER

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

namespace Jenkins
{
	/// <summary>
	/// 
	/// </summary>
	public class AssetBundleBuilder
	{
		/* const & readonly declaration             */

		const string const_strPrefix_ForDebugLog = "!@#$";

		/* enum & struct declaration                */

		/* public - Field declaration               */


		/* protected & private - Field declaration  */


		// ========================================================================== //

		/* public - [Do~Somthing] Function 	        */


		[MenuItem("Build/Bundle Build Test", priority = 10000)]
		static public void Build_Android()
		{
			AssetBundleBrowserWrapper pWrapper = new AssetBundleBrowserWrapper();
			pWrapper.DoBuildBundle();
		}

		// ========================================================================== //

		/* protected - [Override & Unity API]       */


		/* protected - [abstract & virtual]         */


		// ========================================================================== //

		#region Private

		#endregion Private
	}
}
#endif