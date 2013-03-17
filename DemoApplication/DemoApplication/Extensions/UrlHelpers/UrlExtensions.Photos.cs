﻿#region credits
// ***********************************************************************
// Assembly	: DemoApplication
// Author	: Rod Johnson
// Created	: 02-24-2013
// 
// Last Modified By : Rod Johnson
// Last Modified On : 03-17-2013
// ***********************************************************************
#endregion
namespace DemoApplication.Extensions.UrlHelpers
{
    #region

    using System.Web.Mvc;
    using DemoApplication.Infrastructure.Photos;

    #endregion

    public static class PhotoHelpers
    {
        public static string GetPhotoUrl(this UrlHelper helper, string imageId, string size, string defaultUrl = null)
        {
            var photo = PhotoManager.Provider.GetPhotoResize(imageId, size);
            if (photo != null)
            {
                return helper.Content(photo.Url);
            }
            return defaultUrl != null ? helper.Content(defaultUrl) : "";
        }
    }
}