// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace T4MVC
{
    public class DocsController
    {

        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string Index = "Index";
            }
            public readonly string Index = "~/Views/Docs/Index.cshtml";
            static readonly _WikiClass s_Wiki = new _WikiClass();
            public _WikiClass Wiki { get { return s_Wiki; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _WikiClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                public class _ViewNamesClass
                {
                    public readonly string Home = "Home";
                }
                public readonly string Home = "~/Views/Docs/Wiki/Home.md";
                static readonly _ContentClass s_Content = new _ContentClass();
                public _ContentClass Content { get { return s_Content; } }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public partial class _ContentClass
                {
                    static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                    public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                    public class _ViewNamesClass
                    {
                        public readonly string _Sidebar = "_Sidebar";
                        public readonly string About = "About";
                        public readonly string Additional_Help = "Additional-Help";
                        public readonly string ADO_Integration = "ADO-Integration";
                        public readonly string Ajax_Tab = "Ajax-Tab";
                        public readonly string boneyard = "boneyard";
                        public readonly string Configuration_Tab = "Configuration-Tab";
                        public readonly string Configuration = "Configuration";
                        public readonly string Contributing = "Contributing";
                        public readonly string Custom_Runtime_Policy = "Custom-Runtime-Policy";
                        public readonly string Custom_Tabs = "Custom-Tabs";
                        public readonly string Data_Endpoint = "Data-Endpoint";
                        public readonly string Debugging_with_SymbolSource = "Debugging-with-SymbolSource";
                        public readonly string Default_Tabs = "Default-Tabs";
                        public readonly string Documentation_Outline = "Documentation-Outline";
                        public readonly string Environment_Tab = "Environment-Tab";
                        public readonly string Execution_Tab = "Execution-Tab";
                        public readonly string Extensibility = "Extensibility";
                        public readonly string Extensions_Gallery = "Extensions-Gallery";
                        public readonly string First_Run = "First-Run";
                        public readonly string Getting_Started = "Getting-Started";
                        public readonly string History_Tab = "History-Tab";
                        public readonly string Installation = "Installation";
                        public readonly string Manual_install = "Manual-install";
                        public readonly string Metadata_Tab = "Metadata-Tab";
                        public readonly string Model_Binding_Tab = "Model-Binding-Tab";
                        public readonly string More_information = "More-information";
                        public readonly string More_plugin_examples = "More-plugin-examples";
                        public readonly string Platform_specification = "Platform-specification";
                        public readonly string Platform_structure = "Platform-structure";
                        public readonly string Plugin_extensions = "Plugin-extensions";
                        public readonly string Replacing_infrastructure = "Replacing-infrastructure";
                        public readonly string Request_Tab = "Request-Tab";
                        public readonly string Resource_Endpoints = "Resource-Endpoints";
                        public readonly string Routes_Tab = "Routes-Tab";
                        public readonly string Server_Port = "Server-Port";
                        public readonly string Server_Tab = "Server-Tab";
                        public readonly string Session_Tab = "Session-Tab";
                        public readonly string Specification = "Specification";
                        public readonly string Sql_tab = "Sql-tab";
                        public readonly string Timeline_Tab = "Timeline-Tab";
                        public readonly string Trace_Tab = "Trace-Tab";
                        public readonly string Troubleshooting = "Troubleshooting";
                        public readonly string Using_Glimpse = "Using-Glimpse";
                        public readonly string Views_Tab = "Views-Tab";
                    }
                    public readonly string _Sidebar = "~/Views/Docs/Wiki/Content/_Sidebar.md";
                    public readonly string About = "~/Views/Docs/Wiki/Content/About.md";
                    public readonly string Additional_Help = "~/Views/Docs/Wiki/Content/Additional-Help.md";
                    public readonly string ADO_Integration = "~/Views/Docs/Wiki/Content/ADO-Integration.md";
                    public readonly string Ajax_Tab = "~/Views/Docs/Wiki/Content/Ajax-Tab.md";
                    public readonly string boneyard = "~/Views/Docs/Wiki/Content/boneyard.md";
                    public readonly string Configuration_Tab = "~/Views/Docs/Wiki/Content/Configuration-Tab.md";
                    public readonly string Configuration = "~/Views/Docs/Wiki/Content/Configuration.md";
                    public readonly string Contributing = "~/Views/Docs/Wiki/Content/Contributing.md";
                    public readonly string Custom_Runtime_Policy = "~/Views/Docs/Wiki/Content/Custom-Runtime-Policy.md";
                    public readonly string Custom_Tabs = "~/Views/Docs/Wiki/Content/Custom-Tabs.md";
                    public readonly string Data_Endpoint = "~/Views/Docs/Wiki/Content/Data-Endpoint.md";
                    public readonly string Debugging_with_SymbolSource = "~/Views/Docs/Wiki/Content/Debugging-with-SymbolSource.md";
                    public readonly string Default_Tabs = "~/Views/Docs/Wiki/Content/Default-Tabs.md";
                    public readonly string Documentation_Outline = "~/Views/Docs/Wiki/Content/Documentation-Outline.md";
                    public readonly string Environment_Tab = "~/Views/Docs/Wiki/Content/Environment-Tab.md";
                    public readonly string Execution_Tab = "~/Views/Docs/Wiki/Content/Execution-Tab.md";
                    public readonly string Extensibility = "~/Views/Docs/Wiki/Content/Extensibility.md";
                    public readonly string Extensions_Gallery = "~/Views/Docs/Wiki/Content/Extensions-Gallery.md";
                    public readonly string First_Run = "~/Views/Docs/Wiki/Content/First-Run.md";
                    public readonly string Getting_Started = "~/Views/Docs/Wiki/Content/Getting-Started.md";
                    public readonly string History_Tab = "~/Views/Docs/Wiki/Content/History-Tab.md";
                    public readonly string Installation = "~/Views/Docs/Wiki/Content/Installation.md";
                    public readonly string Manual_install = "~/Views/Docs/Wiki/Content/Manual-install.md";
                    public readonly string Metadata_Tab = "~/Views/Docs/Wiki/Content/Metadata-Tab.md";
                    public readonly string Model_Binding_Tab = "~/Views/Docs/Wiki/Content/Model-Binding-Tab.md";
                    public readonly string More_information = "~/Views/Docs/Wiki/Content/More-information.md";
                    public readonly string More_plugin_examples = "~/Views/Docs/Wiki/Content/More-plugin-examples.md";
                    public readonly string Platform_specification = "~/Views/Docs/Wiki/Content/Platform-specification.md";
                    public readonly string Platform_structure = "~/Views/Docs/Wiki/Content/Platform-structure.md";
                    public readonly string Plugin_extensions = "~/Views/Docs/Wiki/Content/Plugin-extensions.md";
                    public readonly string Replacing_infrastructure = "~/Views/Docs/Wiki/Content/Replacing-infrastructure.md";
                    public readonly string Request_Tab = "~/Views/Docs/Wiki/Content/Request-Tab.md";
                    public readonly string Resource_Endpoints = "~/Views/Docs/Wiki/Content/Resource-Endpoints.md";
                    public readonly string Routes_Tab = "~/Views/Docs/Wiki/Content/Routes-Tab.md";
                    public readonly string Server_Port = "~/Views/Docs/Wiki/Content/Server-Port.md";
                    public readonly string Server_Tab = "~/Views/Docs/Wiki/Content/Server-Tab.md";
                    public readonly string Session_Tab = "~/Views/Docs/Wiki/Content/Session-Tab.md";
                    public readonly string Specification = "~/Views/Docs/Wiki/Content/Specification.md";
                    public readonly string Sql_tab = "~/Views/Docs/Wiki/Content/Sql-tab.md";
                    public readonly string Timeline_Tab = "~/Views/Docs/Wiki/Content/Timeline-Tab.md";
                    public readonly string Trace_Tab = "~/Views/Docs/Wiki/Content/Trace-Tab.md";
                    public readonly string Troubleshooting = "~/Views/Docs/Wiki/Content/Troubleshooting.md";
                    public readonly string Using_Glimpse = "~/Views/Docs/Wiki/Content/Using-Glimpse.md";
                    public readonly string Views_Tab = "~/Views/Docs/Wiki/Content/Views-Tab.md";
                }
                static readonly _imagesClass s_images = new _imagesClass();
                public _imagesClass images { get { return s_images; } }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public partial class _imagesClass
                {
                    static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                    public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                    public class _ViewNamesClass
                    {
                        public readonly string ajaxTab = "ajaxTab";
                        public readonly string channel9 = "channel9";
                        public readonly string closeGlimpse = "closeGlimpse";
                        public readonly string configurationTab = "configurationTab";
                        public readonly string dnr = "dnr";
                        public readonly string environmentTab = "environmentTab";
                        public readonly string executionTab = "executionTab";
                        public readonly string Glimpse128 = "Glimpse128";
                        public readonly string Glimpse256 = "Glimpse256";
                        public readonly string Glimpse32 = "Glimpse32";
                        public readonly string Glimpse512 = "Glimpse512";
                        public readonly string Glimpse64 = "Glimpse64";
                        public readonly string glimpseExtensionGallery = "glimpseExtensionGallery";
                        public readonly string glimpseLogo = "glimpseLogo";
                        public readonly string glimpseStatusBar = "glimpseStatusBar";
                        public readonly string hanselminutes = "hanselminutes";
                        public readonly string help = "help";
                        public readonly string herdingCode = "herdingCode";
                        public readonly string historyTab = "historyTab";
                        public readonly string manageNuGetPackages = "manageNuGetPackages";
                        public readonly string metadataTab = "metadataTab";
                        public readonly string modelBindingTab = "modelBindingTab";
                        public readonly string openGlimpse = "openGlimpse";
                        public readonly string requestTab = "requestTab";
                        public readonly string resizeGlimpse = "resizeGlimpse";
                        public readonly string routesTab = "routesTab";
                        public readonly string seriouslyOpen = "seriouslyOpen";
                        public readonly string serverTab = "serverTab";
                        public readonly string sessionTab = "sessionTab";
                        public readonly string sqlTab = "sqlTab";
                        public readonly string sqlTabError = "sqlTabError";
                        public readonly string sqlTabTimeline = "sqlTabTimeline";
                        public readonly string sqlTabTransactions = "sqlTabTransactions";
                        public readonly string timelineTab = "timelineTab";
                        public readonly string traceTab = "traceTab";
                        public readonly string updateAvailable = "updateAvailable";
                        public readonly string viewsTab = "viewsTab";
                    }
                    public readonly string ajaxTab = "~/Views/Docs/Wiki/images/ajaxTab.png";
                    public readonly string channel9 = "~/Views/Docs/Wiki/images/channel9.png";
                    public readonly string closeGlimpse = "~/Views/Docs/Wiki/images/closeGlimpse.gif";
                    public readonly string configurationTab = "~/Views/Docs/Wiki/images/configurationTab.png";
                    public readonly string dnr = "~/Views/Docs/Wiki/images/dnr.jpg";
                    public readonly string environmentTab = "~/Views/Docs/Wiki/images/environmentTab.png";
                    public readonly string executionTab = "~/Views/Docs/Wiki/images/executionTab.png";
                    public readonly string Glimpse128 = "~/Views/Docs/Wiki/images/Glimpse128.png";
                    public readonly string Glimpse256 = "~/Views/Docs/Wiki/images/Glimpse256.png";
                    public readonly string Glimpse32 = "~/Views/Docs/Wiki/images/Glimpse32.png";
                    public readonly string Glimpse512 = "~/Views/Docs/Wiki/images/Glimpse512.png";
                    public readonly string Glimpse64 = "~/Views/Docs/Wiki/images/Glimpse64.png";
                    public readonly string glimpseExtensionGallery = "~/Views/Docs/Wiki/images/glimpseExtensionGallery.png";
                    public readonly string glimpseLogo = "~/Views/Docs/Wiki/images/glimpseLogo.png";
                    public readonly string glimpseStatusBar = "~/Views/Docs/Wiki/images/glimpseStatusBar.png";
                    public readonly string hanselminutes = "~/Views/Docs/Wiki/images/hanselminutes.jpg";
                    public readonly string help = "~/Views/Docs/Wiki/images/help.png";
                    public readonly string herdingCode = "~/Views/Docs/Wiki/images/herdingCode.jpg";
                    public readonly string historyTab = "~/Views/Docs/Wiki/images/historyTab.png";
                    public readonly string manageNuGetPackages = "~/Views/Docs/Wiki/images/manageNuGetPackages.png";
                    public readonly string metadataTab = "~/Views/Docs/Wiki/images/metadataTab.png";
                    public readonly string modelBindingTab = "~/Views/Docs/Wiki/images/modelBindingTab.png";
                    public readonly string openGlimpse = "~/Views/Docs/Wiki/images/openGlimpse.gif";
                    public readonly string requestTab = "~/Views/Docs/Wiki/images/requestTab.png";
                    public readonly string resizeGlimpse = "~/Views/Docs/Wiki/images/resizeGlimpse.gif";
                    public readonly string routesTab = "~/Views/Docs/Wiki/images/routesTab.png";
                    public readonly string seriouslyOpen = "~/Views/Docs/Wiki/images/seriouslyOpen.jpg";
                    public readonly string serverTab = "~/Views/Docs/Wiki/images/serverTab.png";
                    public readonly string sessionTab = "~/Views/Docs/Wiki/images/sessionTab.png";
                    public readonly string sqlTab = "~/Views/Docs/Wiki/images/sqlTab.png";
                    public readonly string sqlTabError = "~/Views/Docs/Wiki/images/sqlTabError.png";
                    public readonly string sqlTabTimeline = "~/Views/Docs/Wiki/images/sqlTabTimeline.png";
                    public readonly string sqlTabTransactions = "~/Views/Docs/Wiki/images/sqlTabTransactions.png";
                    public readonly string timelineTab = "~/Views/Docs/Wiki/images/timelineTab.png";
                    public readonly string traceTab = "~/Views/Docs/Wiki/images/traceTab.png";
                    public readonly string updateAvailable = "~/Views/Docs/Wiki/images/updateAvailable.png";
                    public readonly string viewsTab = "~/Views/Docs/Wiki/images/viewsTab.png";
                }
                static readonly _SandboxClass s_Sandbox = new _SandboxClass();
                public _SandboxClass Sandbox { get { return s_Sandbox; } }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public partial class _SandboxClass
                {
                    static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                    public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                    public class _ViewNamesClass
                    {
                        public readonly string _Footer = "_Footer";
                        public readonly string _Header = "_Header";
                        public readonly string _Sidebar = "_Sidebar";
                        public readonly string Gollum = "Gollum";
                    }
                    public readonly string _Footer = "~/Views/Docs/Wiki/Sandbox/_Footer.md";
                    public readonly string _Header = "~/Views/Docs/Wiki/Sandbox/_Header.md";
                    public readonly string _Sidebar = "~/Views/Docs/Wiki/Sandbox/_Sidebar.md";
                    public readonly string Gollum = "~/Views/Docs/Wiki/Sandbox/Gollum.md";
                }
            }
        }
    }

}

#endregion T4MVC
#pragma warning restore 1591