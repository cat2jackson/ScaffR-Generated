﻿namespace DemoApplication.Filters
{
    using System.Web.Mvc;

    public class ShowMainMenu : ActionFilterAttribute
    {
        private readonly bool _show;

        public ShowMainMenu(bool show = true)
        {
            _show = show;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.ShowMainMenu = _show;

            base.OnActionExecuted(filterContext);
        }
    }
}