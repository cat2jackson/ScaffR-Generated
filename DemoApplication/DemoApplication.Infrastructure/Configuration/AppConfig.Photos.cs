#region credits
// ***********************************************************************
// Assembly	: DemoApplication.Infrastructure
// Author	: Rod Johnson
// Created	: 03-16-2013
// 
// Last Modified By : Rod Johnson
// Last Modified On : 03-21-2013
// ***********************************************************************
#endregion
namespace DemoApplication.Infrastructure.Configuration
{
    #region

    using System.Configuration;
    using Photos.Configuration;

    #endregion

    public partial class AppConfig
    {
        [ConfigurationProperty("photos", IsRequired = true)]
        public PhotoElement Photos
        {
            get
            {
                return (PhotoElement)base["photos"];
            }
        }
    }
}
