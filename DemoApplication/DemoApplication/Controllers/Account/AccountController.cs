#region credits
// ***********************************************************************
// Assembly	: DemoApplication
// Author	: Rod Johnson
// Created	: 02-24-2013
// 
// Last Modified By : Rod Johnson
// Last Modified On : 03-21-2013
// ***********************************************************************
#endregion
namespace DemoApplication.Controllers.Account
{
    #region

    using System.Web.Mvc;
    using Core.Interfaces.Eventing;
    using Core.Interfaces.Membership;
    using Core.Interfaces.Service;
    using Filters;

    #endregion

    [ShowBreadcrumb(false)]
    public partial class AccountController : Controller
    {
        private readonly IUserService _userService;

        private readonly IAuthenticationService _authenticationService;
        private readonly IMessageBus _messageBus;
        private readonly IMembershipSettings _membershipSetings;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        /// <param name="userService">The user service.</param>
        /// <param name="authenticationService">The authentication service.</param>
        /// <param name="messageBus">The message bus.</param>
        /// <param name="membershipSetings"></param>
        public AccountController(IUserService userService, IAuthenticationService authenticationService, IMessageBus messageBus, IMembershipSettings membershipSetings)
        {
            _membershipSetings = membershipSetings;
            _messageBus = messageBus;
            _userService = userService;
            _authenticationService = authenticationService;
        }       
    }
}