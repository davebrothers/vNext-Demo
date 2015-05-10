using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;
using System.Collections.Generic;

namespace MvcSample.Web
{
    public class GetStarted : Controller
    {
        public IActionResult Index()
        {
            var vm = new List<MacTool>();
            
            vm.Add(new MacTool{ Name = "OS X Command Line Tools", Description = "Downloadable from the Apple App Store", 
                Link = "http://osxdaily.com/2014/02/12/install-command-line-tools-mac-os-x/", LinkText = "Easy Terminal Install"});
            
            vm.Add(new MacTool{ Name = "Git", Description = "DVCS application -- many of the tools you will need are available as git repositories.",
                Link = "http://git-scm.com/downloads", LinkText = "Git Downloads"});
                
            vm.Add(new MacTool{ Name = "Homebrew", Description = "Installs from Terminal using Git and Ruby (which ships with OS X).<br/>Places packages into " + 
                "<code>/usr/local/Cellar</code> and then symlinks the contents into <code>/usr/local/bin.</code></br>",
                Link = "http://brew.sh", LinkText = "brew.sh"});
                
            vm.Add(new MacTool{ Name = "Node", Description = "Super magical JavaScript do-things extravaganza.<br/>Ends up being pretty crucial to development " + 
                "<br/>Install via Homebrew: <code>brew install node</code>",
                Link = "http://nodejs.org", LinkText = "nodejs.org"});
                
            vm.Add(new MacTool{ Name = "DNVM", Description = "<strong>D</strong>ot <strong>N</strong>et <strong>V</strong>ersion <strong>M</strong>anager " +
                "<br/>Command line tools that facilitate fetching and configuring .NET runtimes.<br/>Install via Homebrew:<br/><code>brew tap aspnet/dnx</code><br/>" +
                "<code>brew update</code><br/><code>brew install dnvm</code><br/>Add <code>source dnvm.sh</code> to .bash_profile<br/><code>dnvm upgrade</code><br/>" +
                "<code>dnvm list</code> will show you all available runtimes.",
                Link = "https://github.com/aspnet/dnvm", LinkText = "DNVM on GitHub"});
            
            return View(vm);
        }
        
        public IActionResult NewProject()
        {
            return View();
        }
    }
}