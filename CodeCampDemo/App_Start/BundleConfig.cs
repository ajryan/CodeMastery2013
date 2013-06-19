﻿using System.Web.Optimization;

namespace CodeCampDemo.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.hotkeys.js"));

            bundles.Add(new ScriptBundle("~/bundles/handlebars").Include(
                        "~/Scripts/handlebars.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/bundles/base").Include(
                "~/Content/reset.css",
                "~/Content/site.css"));
        }
    }
}